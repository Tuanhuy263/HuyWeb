using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DiOMSCloud
{
    public class SecurityModel
    {
        [Required(AllowEmptyStrings =false,ErrorMessage ="Please enter User Name")]
        [MaxLength(20,ErrorMessage ="Length exceeds limit")]
        public string UserName { set; get; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Password")]
        [MaxLength(50, ErrorMessage = "Length exceeds limit")]
        public string Password { set; get; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please enter Captcha Letters")]
        [MaxLength(5, ErrorMessage = "Length exceeds limit")]
        public string CapchaLetters { set; get; }
    }
}