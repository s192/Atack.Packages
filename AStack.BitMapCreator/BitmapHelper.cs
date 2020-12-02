using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;

namespace AStack.BitMapCreator
{
    /// <summary>
    /// Bitmap
    /// </summary>
    internal static class BitmapHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <param name="name"></param>
        /// <param name="fileName"></param>
        public static void CreateColor(Color color, string name, string fileName, string directory)
        {
            var bmp = new Bitmap(60, 30);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    if (j < 15 || string.IsNullOrWhiteSpace(name))
                    {
                        bmp.SetPixel(i, j, color);
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                }
            }

            var graphics = Graphics.FromImage(bmp);
            var font = new Font("宋体", 8);
            var sbrush = new SolidBrush(Color.Black);
            var rectangle = new RectangleF(0, 17, 60, 13);
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            graphics.DrawString(name, font, sbrush, rectangle, stringFormat);
            var filePath = Path.Combine(directory, fileName + ".bmp");
            bmp.Save(filePath, ImageFormat.Bmp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="select"></param>
        public static void CreateDyeEnumType(DyeEnumType type, string image, bool select)
        {
            var bmp = new Bitmap(105, 80);

            var backgroundColor = select ? Color.Orange : Color.LightGray;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < 25; j++)
                {
                    bmp.SetPixel(i, j, backgroundColor);
                }
            }

            var graphics = Graphics.FromImage(bmp);
            var img = new Bitmap(image);
            var descRect = new RectangleF(0, 25, 105, 55);
            graphics.DrawImage(img, descRect);

            var font = new Font("Microsoft YaHei", 14, FontStyle.Bold);

            var brushColor = select ? Color.White : Color.Black;
            var sbrush = new SolidBrush(brushColor);

            var str = type.ToString();
            PointF point;
            if (str.Length == 1)
            {
                point = new PointF(41, 0);
            }
            else if (str.Length == 2)
            {
                point = new PointF(31, 0);
            }
            else
            {
                throw new NotImplementedException();
            }

            graphics.DrawString(str, font, sbrush, point);

            var fileName = @"C:\Users\mmzx\Desktop\bitmap2.bmp";
            bmp.Save(fileName, ImageFormat.Bmp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="select"></param>
        public static void CreateStEnumType(DyeEnumType type, string imageName, string fileName, bool select)
        {
            var bmp = new Bitmap(120, 100);

            var backgroundColor = select ? Color.Orange : Color.LightGray;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < 28; j++)
                {
                    bmp.SetPixel(i, j, backgroundColor);
                }
            }

            var graphics = Graphics.FromImage(bmp);

            Bitmap img = null;
            var assembly = Assembly.GetExecutingAssembly();
            //获取指定的资源
            using (Stream stream = assembly.GetManifestResourceStream($"AStack.BitMapCreator.Image.{imageName}.bmp"))
            {
                if (stream != null)  //没有找到，GetManifestResourceStream会返回null
                {
                    img = new Bitmap(stream);
                }
            }

            if (img == null)
            {
                return;
            }

            var descRect = new RectangleF(0, 28, 120, 72);
            graphics.DrawImage(img, descRect);

            var font = new Font("Microsoft YaHei", 15, FontStyle.Bold);

            var brushColor = select ? Color.White : Color.Black;
            var sbrush = new SolidBrush(brushColor);

            var str = type.ToString();
            PointF point;
            if (str.Length == 1)
            {
                point = new PointF(48, 0);
            }
            else if (str.Length == 2)
            {
                point = new PointF(31, 0);
            }
            else
            {
                throw new NotImplementedException();
            }

            graphics.DrawString(str, font, sbrush, point);

            var path = Path.Combine(GetRuntimePath(), fileName + ".bmp");
            bmp.Save(path, ImageFormat.Bmp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="select"></param>
        public static void CreatCommandTextBmp(string text, string fileName, float fontSize, Color textColor, Color backgroundColor)
        {
            var bmp = new Bitmap(100, 100);

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    bmp.SetPixel(i, j, backgroundColor);
                }
            }

            var graphics = Graphics.FromImage(bmp);
            var font = new Font("Microsoft YaHei", fontSize, FontStyle.Bold);
            var sbrush = new SolidBrush(textColor);
            var rectangle = new RectangleF(0, 0, 100, 100);
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            graphics.SmoothingMode = SmoothingMode.AntiAlias; //使绘图质量最高，即消除锯齿
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.DrawString(text, font, sbrush, rectangle, stringFormat);

            var path = Path.Combine(GetRuntimePath(), fileName + ".bmp");
            bmp.Save(path, ImageFormat.Bmp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="select"></param>
        public static void CreatCommandTextBmp(string text, string fileName, float fontSize, Color textColor, string backgroundImage)
        {
            var bmp = new Bitmap(100, 100);


            var graphics = Graphics.FromImage(bmp);

            Bitmap img = null;
            var assembly = Assembly.GetExecutingAssembly();
            //获取指定的资源
            using (Stream stream = assembly.GetManifestResourceStream($"AStack.BitMapCreator.Image.{backgroundImage}.bmp"))
            {
                if (stream != null)  //没有找到，GetManifestResourceStream会返回null
                {
                    img = new Bitmap(stream);
                }
            }

            if (img == null)
            {
                return;
            }

            var descRect = new Rectangle(0, 0, 100, 100);
            graphics.DrawImage(img, descRect);

            var font = new Font("Microsoft YaHei", fontSize, FontStyle.Bold);
            var sbrush = new SolidBrush(textColor);
            var rectangle = new RectangleF(0, 0, 100, 100);
            var stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;
            graphics.SmoothingMode = SmoothingMode.AntiAlias; //使绘图质量最高，即消除锯齿
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.DrawString(text, font, sbrush, rectangle, stringFormat);

            var path = Path.Combine(GetRuntimePath(), fileName + ".bmp");
            bmp.Save(path, ImageFormat.Bmp);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="type"></param>
        /// <param name="select"></param>
        public static void CreatCommandTextBmp(string fileName, string backgroundImage)
        {
            var bmp = new Bitmap(100, 100);


            var graphics = Graphics.FromImage(bmp);

            Bitmap img = null;
            var assembly = Assembly.GetExecutingAssembly();
            //获取指定的资源
            using (Stream stream = assembly.GetManifestResourceStream($"AStack.BitMapCreator.Image.{backgroundImage}.bmp"))
            {
                if (stream != null)  //没有找到，GetManifestResourceStream会返回null
                {
                    img = new Bitmap(stream);
                }
            }

            if (img == null)
            {
                return;
            }

            var descRect = new Rectangle(0, 0, 100, 100);
            graphics.DrawImage(img, descRect);

            var path = Path.Combine(GetRuntimePath(), fileName + ".bmp");
            bmp.Save(path, ImageFormat.Bmp);
        }

        public enum DyeEnumType
        {
            面,
            体,
            全部
        }

        /// <summary>
        /// 获取当前程序集所在的目录
        /// </summary>
        public static string GetRuntimePath()
        {
            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            var directory = Path.GetDirectoryName(path);
            return directory;
        }
    }
}
