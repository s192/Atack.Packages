using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;

namespace AStack.BarCodeCreator
{
    internal class BarCode
    {
        public static void Create(string text, string fileName)
        {
            var code = new Code128();
            code.ValueFont = new Font("宋体", 12f);
            var codeImage = code.GetCodeImage(text, Code128.Encode.Code128B);
            codeImage.Save(fileName, ImageFormat.Jpeg);
        }

        private class Code128
        {
            public enum Encode
            {
                Code128A,
                Code128B,
                Code128C,
                EAN128
            }

            private DataTable m_Code128 = new DataTable();

            private uint m_Height = 40u;

            private Font m_ValueFont;

            private byte m_Magnify;

            public uint Height
            {
                get
                {
                    return m_Height;
                }
                set
                {
                    m_Height = value;
                }
            }

            public Font ValueFont
            {
                get
                {
                    return m_ValueFont;
                }
                set
                {
                    m_ValueFont = value;
                }
            }

            public byte Magnify
            {
                get
                {
                    return m_Magnify;
                }
                set
                {
                    m_Magnify = value;
                }
            }

            public Code128()
            {
                m_Code128.Columns.Add("ID");
                m_Code128.Columns.Add("Code128A");
                m_Code128.Columns.Add("Code128B");
                m_Code128.Columns.Add("Code128C");
                m_Code128.Columns.Add("BandCode");
                m_Code128.CaseSensitive = true;
                m_Code128.Rows.Add("0", " ", " ", "00", "212222");
                m_Code128.Rows.Add("1", "!", "!", "01", "222122");
                m_Code128.Rows.Add("2", "“", "“", "02", "222221");
                m_Code128.Rows.Add("3", "#", "#", "03", "121223");
                m_Code128.Rows.Add("4", "$", "$", "04", "121322");
                m_Code128.Rows.Add("5", "%", "%", "05", "131222");
                m_Code128.Rows.Add("6", "&", "&", "06", "122213");
                m_Code128.Rows.Add("7", "'", "'", "07", "122312");
                m_Code128.Rows.Add("8", "(", "(", "08", "132212");
                m_Code128.Rows.Add("9", ")", ")", "09", "221213");
                m_Code128.Rows.Add("10", "*", "*", "10", "221312");
                m_Code128.Rows.Add("11", "+", "+", "11", "231212");
                m_Code128.Rows.Add("12", ",", ",", "12", "112232");
                m_Code128.Rows.Add("13", "-", "-", "13", "122132");
                m_Code128.Rows.Add("14", ".", ".", "14", "122231");
                m_Code128.Rows.Add("15", "/", "/", "15", "113222");
                m_Code128.Rows.Add("16", "0", "0", "16", "123122");
                m_Code128.Rows.Add("17", "1", "1", "17", "123221");
                m_Code128.Rows.Add("18", "2", "2", "18", "223211");
                m_Code128.Rows.Add("19", "3", "3", "19", "221132");
                m_Code128.Rows.Add("20", "4", "4", "20", "221231");
                m_Code128.Rows.Add("21", "5", "5", "21", "213212");
                m_Code128.Rows.Add("22", "6", "6", "22", "223112");
                m_Code128.Rows.Add("23", "7", "7", "23", "312131");
                m_Code128.Rows.Add("24", "8", "8", "24", "311222");
                m_Code128.Rows.Add("25", "9", "9", "25", "321122");
                m_Code128.Rows.Add("26", ":", ":", "26", "321221");
                m_Code128.Rows.Add("27", ";", ";", "27", "312212");
                m_Code128.Rows.Add("28", "<", "<", "28", "322112");
                m_Code128.Rows.Add("29", "=", "=", "29", "322211");
                m_Code128.Rows.Add("30", ">", ">", "30", "212123");
                m_Code128.Rows.Add("31", "?", "?", "31", "212321");
                m_Code128.Rows.Add("32", "@", "@", "32", "232121");
                m_Code128.Rows.Add("33", "A", "A", "33", "111323");
                m_Code128.Rows.Add("34", "B", "B", "34", "131123");
                m_Code128.Rows.Add("35", "C", "C", "35", "131321");
                m_Code128.Rows.Add("36", "D", "D", "36", "112313");
                m_Code128.Rows.Add("37", "E", "E", "37", "132113");
                m_Code128.Rows.Add("38", "F", "F", "38", "132311");
                m_Code128.Rows.Add("39", "G", "G", "39", "211313");
                m_Code128.Rows.Add("40", "H", "H", "40", "231113");
                m_Code128.Rows.Add("41", "I", "I", "41", "231311");
                m_Code128.Rows.Add("42", "J", "J", "42", "112133");
                m_Code128.Rows.Add("43", "K", "K", "43", "112331");
                m_Code128.Rows.Add("44", "L", "L", "44", "132131");
                m_Code128.Rows.Add("45", "M", "M", "45", "113123");
                m_Code128.Rows.Add("46", "N", "N", "46", "113321");
                m_Code128.Rows.Add("47", "O", "O", "47", "133121");
                m_Code128.Rows.Add("48", "P", "P", "48", "313121");
                m_Code128.Rows.Add("49", "Q", "Q", "49", "211331");
                m_Code128.Rows.Add("50", "R", "R", "50", "231131");
                m_Code128.Rows.Add("51", "S", "S", "51", "213113");
                m_Code128.Rows.Add("52", "T", "T", "52", "213311");
                m_Code128.Rows.Add("53", "U", "U", "53", "213131");
                m_Code128.Rows.Add("54", "V", "V", "54", "311123");
                m_Code128.Rows.Add("55", "W", "W", "55", "311321");
                m_Code128.Rows.Add("56", "X", "X", "56", "331121");
                m_Code128.Rows.Add("57", "Y", "Y", "57", "312113");
                m_Code128.Rows.Add("58", "Z", "Z", "58", "312311");
                m_Code128.Rows.Add("59", "[", "[", "59", "332111");
                m_Code128.Rows.Add("60", "\\", "\\", "60", "314111");
                m_Code128.Rows.Add("61", "]", "]", "61", "221411");
                m_Code128.Rows.Add("62", "^", "^", "62", "431111");
                m_Code128.Rows.Add("63", "_", "_", "63", "111224");
                m_Code128.Rows.Add("64", "NUL", "`", "64", "111422");
                m_Code128.Rows.Add("65", "SOH", "a", "65", "121124");
                m_Code128.Rows.Add("66", "STX", "b", "66", "121421");
                m_Code128.Rows.Add("67", "ETX", "c", "67", "141122");
                m_Code128.Rows.Add("68", "EOT", "d", "68", "141221");
                m_Code128.Rows.Add("69", "ENQ", "e", "69", "112214");
                m_Code128.Rows.Add("70", "ACK", "f", "70", "112412");
                m_Code128.Rows.Add("71", "BEL", "g", "71", "122114");
                m_Code128.Rows.Add("72", "BS", "h", "72", "122411");
                m_Code128.Rows.Add("73", "HT", "i", "73", "142112");
                m_Code128.Rows.Add("74", "LF", "j", "74", "142211");
                m_Code128.Rows.Add("75", "VT", "k", "75", "241211");
                m_Code128.Rows.Add("76", "FF", "l", "76", "221114");
                m_Code128.Rows.Add("77", "CR", "m", "77", "413111");
                m_Code128.Rows.Add("78", "SO", "n", "78", "241112");
                m_Code128.Rows.Add("79", "SI", "o", "79", "134111");
                m_Code128.Rows.Add("80", "DLE", "p", "80", "111242");
                m_Code128.Rows.Add("81", "DC1", "q", "81", "121142");
                m_Code128.Rows.Add("82", "DC2", "r", "82", "121241");
                m_Code128.Rows.Add("83", "DC3", "s", "83", "114212");
                m_Code128.Rows.Add("84", "DC4", "t", "84", "124112");
                m_Code128.Rows.Add("85", "NAK", "u", "85", "124211");
                m_Code128.Rows.Add("86", "SYN", "v", "86", "411212");
                m_Code128.Rows.Add("87", "ETB", "w", "87", "421112");
                m_Code128.Rows.Add("88", "CAN", "x", "88", "421211");
                m_Code128.Rows.Add("89", "EM", "y", "89", "212141");
                m_Code128.Rows.Add("90", "SUB", "z", "90", "214121");
                m_Code128.Rows.Add("91", "ESC", "{", "91", "412121");
                m_Code128.Rows.Add("92", "FS", "|", "92", "111143");
                m_Code128.Rows.Add("93", "GS", "}", "93", "111341");
                m_Code128.Rows.Add("94", "RS", "~", "94", "131141");
                m_Code128.Rows.Add("95", "US", "DEL", "95", "114113");
                m_Code128.Rows.Add("96", "FNC3", "FNC3", "96", "114311");
                m_Code128.Rows.Add("97", "FNC2", "FNC2", "97", "411113");
                m_Code128.Rows.Add("98", "SHIFT", "SHIFT", "98", "411311");
                m_Code128.Rows.Add("99", "CODEC", "CODEC", "99", "113141");
                m_Code128.Rows.Add("100", "CODEB", "FNC4", "CODEB", "114131");
                m_Code128.Rows.Add("101", "FNC4", "CODEA", "CODEA", "311141");
                m_Code128.Rows.Add("102", "FNC1", "FNC1", "FNC1", "411131");
                m_Code128.Rows.Add("103", "StartA", "StartA", "StartA", "211412");
                m_Code128.Rows.Add("104", "StartB", "StartB", "StartB", "211214");
                m_Code128.Rows.Add("105", "StartC", "StartC", "StartC", "211232");
                m_Code128.Rows.Add("106", "Stop", "Stop", "Stop", "2331112");
            }

