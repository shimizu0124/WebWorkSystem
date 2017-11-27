using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorker.ViewModels.TotalMonth
{
    public class TotalMonthListViewModel
    {
        /// <summary> 日付 </summary>
		public string WorkDay { get; set; }
        /// <summary> 名前 </summary>
		public string Name { get; set; }
        /// <summary> 出勤時間 </summary>
		public string StartTime { get; set; }
        /// <summary> 退勤時間 </summary>
		public string EndTime { get; set; }
        /// <summary> 実勤務時間 </summary>
		public string WorkTime { get; set; }
    }
}