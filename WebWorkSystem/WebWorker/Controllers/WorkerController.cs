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
            /*
            var viewModel = new WorkerListViewModel();

            viewModel.user_id = "user01";
            viewModel.familyname = "青山";
            viewModel.firstname = "大地";
            viewModel.sex_type = "1";
            viewModel.birthday = "1995/11/11";
            viewModel.joined_date = "2015/04/16";
            viewModel.leaved_date = "";

            return View(viewModel);
            */
            return View();
        }

        public ActionResult Detail()
        {
            /*
            var viewModel = new WorkerListViewModel();

            viewModel.user_id = "user01";
            viewModel.familyname = "青山";
            viewModel.firstname = "大地";
            viewModel.familyname_kana = "アオヤマ";
            viewModel.firstname_kana = "ダイチ";
            viewModel.sex_type = "1";
            viewModel.birthday = "1995/11/11";
            viewModel.joined_date = "2015/04/16";
            viewModel.leaved_date = "";
            viewModel.password = "password";
            viewModel.store = "町田";
            viewModel.store_from = "2015/04/16";
            viewModel.store_to = "";

            return View(viewModel);
            */
            return View();
        }

        public ActionResult Edit()
        {
            /*
            var viewModel = new WorkerListViewModel();

            viewModel.user_id = "user01";
            viewModel.familyname = "青山";
            viewModel.firstname = "大地";
            viewModel.familyname_kana = "アオヤマ";
            viewModel.firstname_kana = "ダイチ";
            viewModel.sex_type = "1";
            viewModel.birthday = "1995/11/11";
            viewModel.joined_date = "2015/04/16";
            viewModel.leaved_date = "";
            viewModel.password = "password";
            viewModel.store = "町田";
            viewModel.store_from = "2015/04/16";
            viewModel.store_to = "";

            return View(viewModel);
            */
            return View();
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