using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiOMSCloud
{
    public class ItemView
    {
        public string ERPItemCode { set; get; }
        public string Category { set; get; }
        public string GlobalStyle { set; get; }
        public string Description { set; get; }
        public byte ItemType { set; get; }
    }
}