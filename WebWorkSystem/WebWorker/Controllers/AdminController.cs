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

            viewModel.admin_user_id = "admin01";
            viewModel.familyname = "管理者";
            viewModel.firstname = "佐藤";
            viewModel.sex_type = "1";
            viewModel.birthday = "1987/11/01";
            viewModel.joined_date = "2010/04/06";
            viewModel.leaved_date = "";

            return View(viewModel);
        }

        public ActionResult Detail()
        {
            var viewModel = new AdminListViewModel();

            viewModel.admin_user_id = "admin01";
            viewModel.familyname = "管理者";
            viewModel.firstname = "佐藤";
            viewModel.familyname_kana = "カンリシャ";
            viewModel.firstname_kana = "サトウ";
            viewModel.sex_type = "1";
            viewModel.birthday = "1987/11/01";
            viewModel.joined_date = "2010/04/06";
            viewModel.leaved_date = "";
            viewModel.password = "password";
            viewModel.store = "町田";
            viewModel.store_from = "2015/04/16";
            viewModel.store_to = "";

            return View(viewModel);
        }

        public ActionResult Edit()
        {
            var viewModel = new AdminListViewModel();

            viewModel.admin_user_id = "admin01";
            viewModel.familyname = "管理者";
            viewModel.firstname = "佐藤";
            viewModel.familyname_kana = "カンリシャ";
            viewModel.firstname_kana = "サトウ";
            viewModel.sex_type = "1";
            viewModel.birthday = "1987/11/01";
            viewModel.joined_date = "2010/04/06";
            viewModel.leaved_date = "";
            viewModel.password = "password";
            viewModel.store = "町田";
            viewModel.store_from = "2015/04/16";
            viewModel.store_to = "";

            return View(viewModel);
        }

        public ActionResult Register()
        {
            var viewModel = new AdminListViewModel();

            viewModel.sex_type = "1";
            viewModel.store = "町田";

            return View(viewModel);
        }

    }
}