using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud
{
    public class POListView
    {
        public int PONo { set; get; }
        public string PONumber { set; get; }
        public string POOriginalNumber { set; get; }
        public string VENDOR_NO { set; get; }
        public DateTime PODate { set; get; }
        public string Status { set; get; }
        public decimal PaymentDue {set;get;}
        public string Note { set; get; }
        public string SONumber { set; get; }
    }
}