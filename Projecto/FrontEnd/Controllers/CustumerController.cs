using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using FrontEnd.Models;
using FrontEnd.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace FrontEnd.Controllers
{
    public class CustumerController : Controller
    {
        private readonly ICustumerService _custumerService;

        public CustumerController(ICustumerService custumerService)
        {
            _custumerService = custumerService;
        }

        // GET: Custumer
        public ActionResult Index()
        {
            return View();
        }

        // GET: Custumer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Custumer/Create
        public ActionResult Register()
        {
            return View();
        }

        // POST: Custumer/Create
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public async Task<IActionResult> Register([FromForm]CustumerRegisterModel model)
        {
            var httpClient = _custumerService.GetClient();

            var json = JsonConvert.SerializeObject(model);


            var response = await httpClient.PostAsync($"api/Custumer", new StringContent(json, System.Text.Encoding.Unicode, "application/json")).ConfigureAwait(false);

            if (response.IsSuccessStatusCode)
            {
                return View();
            }
            else
            {
                return BadRequest();
            }
        }

        // GET: Custumer/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Custumer/Edit/5
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

        // GET: Custumer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Custumer/Delete/5
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