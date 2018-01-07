using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebWorker.ViewModels.Worker
{
    public class WorkerListViewModel
    {
        /// <summary> ユーザId </summary>
		public int user_id { get; set; }
        /// <summary> 姓 </summary>
		public string familyname { get; set; }
        /// <summary> 名 </summary>
		public string firstname { get; set; }
        /// <summary> セイ </summary>
		public string familyname_kana { get; set; }
        /// <summary> メイ </summary>
		public string firstname_kana { get; set; }
        /// <summary> 性別 </summary>
		public string sex_type { get; set; }
        /// <summary> 生年月日 </summary>
		public string birthday { get; set; }
        /// <summary> 入社日 </summary>
		public string joined_date { get; set; }
        /// <summary> 退社日 </summary>
		public string leaved_date { get; set; }
        /// <summary> パスワード </summary>
		public string password { get; set; }
        /// <summary> 店舗 </summary>
		public string store { get; set; }
        /// <summary> 店舗From </summary>
		public string store_from { get; set; }
        /// <summary> 店舗To </summary>
        public string store_to { get; set; }
    }
}