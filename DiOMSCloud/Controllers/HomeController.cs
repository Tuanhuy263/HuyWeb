using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DiOMSRepositoryEntity;
using DiOMSEntity;
using System.Threading.Tasks;

namespace DiOMSCloud.Controllers
{
    public class HomeController : Controller
    {
        private UnitOfWork _unit = new UnitOfWork();
        public async Task<ActionResult> Index()
        {
            //throw new Exception("ok");
            //GenericRepository<DIS_SOHeader> rep = _unit.GeneralRepository<DIS_SOHeader>();
            //List<DIS_SOHeader> lst = rep.GetQuery.Where(x => x.SOOriginalNumber.Contains("address")).ToList();
            return View();
        }

        public ActionResult About()
        {
            //GenericRepository<DIS_SOHeader> rep = _unit.GeneralRepository<DIS_SOHeader>();
            //DIS_SOHeader obj = rep.GetDat(x => x.SOOriginalNumber.Contains("address"));

            //ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}