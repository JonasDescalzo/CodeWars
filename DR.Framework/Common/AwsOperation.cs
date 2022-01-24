using DR.Framework.Config;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace DR.Framework.Common
{
    public class UploadImageModel
    {
        /// <summary>
        /// 图片base64
        /// </summary>
        public string ImageBase64 { get; set; }

        /// <summary>
        /// key 同样是路径
        /// </summary>
        public string Key { get; set; }
    }

    public class AwsOperation
    {
        private static HttpClient client = new HttpClient();

        /// <summary>
        /// 上传文件
        /// </summary>
        /// <param name="dic"></param>
        /// <returns></returns>
        public bool FileUpload(Dictionary<string, string> dic)
        {

            foreach (var item in dic)
            {
                var upload = new UploadImageModel();
                upload.Key = item.Key;
                upload.ImageBase64 = item.Value;

                var url = ConfigModel._configuration["UploadImageAddress"];

                string requestDTO = Newtonsoft.Json.JsonConvert.SerializeObject(upload);
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(requestDTO));
                HttpContent hc = new StreamContent(ms);
                hc.Headers.Add("agent", "U88");
                hc.Headers.Add("Content-Type", "application/json;charset=utf-8");
                var t = client.PostAsync(url, hc);
                t.Wait();
                var t2 = t.Result.Content.ReadAsByteArrayAsync();

                Encoding.UTF8.GetString(t2.Result);

            }

            return true;

        }
    }
}
