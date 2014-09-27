using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AutoMapper;
using TripadvisorService;

namespace Tripadvisor.Controllers
{
    public class HotelsController : Controller
    {
        //
        // GET: /Hotels/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Hotels/Details/5

        public ActionResult Details(string name)
        {
            Mapper.CreateMap<TripadvisorService.Review, Models.Review>();
            Mapper.CreateMap<TripadvisorService.Location, Models.Location>();
            Mapper.CreateMap<TripadvisorService.Hotel, Models.Hotel>();

            var client = new TripadvisorServiceClient();
            var hotel = client.GetHotelByName(name);
            var hotelObj = Mapper.Map<TripadvisorService.Hotel, Models.Hotel>(hotel);
            
            return View(hotelObj);
        }

        //
        // GET: /Hotels/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Hotels/Create

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

        //
        // GET: /Hotels/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Hotels/Edit/5

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

        //
        // GET: /Hotels/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Hotels/Delete/5

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
