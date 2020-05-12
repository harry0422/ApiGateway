using ApiGateway.Core.Contracts.DummyServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiGateway.Admin.Controllers
{
    public class DummyServicesController : Controller
    {
        private readonly IDummyServiceManager _dummyServiceManager;

        public DummyServicesController(IDummyServiceManager dummyServiceManager)
        {
            _dummyServiceManager = dummyServiceManager;
        }

        // GET: DummyServices
        public ActionResult Index()
        {
            IList<DummyServiceDto> dummyServices = _dummyServiceManager.GetAll();
            return View(dummyServices);
        }

        // GET: DummyServices/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: DummyServices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DummyServices/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                InsertDummyServiceDto dto = new InsertDummyServiceDto();
                dto.Name = collection["Name"];
                dto.Request = collection["Request"];
                dto.Response = collection["Response"];

                _dummyServiceManager.Insert(dto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DummyServices/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DummyServices/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: DummyServices/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DummyServices/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}