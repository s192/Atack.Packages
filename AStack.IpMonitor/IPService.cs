using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace AStack.IpMonitor;

public class IPService : BackgroundService
{
    private readonly int _cycleTime;

    private readonly EmailHelper _emailHelper;
    private readonly ILogger<IPService> _logger;
    private readonly IConfiguration _configuration;

    public IPService(EmailHelper emailHelper, ILogger<IPService> logger, IConfiguration configuration)
    {
        _emailHelper = emailHelper;
        _logger = logger;
        _configuration = configuration;
        _cycleTime = (int)TimeSpan.FromMinutes(double.Parse(configuration["CycleTime"])).TotalMilliseconds;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        while (!stoppingToken.IsCancellationRequested)
        {
            try
            {
                _logger.LogInformation("��鿪ʼ");
                CheckIP();
                _logger.LogInformation("������");
            }
            catch (Exception ex)
            {
                _logger.LogWarning("���IP����" + ex);
                throw;
            }
            await Task.Delay(_cycleTime, stoppingToken);
        }
    }

    /// <summary>
    /// ���IP���������ı������ʼ���
    /// </summary>
    /// <returns></returns>
    public void CheckIP()
    {
        //��ȡIP
        _logger.LogInformation("��ȡIP��ʼ");
        var ip = GetIp();
        _logger.LogInformation("��ȡIP�ɹ���IP��" + ip);
        //��¼IP���ļ�·��
        var filePath = Path.Combine(AppContext.BaseDirectory, "my.ip");
        string oldIp = null;
        if (File.Exists(filePath))
        {
            oldIp = File.ReadAllText(filePath);
        }
        //�ж�IP�Ƿ����仯���������仯����¼��IP�������ʼ�
        if (ip == oldIp)
        {
            _logger.LogInformation("IPδ�����仯��");
            return;
        }

        _logger.LogInformation("IP�����仯����ʼ��¼�������ʼ���");
        File.WriteAllText(filePath, ip);
        _logger.LogInformation("IP��¼�ɹ���");
        _emailHelper.SendIpEmail(ip);
        _logger.LogInformation("�ʼ����ͳɹ���");
    }

    /// <summary>
    /// ��ȡ���ڵĹ���IP
    /// </summary>
    /// <returns></returns>
    private string GetIp()
    {
        using var httpClient = new HttpClient();
        var url = "https://qifu-api.baidubce.com/ip/local/geo/v1/district";
        var strTask = httpClient.GetStringAsync(url);
        strTask.Wait();
        var str = strTask.Result;
        var index = str.IndexOf("\"ip\":\"");
        str = str.Substring(index + 6);
        str = str.Substring(0, str.IndexOf('\"'));
        return str;
    }
}
