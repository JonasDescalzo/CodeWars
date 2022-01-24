using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;

namespace DR.Framework.Http
{
    public class DRHttpClient
    {
        #region 对象

        private readonly IHttpClientFactory _httpClient;
        private readonly IHttpContextAccessor _contextAccessor;

        #endregion

        #region 构造函数

        public DRHttpClient(IHttpClientFactory httpClient
                           , IHttpContextAccessor contextAccessor)
        {
            this._httpClient = httpClient;
            this._contextAccessor = contextAccessor;
        }

        #endregion

        #region HUB88 异步封装
        /// <summary>
        /// POST 同步
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonParas"></param>
        /// <param name="encoding"></param>
        /// <param name="timeOut"></param>
        /// <param name="StatusCode"></param>
        /// <returns></returns>
        public string HttpHUB88Post(string url, string sign, object jsonParas = null, Encoding encoding = null, int timeOut = 10000)
        {
            var client = _httpClient.CreateClient();
            string requestDTO = JsonConvert.SerializeObject(jsonParas);
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(requestDTO));
            HttpContent hc = new StreamContent(ms);
            hc.Headers.Add("X-Hub88-Signature", sign);
            hc.Headers.Add("Content-Type", "application/json;charset=utf-8");
            var t = client.PostAsync(url, hc);
            t.Wait();
            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            if (t2.Result.Length == 0)
            {
                return "";
            }
            else
            {
                return encoding.GetString(t2.Result);
            }

        }


        #endregion

        #region cashfree withdrawl异步封装

        /// <summary>
        /// POST 同步
        /// </summary>
        /// <returns></returns>
        public string HttpCashfreeTokenPost(string url, string appid, string appSecret, string paras = null, Encoding encoding = null, int timeOut = 10000)
        {

            var client = _httpClient.CreateClient();
            //string requestDTO = JsonHelper.SerializeObject(jsonParas);
            client.DefaultRequestHeaders.Add("X-Client-Id", appid);
            client.DefaultRequestHeaders.Add("X-Client-Secret", appSecret);
            var forms = System.Web.HttpUtility.ParseQueryString(paras);
            var t = client.PostAsync(url, new StringContent(paras.ToString(), UTF8Encoding.UTF8, "application/x-www-form-urlencoded"));
            t.Wait();
            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            return encoding.GetString(t2.Result);
        }