            public Bitmap GetCodeImage(string p_Text, Encode p_Code)
            {
                string p_ViewText = p_Text;
                string text = "";
                IList<int> list = new List<int>();
                int num = 0;
                switch (p_Code)
                {
                    case Encode.Code128C:
                        num = 105;
                        if ((p_Text.Length & 1) != 0)
                        {
                            throw new Exception("128C长度必须是偶数");
                        }
                        while (p_Text.Length != 0)
                        {
                            int p_SetID3 = 0;
                            try
                            {
                                int.Parse(p_Text.Substring(0, 2));
                            }
                            catch
                            {
                                throw new Exception("128C必须是数字！");
                            }
                            text += GetValue(p_Code, p_Text.Substring(0, 2), ref p_SetID3);
                            list.Add(p_SetID3);
                            p_Text = p_Text.Remove(0, 2);
                        }
                        break;
                    case Encode.EAN128:
                        num = 105;
                        if ((p_Text.Length & 1) != 0)
                        {
                            throw new Exception("EAN128长度必须是偶数");
                        }
                        list.Add(102);
                        text += "411131";
                        while (p_Text.Length != 0)
                        {
                            int p_SetID2 = 0;
                            try
                            {
                                int.Parse(p_Text.Substring(0, 2));
                            }
                            catch
                            {
                                throw new Exception("128C必须是数字！");
                            }
                            text += GetValue(Encode.Code128C, p_Text.Substring(0, 2), ref p_SetID2);
                            list.Add(p_SetID2);
                            p_Text = p_Text.Remove(0, 2);
                        }
                        break;
                    case Encode.Code128A:
                        num = 103;
                        goto IL_017c;
                    default:
                        {
                            num = 104;
                            goto IL_017c;
                        }
                    IL_017c:
                        while (p_Text.Length != 0)
                        {
                            int p_SetID = 0;
                            string value = GetValue(p_Code, p_Text.Substring(0, 1), ref p_SetID);
                            if (value.Length == 0)
                            {
                                throw new Exception("无效的字符集!" + p_Text.Substring(0, 1).ToString());
                            }
                            text += value;
                            list.Add(p_SetID);
                            p_Text = p_Text.Remove(0, 1);
                        }
                        break;
                }
                if (list.Count == 0)
                {
                    throw new Exception("错误的编码,无数据");
                }
                text = text.Insert(0, GetValue(num));
                for (int i = 0; i != list.Count; i++)
                {
                    num += list[i] * (i + 1);
                }
                num %= 103;
                text += GetValue(num);
                text += "2331112";
                Bitmap image = GetImage(text);
                GetViewText(image, p_ViewText);
                return image;
            }

