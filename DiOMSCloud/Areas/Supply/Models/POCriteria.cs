using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud.Areas.Supply.Models
{
    public class POCriteria
    {
        public string PONumber { set; get; }
        public string POOriginalNo { set; get; }
        public string VendorNo { set; get; }
        public DateTime? FromPODate{set;get;}
        public DateTime? ToPODate { set; get; }
        public string Status { set; get; }
    }
}