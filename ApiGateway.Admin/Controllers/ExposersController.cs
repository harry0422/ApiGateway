using ApiGateway.Core.Contracts.Exposers;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiGateway.Admin.Controllers
{
    public class ExposersController : Controller
    {
        private readonly IExposerManager _exposerManager;

        public ExposersController(IExposerManager exposerManager)
        {
            _exposerManager = exposerManager;
        }

        // GET: Exposers
        public ActionResult Index()
        {
            IList<ExposerDto> exposers = _exposerManager.GetAll();
            return View(exposers);
        }

        // GET: Exposers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Exposers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Exposers/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                InsertExposerDto dto = new InsertExposerDto();
                dto.Name = collection["Name"];
                dto.Path = collection["Path"];
                dto.ServiceId = collection["ServiceId"];

                _exposerManager.Insert(dto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Exposers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Exposers/Edit/5
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

        // GET: Exposers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Exposers/Delete/5
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