using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiOMSCloud.Filters
{
    public class CustomizedError : HandleErrorAttribute
    {
        //private static log4net.ILog logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public override void OnException(ExceptionContext filterContext)
        {
            Exception e = filterContext.Exception;
            filterContext.ExceptionHandled = true;
            filterContext.Result = new ViewResult()
            {
                ViewName = "Error"
            };
            Log.Error("controller:" + filterContext.RouteData.Values["controller"] + "-action:" + filterContext.RouteData.Values["action"],e);
            //logger.Error("controller:" + filterContext.RouteData.Values["controller"] + "-action:" + filterContext.RouteData.Values["action"]);
        }
    }
}