            private string GetValue(Encode p_Code, string p_Value, ref int p_SetID)
            {
                if (m_Code128 == null)
                {
                    return "";
                }
                DataRow[] array = m_Code128.Select(p_Code.ToString() + "='" + p_Value + "'");
                if (array.Length != 1)
                {
                    throw new Exception("错误的编码" + p_Value.ToString());
                }
                p_SetID = int.Parse(array[0]["ID"].ToString());
                return array[0]["BandCode"].ToString();
            }

            private string GetValue(int p_CodeId)
            {
                DataRow[] array = m_Code128.Select("ID= '" + p_CodeId.ToString() + "'");
                if (array.Length != 1)
                {
                    throw new Exception("验效位的编码错误" + p_CodeId.ToString());
                }
                return array[0]["BandCode"].ToString();
            }

            private Bitmap GetImage(string p_Text)
            {
                char[] array = p_Text.ToCharArray();
                int num = 0;
                for (int i = 0; i != array.Length; i++)
                {
                    num += int.Parse(array[i].ToString()) * (m_Magnify + 1);
                }
                Bitmap bitmap = new Bitmap(num, (int)m_Height);
                Graphics graphics = Graphics.FromImage(bitmap);
                int num2 = 0;
                for (int j = 0; j != array.Length; j++)
                {
                    int num3 = int.Parse(array[j].ToString()) * (m_Magnify + 1);
                    if ((j & 1) != 0)
                    {
                        graphics.FillRectangle(Brushes.White, new Rectangle(num2, 0, num3, (int)m_Height));
                    }
                    else
                    {
                        graphics.FillRectangle(Brushes.Black, new Rectangle(num2, 0, num3, (int)m_Height));
                    }
                    num2 += num3;
                }
                graphics.Dispose();
                return bitmap;
            }

            private void GetViewText(Bitmap p_Bitmap, string p_ViewText)
            {
                if (m_ValueFont != null)
                {
                    Graphics graphics = Graphics.FromImage(p_Bitmap);
                    SizeF sizeF = graphics.MeasureString(p_ViewText, m_ValueFont);
                    if (sizeF.Height > p_Bitmap.Height - 10 || sizeF.Width > p_Bitmap.Width)
                    {
                        graphics.Dispose();
                        return;
                    }
                    int y = p_Bitmap.Height - (int)sizeF.Height;
                    graphics.FillRectangle(Brushes.White, new Rectangle(0, y, p_Bitmap.Width, (int)sizeF.Height));
                    graphics.DrawString(p_ViewText, m_ValueFont, Brushes.Black, new Rectangle((p_Bitmap.Width - (int)sizeF.Width) / 2, y, p_Bitmap.Width, (int)sizeF.Height));
                }
            }

            internal Image GetCodeImage(string p)
            {
                throw new NotImplementedException();
            }
        }
    }
}