using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorker.ViewModels.Day
{
    public class DayListViewModel
    {
        /// <summary> 出勤時間 </summary>
		public string StartTime { get; set; }
        /// <summary> 休憩開始時間 </summary>
		public string BreakStartTime { get; set; }
        /// <summary> 休憩終了時間 </summary>
		public string BreakEndTime { get; set; }
        /// <summary> 退勤時間 </summary>
		public string EndTime { get; set; }
        /// <summary> 実勤務時間 </summary>
		public string WorkTime { get; set; }
        /// <summary> ヘルプ先 </summary>
		public string Help { get; set; }
    }
}