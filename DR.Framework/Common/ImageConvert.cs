using System;
using System.Collections.Generic;
using System.DrawingCore;
using System.DrawingCore.Imaging;
using System.IO;
using System.Text;

namespace DR.Framework.Common
{
    public static class ImageConvert
    {

        /// <summary>
        /// 判断图片大小
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        public static bool CheckImageSize(string base64String)
        {
            return base64String.Length <= 1024 * 1024 * 2;
        }

        /// <summary>
        /// 将base64字符串转换成图片
        /// </summary>
        /// <param name="base64String"></param>
        /// <returns></returns>
        public static Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);

            ms.Write(imageBytes, 0, imageBytes.Length);
            return Image.FromStream(ms, true);
        }

        /// <summary>
        /// 获取Image图片格式
        /// </summary>
        /// <param name="img">图片</param>
        /// <returns></returns>
        public static (string extensioName, ImageFormat formatType) GetImageFormat(Image img)
        {
            //if (img.RawFormat.Equals(ImageFormat.Jpeg))
            //{
            //    return ("Jpeg", ImageFormat.Jpeg);
            //}
            //if (img.RawFormat.Equals(ImageFormat.Gif))
            //{
            //    return ("gif", ImageFormat.Gif);
            //}
            //if (img.RawFormat.Equals(ImageFormat.Png))
            //{
            return ("png", ImageFormat.Png);
            //}
            //if (img.RawFormat.Equals(ImageFormat.Bmp))
            //{
            //    return ("Bmp", ImageFormat.Bmp);
            //}
            // return (null, null);
        }
    }
}
