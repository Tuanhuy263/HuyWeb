using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud.Areas.Demand.Models
{
    public class SOCriteria
    {
        public string SOOriginalNo { set; get; }
        public string EDISONo { set; get; }
        public string HubID { set; get; }
        public DateTime? FromSODate{set;get;}
        public DateTime? ToSODate { set; get; }
        public string Status { set; get; }
    }
}