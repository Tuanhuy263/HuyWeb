using DiOMSCloud.Areas.Demand.Models;
using DiOMSCloud.Filters;
using DiOMSEntity;
using DiOMSRepositoryEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using PagedList;
using System.Dynamic;


namespace DiOMSCloud.Areas.Demand.Controllers
{
    public class SOController : Controller
    {
        private IUnitOfWork _unit;

        public SOController(IUnitOfWork unit)
        {
            _unit = unit;
            
        }


        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            Dictionary<string, string> dics = HttpContext.Application["Dictionary"] as Dictionary<string, string>;
            foreach (var val in dics)
            {
                ViewData[val.Key] = val.Value;
            }
            return base.BeginExecuteCore(callback, state);
        }

        // GET: Demand/SO
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public ActionResult Index()
        {
            #region load static data
            SOCriteria cr = new SOCriteria();
            #region load hub
            GenericRepository<DIS_Hub> hubCtr = _unit.GeneralRepository<DIS_Hub>();
            SelectListItem item = new SelectListItem() { Text = "All", Value = "", Selected = true };
            List<SelectListItem> colls = hubCtr.GetAll().Select(x =>
            {
                SelectListItem obj = new SelectListItem() { Text = x.HubName, Value = x.HubCode };
                return obj;
            }).ToList();
            colls.Insert(0, item);
            ViewBag.Hubs = colls;
            #endregion

            #region load status
            string[] sts = Enum.GetNames(typeof(Enums.SOStatus));
            Enums.SOStatus val;
            List<SelectListItem> sts_coll = new List<SelectListItem>();
            foreach (var status in sts)
            {
                Enum.TryParse(status,out val);
                SelectListItem obj = new SelectListItem() {Text = status, Value = ((byte)val).ToString()};
                sts_coll.Add(obj);
            }
            ViewBag.Status = sts_coll;
            #endregion

            ViewBag.ViewID = "SOList";
            #endregion
            return View(cr);
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        public ActionResult ListSO(int? page, SOCriteria obj)
        {
            ViewBag.ViewID = "SOHeaderList";
            int pageSize = 5;
            int pageIndex = 1;
            IPagedList<SOListView> pagingLst = null;
            List<SOListView> vw = null;
            if (page.HasValue)
            {
                pageIndex = Convert.ToInt32(page);
                vw = Session["SOList"] as List<SOListView>;
            }
            else
            {
                pageIndex =  1;
                GenericRepository<DIS_SOHeader> rep = _unit.GeneralRepository<DIS_SOHeader>();
                List<DIS_SOHeader> lst = rep.Include(x => x.DIS_ASNSO).Where(x => (string.IsNullOrEmpty(obj.EDISONo) || x.EDISONumber.Contains(obj.EDISONo))).Where(x => string.IsNullOrEmpty(obj.SOOriginalNo) || x.SOOriginalNumber.Contains(obj.SOOriginalNo))
                            .Where(x => string.IsNullOrEmpty(obj.HubID) || x.DIS_Hub.HubCode.Equals(obj.HubID))
                            .Where(x => obj.FromSODate == null || x.SODate >= obj.FromSODate)
                            .Where(x => obj.ToSODate == null || x.SODate <= obj.ToSODate)
                            .Where(x => string.IsNullOrEmpty(obj.Status) || obj.Status.Contains(x.Status.ToString()))
                            .ToList();
                if (lst.Count > 0)
                {
                    vw = Mapping.AutoMapping.Map<List<SOListView>>(lst);
                    Session["SOList"] = vw;
                    
                }
            }

            if(vw != null)
            {
                pagingLst = vw.ToPagedList<SOListView>(pageIndex, pageSize);
                return PartialView("DisplaySOHeaders", pagingLst);
            }
            
            return new EmptyResult();
        }





        // GET: Demand/SO/Details/5
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            GenericRepository<DIS_SOHeader> rep = _unit.GeneralRepository<DIS_SOHeader>();
            DIS_SOHeader obj = await rep.FindObject(id);
            List<SODetailView> lst = Mapping.AutoMapping.Map<List<SODetailView>>(obj.DIS_SODetail);
            return PartialView("DisplaySODetails", lst);
        }

        // GET: Demand/SO/Create
        [HttpPost]
        public ActionResult Create1(int[] arr, SOCriteria objj)
        {
            //return View();
            GenericRepository<DIS_SOHeader> rep = _unit.GeneralRepository<DIS_SOHeader>();
            List<DIS_SOHeader> lst = rep.GetAll();
            SOModelView obj = Mapping.AutoMapping.Map<SOModelView>(lst[0]);
            return Json(obj, JsonRequestBehavior.AllowGet);
        }

        // POST: Demand/SO/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Demand/SO/Edit/5
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {
            //GenericRepository<DIS_SOHeader> rep = _unit.GeneralRepository<DIS_SOHeader>();
            //string[] ids = id.Split(new string[] {"," }, StringSplitOptions.None);
            //DIS_SOHeader obj = await rep.FindObject(id);
            SOModelView model = new SOModelView();
            //model.SONo = obj.SONo;
            model.SONumber = id;
            model.Note = "";
            //SOModelView model =  Mapping.AutoMapping.Map<SOModelView>(obj);
            return View(model);
        }

        // POST: Demand/SO/Edit/5
        [Authorize]
        [HttpPost]
        [AjaxOnly]
        
        //[ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(SOModelView so)
        {
            try
            {
                // TODO: Add update logic here
                GenericRepository<DIS_SOHeader> rep = _unit.GeneralRepository<DIS_SOHeader>();
                string[] ids = so.SONumber.Split(new string[] { "," }, StringSplitOptions.None);
                DIS_SOHeader obj = null;
                foreach(var id in ids)
                {
                    obj = await rep.FindObject(int.Parse(id));
                    rep.Update(obj);
                    obj.Note = so.Note;
                }
                _unit.Save();
                return  Content("Updated Successfully!");
                //return Json(new {success="ok" });
                //return RedirectToAction("Index");
            }
            catch
            {
                return Content("Updated Unsuccessfully!");
                //return View();
            }
        }

        // GET: Demand/SO/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Demand/SO/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
