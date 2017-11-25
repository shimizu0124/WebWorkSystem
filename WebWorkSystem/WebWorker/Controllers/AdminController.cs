using WebWorker.ViewModels.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWorker.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new AdminListViewModel();

            viewModel.Id = 10001;
            viewModel.Name = "管理者";
            viewModel.Sex = "男";
            viewModel.BirthDay = "1987/11/01";
            viewModel.Age = 30;
            viewModel.StartTime = "2010/04/06";
            viewModel.EndTime = "";

            return View(viewModel);
        }

        public ActionResult Detail()
        {
            var viewModel = new AdminListViewModel();

            viewModel.Id = 10001;
            viewModel.Name = "管理者";
            viewModel.Sex = "男";
            viewModel.BirthDay = "1987/11/01";
            viewModel.Age = 30;
            viewModel.StartTime = "2010/04/06";
            viewModel.EndTime = "";
            viewModel.Password = "password";
            viewModel.Store = "町田";
            viewModel.StoreFrom = "2015/04/16";
            viewModel.StoreTo = "";

            return View(viewModel);
        }

        public ActionResult Edit()
        {
            var viewModel = new AdminListViewModel();

            viewModel.Id = 10001;
            viewModel.Name = "管理者";
            viewModel.Sex = "男";
            viewModel.BirthDay = "1987/11/01";
            viewModel.Age = 30;
            viewModel.StartTime = "2010/04/06";
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