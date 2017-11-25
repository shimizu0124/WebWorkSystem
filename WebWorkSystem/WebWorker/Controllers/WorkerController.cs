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
            var viewModel = new WorkerListViewModel();

            viewModel.Id = 1001;
            viewModel.Name = "青山大地";
            viewModel.Sex = "男";
            viewModel.BirthDay = "1995/11/11";
            viewModel.StartTime = "2015/04/16";
            viewModel.EndTime = "";

            return View(viewModel);
        }

        public ActionResult Detail()
        {
            var viewModel = new WorkerListViewModel();

            viewModel.Id = 1001;
            viewModel.Name = "青山大地";
            viewModel.Sex = "男";
            viewModel.BirthDay = "1995/11/11";
            viewModel.StartTime = "2015/04/16";
            viewModel.EndTime = "";
            viewModel.Password = "password";
            viewModel.Store = "町田";
            viewModel.StoreFrom = "2015/04/16";
            viewModel.StoreTo = "";

            return View(viewModel);
        }

        public ActionResult Edit()
        {
            var viewModel = new WorkerListViewModel();

            viewModel.Id = 1001;
            viewModel.Name = "青山大地";
            viewModel.Sex = "男";
            viewModel.BirthDay = "1995/11/11";
            viewModel.StartTime = "2015/04/16";
            viewModel.EndTime = "";
            viewModel.Password = "password";
            viewModel.Store = "町田";
            viewModel.StoreFrom = "2015/04/16";
            viewModel.StoreTo = "";

            return View(viewModel);
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}