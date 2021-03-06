﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWNewEgg.Models.ViewModels.PromoAwardLog
{
    public class PromoAwardLog
    {
        public int AccountID { get; set; }
        public string AwardName { get; set; }
        public string ChName { get; set; }
        public DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public string Email { get; set; }
        public string EngFirstName { get; set; }
        public string EngLastName { get; set; }
        public int ID { get; set; }
        public int PromoActiveID { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateUser { get; set; }

        /// <summary>
        /// 活動名稱
        /// </summary>
        public string activityName { get; set; }
    }

    public class PromoAwardLogVM
    {
        public PromoAwardLogVM()
        {
            EmailName = new List<CollectEmailAndName>();
        }
        public string AwardName { get; set; }
        public int Awardcount { get; set; }
        public List<CollectEmailAndName> EmailName { get; set; }
    }
    public class CollectEmailAndName
    {
        public string AccountEmail { get; set; }
        public string AccountName { get; set; }
    }
}
