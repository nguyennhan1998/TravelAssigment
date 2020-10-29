using MyTravelConsumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTravelConsumer.Controllers
{
    public class ImageController : Controller
    {
        ServiceClient serviceClient = new ServiceClient();

        // GET: Image
        public ActionResult Index()
        {
            ViewBag.listImage = serviceClient.Images();
            return View();
        }

        // GET: Image/Details/5
        public ActionResult Details(int id)
        {
            var image = serviceClient.Images().Where(b => b.id == id).FirstOrDefault();

            return View(image);
        }

        // GET: Image/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Image/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Image newImage)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    serviceClient.AddImage(newImage);
                    return RedirectToAction("Index", "Image");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Edit/5
        public ActionResult Edit(int id)
        {
            var image = serviceClient.Images().Where(b => b.id == id).FirstOrDefault();

            return View(image);
        }

        // POST: Image/Edit/5
        [HttpPost]
        public ActionResult Edit(Image newImage)
        {
            try
            {
                serviceClient.EditImage(newImage);

                return RedirectToAction("Index","Image");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Delete/5
        public ActionResult Delete(string id)
        {
            serviceClient.DeleteImage(id);
            return View();
        }

        // POST: Image/Delete/5
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
