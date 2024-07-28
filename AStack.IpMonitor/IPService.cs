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
                _logger.LogInformation("检查开始");
                CheckIP();
                _logger.LogInformation("检查完毕");
            }
            catch (Exception ex)
            {
                _logger.LogWarning("检查IP出错：" + ex);
                throw;
            }
            await Task.Delay(_cycleTime, stoppingToken);
        }
    }

    /// <summary>
    /// 检查IP。若发生改变则发送邮件。
    /// </summary>
    /// <returns></returns>
    public void CheckIP()
    {
        //获取IP
        _logger.LogInformation("获取IP开始");
        var ip = GetIp();
        _logger.LogInformation("获取IP成功，IP：" + ip);
        //记录IP的文件路径
        var filePath = Path.Combine(AppContext.BaseDirectory, "my.ip");
        string oldIp = null;
        if (File.Exists(filePath))
        {
            oldIp = File.ReadAllText(filePath);
        }
        //判断IP是否发生变化，若发生变化，记录新IP并发送邮件
        if (ip == oldIp)
        {
            _logger.LogInformation("IP未发生变化。");
            return;
        }

        _logger.LogInformation("IP发生变化，开始记录并发送邮件。");
        File.WriteAllText(filePath, ip);
        _logger.LogInformation("IP记录成功。");
        _emailHelper.SendIpEmail(ip);
        _logger.LogInformation("邮件发送成功。");
    }

    /// <summary>
    /// 获取现在的公网IP
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
