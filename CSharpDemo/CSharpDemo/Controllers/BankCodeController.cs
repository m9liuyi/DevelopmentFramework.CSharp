using CSharpDemo.BL.Interface;
using CSharpDemo.Models.DTO;
using CSharpDemo.Models.ViewModel;
using CSharpDemo.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CSharpDemo.Controllers
{
    public class BankCodeController : Controller
    {
        private IZJBankCodeManager mgr;

        public BankCodeController(IZJBankCodeManager _mgr)
        {
            this.mgr = _mgr;
        }

        // GET: BankCode
        public ActionResult Index()
        {
            var list = mgr.List(new Models.QueryParameter.ZJBankCodeQueryParameter());
            return View(MapperHelper.MapTo<BankCodeViewModel>(list));
        }

        // GET: BankCode/Details/5
        public ActionResult Details(int id)
        {
            var dto = mgr.Get(id);
            return View(MapperHelper.MapTo<BankCodeViewModel>(dto));
        }

        // GET: BankCode/Create
        public ActionResult Create()
        {
            LogHelper.LogInformation("create");
            return View();
        }

        // POST: BankCode/Create
        [HttpPost]
        public ActionResult Create(BankCodeViewModel vm)
        {
            try
            {
                // TODO: Add insert logic here
                mgr.Create(MapperHelper.MapTo<ZJBankCodeDTO>(vm));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankCode/Edit/5
        public ActionResult Edit(int id)
        {
            var dto = mgr.Get(id);
            return View(MapperHelper.MapTo<BankCodeViewModel>(dto));
        }

        // POST: BankCode/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, BankCodeViewModel vm)
        {
            try
            {
                // TODO: Add update logic here
                mgr.Update(MapperHelper.MapTo<ZJBankCodeDTO>(vm));
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: BankCode/Delete/5
        public ActionResult Delete(int id)
        {
            var dto = mgr.Get(id);
            return View(MapperHelper.MapTo<BankCodeViewModel>(dto));
        }

        // POST: BankCode/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, BankCodeViewModel vm)
        {
            try
            {
                // TODO: Add delete logic here
                mgr.Delete(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
