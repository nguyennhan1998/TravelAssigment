using MyTravelConsumer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTravelConsumer.Controllers
{
    public class CommentController : Controller
    {
        ServiceClient serviceClient = new ServiceClient();

        // GET: Comment
        public ActionResult Index()
        {
            ViewBag.listComment = serviceClient.Comments();

            return View();
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            var comment = serviceClient.Comments().Where(b => b.id == id).FirstOrDefault();

            return View(comment);
        }

        // GET: Comment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Comment newComment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    serviceClient.AddComment(newComment);
                    return RedirectToAction("Index", "Comment");
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            var comment = serviceClient.Comments().Where(b => b.id == id).FirstOrDefault();

            return View(comment);
        }

        // POST: Comment/Edit/5
        [HttpPost]
        public ActionResult Edit(Comment newComment)
        {
            try
            {
                serviceClient.EditComment(newComment);

                return RedirectToAction("Index", "Comment");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Delete/5
        public ActionResult Delete(string id)
        {
            serviceClient.DeleteComment(id);
            return View();

        }

        // POST: Comment/Delete/5
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
