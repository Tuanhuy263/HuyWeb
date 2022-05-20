using System.Web.Mvc;

namespace DiOMSCloud.Areas.Demand
{
    public class DemandAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Demand";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Demand_default",
                "Demand/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}