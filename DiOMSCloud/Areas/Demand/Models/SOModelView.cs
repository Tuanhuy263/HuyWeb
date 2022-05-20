﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiOMSCloud.Areas.Demand.Models
{
    public class SOModelView
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please fill Note")]
        [MaxLength(200, ErrorMessage ="Exceed maximum length")]
        public string Note { set; get; }
        public string SONumber { set; get; }
    }
}