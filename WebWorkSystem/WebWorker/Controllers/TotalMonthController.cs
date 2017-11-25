using WebWorker.ViewModels.TotalMonth;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebWorker.Controllers
{
    public class TotalMonthController : Controller
    {
        public ActionResult Index()
        {
            var viewModel = new TotalMonthListViewModel();

            viewModel.WorkDay = "3/1";
            viewModel.Name = "青山大地";
            viewModel.StartTime = "06:00";
            viewModel.EndTime = "14:00";

            return View(viewModel);
        }

    }
}