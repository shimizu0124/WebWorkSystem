using WebWorker.ViewModels.Worker;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWorker.Controllers
{
    public class WorkerController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(Users model)
        {
            using (var db = new WebWorkSystemEntities())
            {
                var entity = db.Users.Where(x => x.user_id == model.user_id).SingleOrDefault();
                return View(entity);
            }
        }

        public ActionResult Edit(Users model)
        {
            using (var db = new WebWorkSystemEntities())
            {
                var entity = db.Users.Where(x => x.user_id == model.user_id).SingleOrDefault();
                return View(entity);
            }
        }

        [HttpPost]
        public ActionResult exeEdit(Users model)
        {
            using (var db = new WebWorkSystemEntities())
            {
                model.created_at = DateTime.Parse("2018-03-01 00:00:00");
                model.created_by = "管理者";
                model.updated_at = DateTime.Parse("2018-03-01 00:00:00");
                model.updated_by = "管理者";

                db.Entry(model).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public ActionResult exeRegister(Users model)
        {
            using (var db = new WebWorkSystemEntities())
            {
                model.created_at = DateTime.Parse("2018-03-01 00:00:00");
                model.created_by = "管理者";
                model.updated_at = DateTime.Parse("2018-03-01 00:00:00");
                model.updated_by = "管理者";

                db.Users.Add(model);
                db.SaveChanges();
            }
            return View("Index");
        }

    }
}