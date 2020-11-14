namespace AStack.BitMapCreator
{
    class Program
    {
        static void Main(string[] args)
        {
            BitmapHelper.CreateStEnumType(BitmapHelper.DyeEnumType.面, "透明面", "DeTool_St_Face0", false);
            BitmapHelper.CreateStEnumType(BitmapHelper.DyeEnumType.体, "透明体", "DeTool_St_Body0", false);
            BitmapHelper.CreateStEnumType(BitmapHelper.DyeEnumType.面, "透明面", "DeTool_St_Face1", true);
            BitmapHelper.CreateStEnumType(BitmapHelper.DyeEnumType.体, "透明体", "DeTool_St_Body1", true);
        }
    }
}
