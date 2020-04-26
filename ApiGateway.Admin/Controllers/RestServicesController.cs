using ApiGateway.Core.Contracts.RestServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiGateway.Admin.Controllers
{
    public class RestServicesController : Controller
    {
        private readonly IRestServiceManager _restServicesManager;

        public RestServicesController(IRestServiceManager restServicesManager)
        {
            _restServicesManager = restServicesManager;
        }

        // GET: RestServices
        public ActionResult Index()
        {
            IList<RestServiceDto> restServices = _restServicesManager.GetAllRestServices();
            return View(restServices);
        }

        // GET: RestServices/Details/5
        public ActionResult Details(string id)
        {
            RestServiceIdDto dto = new RestServiceIdDto(id);
            RestServiceDto restService = _restServicesManager.GetRestServiceById(dto);
            return View(restService);
        }

        // GET: RestServices/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestServices/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                RestServiceRequestDto dto = new RestServiceRequestDto(collection["RequestUrl"], collection["HttpMethod"], collection["BodyFormat"]);
                _restServicesManager.AddRestServie(dto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestServices/Edit/5
        public ActionResult Edit(string id)
        {
            return View();
        }

        // POST: RestServices/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(string id, IFormCollection collection)
        {
            try
            {
                RestServiceDto dto = new RestServiceDto(id, collection["RequestUrl"], collection["HttpMethod"], collection["BodyFormat"]);
                _restServicesManager.UpdateRestService(dto);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestServices/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RestServices/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(string id, IFormCollection collection)
        {
            try
            {
                RestServiceIdDto dto = new RestServiceIdDto(id);
                _restServicesManager.DeleteRestService(dto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}