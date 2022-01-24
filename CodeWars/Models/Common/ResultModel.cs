using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeWars.Models.Common
{
    public class ResultModel
    {
        /// <summary>
        /// 200 success
        /// </summary>
        public int StatusCode { get; set; }

        /// <summary>
        /// returned messages
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Number of data rows
        /// </summary>
        public int DataCount { get; set; }

        /// <summary>
        /// Return data
        /// </summary>
        public object Data { get; set; }
    }
}
