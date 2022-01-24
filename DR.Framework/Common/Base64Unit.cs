using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Framework.Common
{
    public class Base64Unit
    {
        /// <summary>
        /// base64 解码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string UnBase64String(string value)
        {
            if (value == null || value == "")
            {
                return "";
            }
            byte[] bytes = Convert.FromBase64String(value);
            return Encoding.UTF8.GetString(bytes);
        }

        /// <summary>
        /// base64编码
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string ToBase64String(string value)
        {
            if (value == null || value == "")
            {
                return "";
            }
            byte[] bytes = Encoding.UTF8.GetBytes(value);
            return Convert.ToBase64String(bytes);
        }

    }
}
