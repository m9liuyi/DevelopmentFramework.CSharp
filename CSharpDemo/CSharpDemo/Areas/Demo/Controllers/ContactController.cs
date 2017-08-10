using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CSharpDemo.BL;
using CSharpDemo.Models.DTO;
using CSharpDemo.Models.ViewModel;
using CSharpDemo.Utility;
using CSharpDemo.Models.QueryParameter;

namespace CSharpDemo.Areas.Demo.Controllers
{
    public class ContactController : Controller
    {
        // GET: Demo/Contact
        public ActionResult Index()
        {
            ContractManager contactManager = new ContractManager();

            var list = contactManager.List(new ContactQueryParameter());

            var models = MapperHelper.MapTo<ContactViewModel>(list);

            return View(models);
        }

        // GET: Demo/Contact/Details/5
        public ActionResult Details(int id)
        {
            ContractManager contactManager = new ContractManager();
            var contact = contactManager.Get(id);
            var model = MapperHelper.MapTo<ContactViewModel>(contact);
            return View(model);
        }

        // GET: Demo/Contact/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Demo/Contact/Create
        [HttpPost]
        public ActionResult Create(ContactViewModel contact)
        {
            try
            {
                // TODO: Add insert logic here
                ContractManager contactManager = new ContractManager();

                var dto = MapperHelper.MapTo<ContactDTO>(contact);

                dto = contactManager.Create(dto);
                return RedirectToAction("Index", new { Id = contact.ID });
            }
            catch(Exception e)
            {
                return View();
            }
        }

        // GET: Demo/Contact/Edit/5
        public ActionResult Edit(int id)
        {
            ContractManager contactManager = new ContractManager();

            var contact = contactManager.Get(id);
            var model = MapperHelper.MapTo<ContactViewModel>(contact);

            return View(model);
        }

        // POST: Demo/Contact/Edit/5
        [HttpPost]
        public ActionResult Edit(ContactViewModel contact)
        {
            try
            {
                // TODO: Add update logic here
                ContractManager contactManager = new ContractManager();

                var dto = MapperHelper.MapTo<ContactDTO>(contact);

                dto = contactManager.Update(dto);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Demo/Contact/Delete/5
        public ActionResult Delete(int id)
        {
            ContractManager contactManager = new ContractManager();
            var contact = contactManager.Get(id);
            var model = MapperHelper.MapTo<ContactViewModel>(contact);
            return View(model);
        }

        // POST: Demo/Contact/DeleteImpl/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection formCollection)
        {
            try
            {
                // TODO: Add delete logic here
                ContractManager contactManager = new ContractManager();
                contactManager.Delete(id);
                return RedirectToAction("Index");
            }
            catch(Exception e)
            {
                return View();
            }
        }
    }
}
