using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorker.ViewModels.Worker
{
    public class WorkerListViewModel
    {
        /// <summary> Id </summary>
		public int Id { get; set; }
        /// <summary> 名前 </summary>
		public string Name { get; set; }
        /// <summary> 性別 </summary>
		public string Sex { get; set; }
        /// <summary> 生年月日 </summary>
		public string BirthDay { get; set; }
        /// <summary> 入社日 </summary>
		public string StartTime { get; set; }
        /// <summary> 退社日 </summary>
		public string EndTime { get; set; }
        /// <summary> パスワード </summary>
		public string Password { get; set; }
        /// <summary> 店舗 </summary>
		public string Store { get; set; }
        /// <summary> 店舗From </summary>
		public string StoreFrom { get; set; }
        /// <summary> 店舗To </summary>
        public string StoreTo { get; set; }
    }
}