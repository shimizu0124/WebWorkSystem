using WebWorker.ViewModels.TotalDay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWorker.Controllers
{
    public class TotalDayController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new TotalDayListViewModel();

            viewModel.Name = "青山大地";
            viewModel.StartTime = "06:00";
            viewModel.BreakStartTime = "10:00";
            viewModel.BreakEndTime = "11:00";
            viewModel.EndTime = "14:00";
            viewModel.WorkTime = "07:00";
            viewModel.Help = "町田";

            return View(viewModel);
        }

        public ActionResult Edit()
        {
            var viewModel = new TotalDayListViewModel();

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