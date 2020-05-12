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
            IList<RestServiceDto> restServices = _restServicesManager.GetAll();
            return View(restServices);
        }

        // GET: RestServices/Details/5
        public ActionResult Details(string id)
        {
            RestServiceIdDto dto = new RestServiceIdDto(id);
            RestServiceDto restService = _restServicesManager.GetById(dto);
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
                InsertRestServiceDto dto = new InsertRestServiceDto();
                dto.Name = collection["Name"];
                dto.RequestUrl = collection["RequestUrl"];
                dto.HttpMethod = collection["HttpMethod"];
                dto.BodyFormat = collection["BodyFormat"];

                _restServicesManager.Insert(dto);

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
                RestServiceDto dto = new RestServiceDto();

                dto.Id = id;
                dto.RequestUrl = collection["RequestUrl"];
                dto.HttpMethod = collection["HttpMethod"];
                dto.BodyFormat = collection["BodyFormat"];

                _restServicesManager.Update(dto);

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
                _restServicesManager.Delete(dto);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}