using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud
{
    public class SODetailView
    {
        public string ERPItemCode { set; get; }
        public string Description { set; get; }
        public decimal Quantity { set; get; }
        public decimal UnitPrice { set; get; }
        public string UnitOfMeasureCode { set; get; }
        public int SONo { set; get; }
        public decimal Amount { set; get; }
    }
}