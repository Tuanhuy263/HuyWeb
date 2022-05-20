using DiOMSCloud.Filters;
using DiOMSCloud.ResponseModels;
using DiOMSCloud.Utilities;
using Newtonsoft.Json;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DiOMSCloud.Areas.Item.Controllers
{
    public class ItemController : Controller
    {

        protected override IAsyncResult BeginExecuteCore(AsyncCallback callback, object state)
        {
            Dictionary<string, string> dics = HttpContext.Application["Dictionary"] as Dictionary<string, string>;
            foreach (var val in dics)
            {
                ViewData[val.Key] = val.Value;
            }
            return base.BeginExecuteCore(callback, state);
        }

        [NonAction]
        private void ValidateTokenExpiration()
        {
            string jwt = Session["Access_Token"].ToString();
            if(ExtraProcess.JWTExpired(jwt))
            {
                TokenResponseModel token = ExtraProcess.GetTokenFromAPI(User.Identity.Name, Session["password"].ToString());
                Session["Access_Token"] = token.Access_token;
            }
        }
        // GET: Item/Item
        [HttpGet]
        [Authorize]
        public ActionResult Index()
        {
            ViewBag.ViewID = "ItemList";
            #region load static data
            ItemCriteria cr = new  ItemCriteria();
            #region item type
            Enums.ManagementType[] itemValues = (Enums.ManagementType[])Enum.GetValues(typeof(Enums.ManagementType));
            List<SelectListItem> colls = itemValues.Select(x =>
            {
                SelectListItem obj = new SelectListItem() { Text = Enum.GetName(typeof(Enums.ManagementType),x), Value = ((byte)x).ToString() };
                return obj;
            }).ToList();

            ViewBag.ItemType = colls;
            #endregion
            #endregion
            return View(cr);
        }


        [HttpGet]
        [Authorize]
        [AjaxOnly]
        public ActionResult ListItem(int? page, ItemCriteria cr)
        {
            ViewBag.ViewID = "ItemListHeader";
            ServiceFactory cls = new ServiceFactory();
            int pageSize = 10;
            int pageIndex = 1;
            List<ItemView> lst = null;
            IPagedList<ItemView> pagingLst = null;
            if (page.HasValue)
            {
                pageIndex = Convert.ToInt32(page);
                if (Session["ItemList"] != null)
                {
                    lst = Session["ItemList"] as List<ItemView>;
                }
            }
            else
            {
                pageIndex = 1;
                ValidateTokenExpiration();
                DiOMSCloud.ResponseModels.JsonResponseModel re = cls.Post("api/Test/LoadItem", JsonConvert.SerializeObject(cr), "page=6");
                if (re != null)
                {
                    string ss = re.Data.ToString();
                    lst = JsonConvert.DeserializeObject<List<ItemView>>(ss);
                    Session["ItemList"] = lst;
                }
            }

            if (lst != null)
            {
                pagingLst = lst.ToPagedList<ItemView>(pageIndex, pageSize);
                return PartialView("DisplayItems", pagingLst);
            }
            
            return new EmptyResult(); 
        }

        // GET: Item/Item/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Item/Item/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Item/Item/Create
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

        // GET: Item/Item/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Item/Item/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Item/Item/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Item/Item/Delete/5
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
