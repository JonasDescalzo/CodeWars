
using System;
using System.Collections.Generic;
using System.Text;

namespace DR.Data.Elasticserch.Domain
{
    public class UserOperatingLogModel
    {
        public string Id { get; set; }
        public string UserName { get; set; }

        public long CreateTime { get; set; }

        public long UpdateTime { get; set; }

        public int Dateymd { get; set; }

        public string Ip { get; set; }

        public string Type { get; set; }

        public string NetWork { get; set; }

        /// <summary>
        /// mac address
        /// </summary>
        public string Mac { get; set; }

        /// <summary>
        /// android ios windows
        /// </summary>
        public string Device { get; set; }

        /// <summary>
        /// app web
        /// </summary>
        public string MachineType { get; set; }

        public string AppVersion { get; set; }

        public string UserAgent { get; set; }

        public string Country { get; set; }

        public string Province { get; set; }

        public string City { get; set; }
        public string Cid { get; set; }
    }
}
