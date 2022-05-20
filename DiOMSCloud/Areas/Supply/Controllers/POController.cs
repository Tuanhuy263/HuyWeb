using DiOMSCloud.Areas.Supply.Models;
using DiOMSCloud.Filters;
using DiOMSCloud.Utilities;
using DiOMSEntity;
using DiOMSRepositoryEntity;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace DiOMSCloud.Areas.Supply.Controllers
{
    public class POController : Controller
    {
        private IUnitOfWork _unit;

        public POController(IUnitOfWork unit)
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


        // GET: Supply/PO
        [Authorize(Roles ="Admin")]
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.ViewID = "POList";
            #region load filter component
            GenericRepository<DIS_Vendor> ven = _unit.GeneralRepository<DIS_Vendor>();
            List<SelectListItem> vendorLst = ven.GetAll().Select(x => new SelectListItem { Text = x.VendorName, Value = x.VENDOR_NO }).ToList();
            SelectListItem item = new SelectListItem() { Text = "All", Value = "" };
            vendorLst.Insert(0, item);
            ViewBag.Vendors = vendorLst;

            string[] sts = Enum.GetNames(typeof(Enums.POStatus));
            Enums.POStatus val;
            List<SelectListItem> sts_coll = new List<SelectListItem>();
            foreach (var status in sts)
            {
                Enum.TryParse(status, out val);
                SelectListItem obj = new SelectListItem() { Text = status, Value = ((byte)val).ToString() };
                sts_coll.Add(obj);
            }
            ViewBag.Status = sts_coll;
            #endregion


            return View();
        }

        [Authorize(Roles = "Admin")]
        [HttpGet]
        [AjaxOnly]
        public ActionResult ListPO(int? page, POCriteria cr)
        {
            ViewBag.ViewID = "POHeaderList";
            int pageSize = 5;
            int pageIndex = 1;
            IPagedList<POListView> pagingLst = null;
            List<POListView> vw = null;
            if (page.HasValue)
            {
                pageIndex = Convert.ToInt32(page);
                vw = Session["POList"] as List<POListView>;
            }
            else
            {
                pageIndex =  1;
                GenericRepository<DIS_POHeader> rep = _unit.GeneralRepository<DIS_POHeader>();
                List<DIS_POHeader> lst = rep.Include(x => x.DIS_SOHeader).Where(x => string.IsNullOrEmpty(cr.POOriginalNo) || x.POOriginalNumber.Contains(cr.POOriginalNo))
                                         .Where(x => string.IsNullOrEmpty(cr.PONumber) || x.POOriginalNumber.Contains(cr.PONumber))
                                         .Where(x => string.IsNullOrEmpty(cr.VendorNo) || x.DIS_Vendor.VENDOR_NO.Equals(cr.VendorNo))
                                         .Where(x => cr.FromPODate == null || x.PODate >= cr.FromPODate)
                                         .Where(x => cr.ToPODate == null || x.PODate <= cr.ToPODate)
                                         .Where(x => string.IsNullOrEmpty(cr.Status) || cr.Status.Contains(x.Status.ToString())).ToList();
                if (lst.Count > 0)
                {
                    vw = Mapping.AutoMapping.Map<List<POListView>>(lst);
                    Session["POList"] = vw;
                }
            }

            if(vw != null)
            {
                pagingLst = vw.ToPagedList<POListView>(pageIndex, pageSize);
                return PartialView("DisplayPOHeaders", pagingLst);
            }

            return new EmptyResult();
        }

        // GET: Supply/PO/Details/5
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            GenericRepository<DIS_POHeader> rep = _unit.GeneralRepository<DIS_POHeader>();
            DIS_POHeader obj = await rep.FindObject(id);
            List<PODetailView> lst = Mapping.AutoMapping.Map<List<PODetailView>>(obj.DIS_PODetail);
            return PartialView("DisplayPODetails",lst);
        }

        // GET: Supply/PO/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Supply/PO/Create
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

        // GET: Supply/PO/Edit/5
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Edit(string id)
        {
            GenericRepository<DIS_POHeader> rep = _unit.GeneralRepository<DIS_POHeader>();
            POModelView obj = new POModelView() { Note = "", PONumber = id };
            //DIS_POHeader obj = await rep.FindObject(id);
            //DiOMSCloud.Areas.Supply.Models.POModelView modelView = Mapping.AutoMapping.Map<DiOMSCloud.Areas.Supply.Models.POModelView>(obj);
            return View(obj);
        }

        // POST: Supply/PO/Edit/5
        [Authorize]
        [HttpPost]
        [AjaxOnly]
        public async Task<ActionResult> Edit(DiOMSCloud.Areas.Supply.Models.POModelView po)
        {
            try
            {
                // TODO: Add update logic here
                GenericRepository<DIS_POHeader> rep = _unit.GeneralRepository<DIS_POHeader>();
                string[] ids = po.PONumber.Split(new string[] { "," }, StringSplitOptions.None);
                DIS_POHeader obj = null;
                foreach(var id in ids)
                {
                    obj = await rep.FindObject(int.Parse(id));
                    rep.Update(obj);
                    obj.Note = po.Note;
                }
                
                //_unit.Context.
                //rep.Update(obj);
                _unit.Save();
                //TempData["Msg"]  = "Update Note Successfully";
                //return RedirectToAction("Index");
                return Content("Update Successfully.");
            }
            catch
            {
                //ViewBag.UpdateMsg = "Update Note Unsuccessfully";
                //return View(po);
                return Content("Update Successfully.");
            }
        }

        [HttpPost]
        [Authorize(Roles ="Admin")]
        public async Task<ActionResult> UpdateNote(int[] ids, string note, POModelView sample)
        {
            try
            {
                // TODO: Add update logic here
                GenericRepository<DIS_POHeader> rep = _unit.GeneralRepository<DIS_POHeader>();
                DIS_POHeader obj = null;
                foreach (var id in ids)
                {
                    obj = await rep.FindObject(id);
                    rep.Update(obj);
                    obj.Note = note;
                }

                //_unit.Context.
                //rep.Update(obj);
                _unit.Save();
                //TempData["Msg"]  = "Update Note Successfully";
                //return RedirectToAction("Index");
                return Json(new { message = "Update Successfully" });
            }
            catch
            {
                //ViewBag.UpdateMsg = "Update Note Unsuccessfully";
                //return View(po);
                return Json(new { message = "Update Unsuccessfully" });
            }
        }

        //[Authorize]
        //[HttpGet]
        //public ActionResult CallAPITest()
        //{
        //    ServiceFactory cls = new ServiceFactory();
        //    HttpResponseMessage re = cls.Get("/api/Test/ReturnVal");
        //    return new EmptyResult();
        //}

        // GET: Supply/PO/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Supply/PO/Delete/5
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