        /// <summary>
        /// POST 同步
        /// </summary>
        /// <returns></returns>
        public string HttpCashfreePost(string url, string token, object jsonParas = null, Encoding encoding = null, int timeOut = 10000)
        {

            var client = _httpClient.CreateClient();
            string requestDTO = JsonConvert.SerializeObject(jsonParas);
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(requestDTO));
            HttpContent hc = new StreamContent(ms);
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            hc.Headers.Add("Content-Type", "application/json;charset=utf-8");
            var t = client.PostAsync(url, hc);
            t.Wait();
            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            if (t2.Result.Length == 0)
            {
                return "";
            }
            else
            {
                return encoding.GetString(t2.Result);
            }

        }

        /// <summary>
        /// Http Get 同步方法
        /// </summary>
        /// <param name="url"></param>
        /// <param name="encoding"></param>
        /// <returns></returns>
        public string HttpCashfreeGet(string url, string token, Encoding encoding = null)
        {
            var client = _httpClient.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);
            var t = client.GetByteArrayAsync(url);
            t.Wait();
            var ret = encoding.GetString(t.Result);
            return ret;

        }
        #endregion

        #region SW

        public string HttpSWPost(string url, string accessToken, object jsonParas = null, Encoding encoding = null, int timeOut = 10000)
        {
            var client = _httpClient.CreateClient();
            string requestDTO = JsonConvert.SerializeObject(jsonParas);

            //使用获取签名

            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(requestDTO));
            HttpContent hc = new StreamContent(ms);
            hc.Headers.Add("Content-Type", "application/json;charset=utf-8");
            hc.Headers.Add("X-ACCESS-TOKEN", accessToken);
            var t = client.PostAsync(url, hc);
            t.Wait();
            var t2 = t.Result.Content.ReadAsByteArrayAsync();

            return encoding.GetString(t2.Result);
        }

        public string HttpSWGet(string url, string accessToken, Encoding encoding = null, int timeOut = 10000)
        {


            var client = _httpClient.CreateClient();

            client.DefaultRequestHeaders.Add("X-ACCESS-TOKEN", accessToken);

            var t = client.GetAsync(url);
            t.Wait();

            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            client.Dispose();
            return encoding.GetString(t2.Result);
        }


        #endregion

        #region PTNew

        public string HttpPTNewGet(string url, string accessToken, Encoding encoding = null, int timeOut = 10000)
        {

            var client = _httpClient.CreateClient();

            client.DefaultRequestHeaders.Add("X-Auth-Api-Key", accessToken);

            var t = client.GetAsync(url);
            t.Wait();

            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            client.Dispose();
            return encoding.GetString(t2.Result);
        }

        #endregion

        #region FYDJ Post

        /// <summary>
        /// POST 同步
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paras"></param>
        /// <param name="encoding"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public string HttpFYDJPost(string url, string paras = null, string key = "", Encoding encoding = null, int timeOut = 10000)
        {
            var client = _httpClient.CreateClient();
            //string requestDTO = JsonHelper.SerializeObject(jsonParas);
            var forms = System.Web.HttpUtility.ParseQueryString(paras);
            client.DefaultRequestHeaders.Add("Authorization", key);
            var t = client.PostAsync(url, new StringContent(paras.ToString(), UTF8Encoding.UTF8, "application/x-www-form-urlencoded"));
            t.Wait();
            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            return encoding.GetString(t2.Result);
        }


        #endregion

        #region MG4

        /// <summary>
        /// POST 同步
        /// </summary>
        /// <param name="url"></param>
        /// <param name="accessToken"></param>
        /// <param name="param"></param>
        /// <param name="encoding"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public string HttpMG4AuthPost(string url, string accessToken, string param = "", Encoding encoding = null, int timeOut = 10000)
        {


            var client = _httpClient.CreateClient();

            var content = new StringContent(param, Encoding.UTF8, "application/x-www-form-urlencoded");

            client.DefaultRequestHeaders.Add("Authorization", accessToken);
            client.DefaultRequestHeaders.Add("X-DAS-TZ", "UTC+8");
            client.DefaultRequestHeaders.Add("X-DAS-CURRENCY", "CNY");
            client.DefaultRequestHeaders.Add("X-DAS-LANG", "zh-CN");
            client.DefaultRequestHeaders.Add("X-DAS-TX-ID", "1");


            var t = client.PostAsync(url, content);
            t.Wait();

            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            client.Dispose();
            return encoding.GetString(t2.Result);
        }

        /// <summary>
        /// POST 同步
        /// </summary>
        /// <param name="url"></param>
        /// <param name="accessToken"></param>
        /// <param name="encoding"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public string HttpMG4Get(string url, string accessToken, Encoding encoding = null, int timeOut = 10000)
        {


            var client = _httpClient.CreateClient();
            client.DefaultRequestHeaders.Add("Authorization", "Bearer " + accessToken);
            client.DefaultRequestHeaders.Add("X-DAS-TZ", "UTC+8");
            client.DefaultRequestHeaders.Add("X-DAS-CURRENCY", "CNY");
            client.DefaultRequestHeaders.Add("X-DAS-LANG", "zh-CN");
            client.DefaultRequestHeaders.Add("X-DAS-TX-ID", "1");


            var t = client.GetAsync(url);
            t.Wait();

            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            client.Dispose();
            return encoding.GetString(t2.Result);
        }

        #endregion

        #region 外部传入通用Http

        /// <summary>
        /// DR通用HttpPost
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonParas"></param>
        /// <returns></returns>
        public string HttpSJPost(string url, object jsonParas = null)
        {
            var client = _httpClient.CreateClient();
            string requestDTO = JsonConvert.SerializeObject(jsonParas);
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(requestDTO));
            HttpContent hc = new StreamContent(ms);

            var xfor = _contextAccessor.HttpContext.Request.Headers["X-Forwarded-For"].ToString();

            var useragent = "";

            if (string.IsNullOrEmpty(_contextAccessor.HttpContext.Request.Headers["HTTP_USER_AGENT"]))
            {
                useragent = _contextAccessor.HttpContext.Request.Headers["HTTP_USER_AGENT"].ToString();
            }

            if (string.IsNullOrEmpty(_contextAccessor.HttpContext.Request.Headers["AI-USER-AGENT"]))
            {
                useragent = _contextAccessor.HttpContext.Request.Headers["AI-USER-AGENT"].ToString();
            }

            var firstFor = xfor.Split(',')[0].Trim();

            hc.Headers.Add("X-Real-IP", firstFor);
            hc.Headers.Add("srdomain", _contextAccessor.HttpContext.Request.Headers["srdomain"].ToString());
            hc.Headers.Add("zhandian", _contextAccessor.HttpContext.Request.Headers["zhandian"].ToString());
            hc.Headers.Add("FrHost", _contextAccessor.HttpContext.Request.Headers["Host"].ToString());
            hc.Headers.Add("agent", "U88");
            hc.Headers.Add("token", _contextAccessor.HttpContext.Request.Headers["token"].ToString());
            hc.Headers.Add("LANGUAGE", _contextAccessor.HttpContext.Request.Headers["LANGUAGE"].ToString());
            hc.Headers.Add("HTTP-USER-AGENT", _contextAccessor.HttpContext.Request.Headers["HTTP_USER_AGENT"].ToString());
            hc.Headers.Add("Content-Type", "application/json;charset=utf-8");
            var t = client.PostAsync(url, hc);
            t.Wait();
            var t2 = t.Result.Content.ReadAsByteArrayAsync();

            return Encoding.UTF8.GetString(t2.Result);

        }

        #endregion

        #region 普通httpGet

        /// <summary>
        /// Httpget
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonParas"></param>
        /// <returns></returns>
        public string HttpGet(string url, object jsonParas = null)
        {
            var client = _httpClient.CreateClient();
            var t = client.GetByteArrayAsync(url);
            t.Wait();
            var ret = Encoding.UTF8.GetString(t.Result);
            return ret;

        }

        #endregion

        #region http同步

        /// <summary>
        /// POST 同步
        /// </summary>
        /// <param name="url"></param>
        /// <param name="jsonParas"></param>
        /// <param name="encoding"></param>
        /// <param name="timeOut"></param>
        /// <param name="StatusCode"></param>
        /// <returns></returns>
        public string HttpPost(string url, object jsonParas = null, Encoding encoding = null, int timeOut = 10000)
        {
            var client = _httpClient.CreateClient();
            string requestDTO = Newtonsoft.Json.JsonConvert.SerializeObject(jsonParas);
            MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(requestDTO));
            HttpContent hc = new StreamContent(ms);
            hc.Headers.Add("agent", "U88");
            hc.Headers.Add("Content-Type", "application/json;charset=utf-8");
            var t = client.PostAsync(url, hc);
            t.Wait();
            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            if (t2.Result.Length == 0)
            {
                return "";
            }
            else
            {
                return encoding.GetString(t2.Result);
            }


        }

        #endregion

        #region PP BBIN异步封装

        /// <summary>
        /// POST 同步
        /// </summary>
        /// <param name="url"></param>
        /// <param name="paras"></param>
        /// <param name="encoding"></param>
        /// <param name="timeOut"></param>
        /// <returns></returns>
        public string HttpPPPost(string url, string paras = null, Encoding encoding = null, int timeOut = 10000)
        {


            var client = _httpClient.CreateClient();
            //string requestDTO = JsonHelper.SerializeObject(jsonParas);
            var forms = System.Web.HttpUtility.ParseQueryString(paras);
            var t = client.PostAsync(url, new StringContent(paras.ToString(), UTF8Encoding.UTF8, "application/x-www-form-urlencoded"));
            t.Wait();
            var t2 = t.Result.Content.ReadAsByteArrayAsync();
            return encoding.GetString(t2.Result);
        }

        #endregion


    }
}
