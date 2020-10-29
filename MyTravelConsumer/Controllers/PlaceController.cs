using MyTravelConsumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTravelConsumer.Controllers
{
    public class PlaceController : Controller
    {
        ServiceClient serviceClient = new ServiceClient();
        // GET: Place
        public ViewResult Index(string sortOrder, string search, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            /*            ViewBag.listLocation = servicesClient.getAllLocations();
            */
            if (search != null)
            {
                page = 1; // nếu search có giá trị trả về page = 1
            }
            else
            {
                search = currentFilter; //  nếu có thì render phần dữ liệu search ra
            }
            ViewBag.CurrentFilter = search;
            var places = from s in serviceClient.GetPlaces() select s;
            if (!String.IsNullOrEmpty(search)) // check nếu search string có thì in ra hoặc không thì không in ra
            {
                places = places.Where(s => s.PlaceName.Contains(search) || s.PlaceAddress.Contains(search)); // contains là để check xem lastname hoặc firstName có chứa search string ở trên 
            }
            switch (sortOrder)
            {
                case "name desc":
                    places = places.OrderByDescending(s => s.PlaceName); // các case tương đương với các cột muốn sort
                    break;

                default:
                    places = places.OrderBy(s => s.PlaceAddress);
                    break;
            }

            return View(places.ToList());
        }

        // GET: Place/Details/5
        public ActionResult Details(int id)
        {
            var place = serviceClient.GetPlaces().Where(b => b.id == id).FirstOrDefault();
            return View(place);
        }

        // GET: Place/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Place/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Place newPlace)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    serviceClient.AddPlace(newPlace);
                    return RedirectToAction ("Index", "Place");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Place/Edit/5
        public ActionResult Edit(int id)
        {
            var place = serviceClient.GetPlaces().Where(b => b.id == id).FirstOrDefault();

            return View(place);
        }

        // POST: Place/Edit/5
        [HttpPost]
        public ActionResult Edit(Place newPlace)
        {
            try
            {
                serviceClient.EditPlace(newPlace);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Place/Delete/5
        public ActionResult Delete(string id)
        {
            serviceClient.DeletePlace(id);
            return View();
        }

        // POST: Place/Delete/5
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
