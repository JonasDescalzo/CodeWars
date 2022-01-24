using System;
using System.Collections.Generic;
using System.DrawingCore;
using System.DrawingCore.Imaging;
using System.IO;
using System.Text;
using ZXing;
using ZXing.Common;

namespace DR.Framework.Common
{
    public class QRHelper
    {
        /// <summary>
        /// 得到需要生成的二维码的base64
        /// </summary>
        /// <param name="codeNumber">二维码内容</param>
        /// <param name="size"></param>
        /// <returns></returns>
        public static string GetQRBase64(string codeNumber, int size)
        {
            var result = "";
            BitMatrix byteMatrix = new MultiFormatWriter().encode(codeNumber, BarcodeFormat.QR_CODE, size, size);
            var bitmap = toBitmap(byteMatrix);

            System.IO.MemoryStream ms = new MemoryStream();
            bitmap.Save(ms, ImageFormat.Png);
            byte[] byteImage = ms.ToArray();
            result = Convert.ToBase64String(byteImage); // Get Base64

            return result;
        }

        /// <summary>
        /// 二维码
        /// </summary>
        /// <param name="matrix"></param>
        /// <returns></returns>
        public static Bitmap toBitmap(BitMatrix matrix)
        {
            int width = matrix.Width;
            int height = matrix.Height;
            var white = ColorTranslator.FromHtml("#FFFFFF");
            var black = ColorTranslator.FromHtml("#FF0000");
            Bitmap bmap = new Bitmap(width, height, System.DrawingCore.Imaging.PixelFormat.Format32bppArgb);
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    bmap.SetPixel(x, y, matrix[x, y] ? black : white);
                }
            }
            return bmap;
        }
    }
}
