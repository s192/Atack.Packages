using System.Diagnostics;
using System.Drawing;

namespace AStack.BitMapCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            ////导出【透显】功能类型选择的图标
            //BitmapHelper.CreateStEnumType(BitmapHelper.DyeEnumType.面, "透明面", "DeTool_St_Face0", false);
            //BitmapHelper.CreateStEnumType(BitmapHelper.DyeEnumType.体, "透明体", "DeTool_St_Body0", false);
            //BitmapHelper.CreateStEnumType(BitmapHelper.DyeEnumType.面, "透明面", "DeTool_St_Face1", true);
            //BitmapHelper.CreateStEnumType(BitmapHelper.DyeEnumType.体, "透明体", "DeTool_St_Body1", true);

            ////生成【批量转X_T】功能类型选择的图标
            //BitmapHelper.CreatCommandTextBmp("X_T", "DeTool_TP", 30, Color.DeepPink, Color.White);

            ////生成改名功能类型选择的图标
            //BitmapHelper.CreatCommandTextBmp("单个\n改名", "DeTool_CN", 30, Color.DarkBlue, Color.White);
            //BitmapHelper.CreatCommandTextBmp("批量\n改名", "DeTool_BR", 30, Color.SteelBlue, Color.White);

            ////生成【批量转DWG】功能类型选择的图标
            //BitmapHelper.CreatCommandTextBmp("2D", "DeTool_DE", 30, Color.OrangeRed, "DWG");
            //BitmapHelper.CreatCommandTextBmp("CGM", "DeTool_DC", 25, Color.IndianRed, "DWG");
            //BitmapHelper.CreatCommandTextBmp("PDF", "DeTool_PD", 25, Color.Firebrick, "DWG");

            BitmapHelper.CreatCommandTextBmp("DeTool_UD", "DWG");

            var path = BitmapHelper.GetRuntimePath();
            Process.Start("explorer", "\"" + path + "\"");
        }
    }
}
