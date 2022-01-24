using RestSharp;
using Serilog;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace DR.Framework.Http
{
    public class NetWorkHelper
    {


        /// <summary>
        /// 获取类型
        /// </summary>
        /// <param name="userAgent"></param>
        /// <returns></returns>
        public static string GetIntOSVersion(string userAgent)
        {
            try
            {
                string osVersion = "Other";

                if (string.IsNullOrEmpty(userAgent))
                {
                    userAgent = "";
                }

                if (userAgent.Contains("Mac"))
                {
                    if (userAgent.Contains("iPhone")) { osVersion = "IOS"; }
                    else { osVersion = "MACOS"; }

                }
                else if (userAgent.Contains("Unix"))
                {
                    osVersion = "Linux";
                }
                else if (userAgent.Contains("Linux"))
                {
                    if (userAgent.Contains("Android"))
                    {
                        osVersion = "Android";
                    }
                    else
                    { osVersion = "Linux"; }
                }
                else if (userAgent.Contains("SunOS"))
                {
                    osVersion = "IOS";
                }//

                else if (userAgent.Contains("NT 10.0"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("NT 6.1"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("NT 6.0"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("NT 5.2"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("NT 5.1"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("NT 5"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("NT 4"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("Me"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("98"))
                {
                    osVersion = "Windows";
                }
                else if (userAgent.Contains("95"))
                {
                    osVersion = "Windows";
                }
                return osVersion;
            }
            catch (Exception)
            {

                return "Other";
            }

        }

        /// <summary>
        /// 获取IP地理位置
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public static IPGeoLocationModel GetIPGeoLocation(string ip)
        {
            try
            {

                IPGeoLocationModel location = new IPGeoLocationModel()
                {
                    Country = "",
                    Province = "",
                    City = "",
                    IP = ip,
                    ISP = "",
                    Address = ""
                };

                var url = $"http://ip-api.com/json/{ip}";

                //var postData = "";

                try
                {
                    //range limit
                    var client = new RestClient(url);
                    client.Timeout = 300;
                    var request = new RestRequest(Method.GET);
                    IRestResponse response = client.Execute(request);
                    var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<IPAPI>(response.Content);
                    if (obj.status == "success")
                    {
                        location.Country = obj.country;
                        location.City = obj.city;
                        location.ISP = obj.isp;
                        location.IP = ip;
                        location.Province = obj.regionName;
                    }

                }
                catch (Exception ex)
                {
                    Log.Error(ex, "ip-api.com timeout ");
                }

                return location;
            }
            catch (Exception)
            {

                return null;

            }

        }
    }
}
