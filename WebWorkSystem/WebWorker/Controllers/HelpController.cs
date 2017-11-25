using WebWorker.ViewModels.Help;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWorker.Controllers
{
    public class HelpController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new HelpListViewModel();

            viewModel.WorkDay = "3/1";
            viewModel.Name = "青山大地";
            viewModel.StartTime = "06:00";
            viewModel.BreakStartTime = "10:00";
            viewModel.BreakEndTime = "11:00";
            viewModel.EndTime = "14:00";
            viewModel.WorkTime = "07:00";
            viewModel.Help = "町田";

            return View(viewModel);
        }

    }
}