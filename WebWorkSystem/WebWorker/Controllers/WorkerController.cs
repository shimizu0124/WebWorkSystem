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

        public ActionResult Register()
        {
            var viewModel = new WorkerListViewModel();

            viewModel.sex_type = "1";
            viewModel.store = "町田";

            return View(viewModel);
        }

    }
}