using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleApplication.Models;

namespace SampleApplication.Controllers
{
    public class UserController : Controller
    {
        private SampleApplicationContext db = new SampleApplicationContext();

        //
        // GET: /User/

        public ActionResult Index()
        {
            return View(db.UserModels.ToList());
        }

        //
        // GET: /User/Details/5

        public ActionResult Details(int id = 0)
        {
            UserModel usermodel = db.UserModels.Find(id);
            if (usermodel == null)
            {
                return HttpNotFound();
            }
            return View(usermodel);
        }

        //
        // GET: /User/Create

        public ActionResult Create()
        {
            if (5 > 4)
            {

            }
            return View();
        }

        //
        // POST: /User/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserModel usermodel)
        {
            if (ModelState.IsValid)
            {
               
            }

            return View(usermodel);
        }

        //
        // GET: /User/Edit/5

        public ActionResult Edit(int id = 0)
        {
            UserModel usermodel = db.UserModels.Find(id);
            if (usermodel == null)
            {
                return HttpNotFound();
            }
            return View(usermodel);
        }

        //
        // POST: /User/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(UserModel usermodel)
        {
            if (ModelState.IsValid)
            {
                db.Entry(usermodel).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(usermodel);
        }

        //
        // GET: /User/Delete/5

        public ActionResult Delete(int id = 0)
        {
            UserModel usermodel = db.UserModels.Find(id);
            if (usermodel == null)
            {
                return HttpNotFound();
            }
            return View(usermodel);
        }

        //
        // POST: /User/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            UserModel usermodel = db.UserModels.Find(id);
            db.UserModels.Remove(usermodel);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}