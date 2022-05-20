using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud
{
    public class SOListView
    {
        public int SONo { set; get; }
        public string SONumber { set; get; }
        public string SOOriginalNumber { set; get; }
        public string HubCode { set; get; }
        public DateTime SODate { set; get; }
        public string Status { set; get; }
        public bool HasASN { set; get; }
        public bool HasPO { set; get; }
        public decimal PaymentDue { set; get; }
        public string Note { set; get; }
        public string BOLNo { set; get; }
    }
}