﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TWNewEgg.DB.TWSQLDB.Models
{
    [Table("PromotionGiftInterval")]
    public class PromotionGiftInterval
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        /// <summary>
        /// 滿額贈ID
        /// </summary>
        public int PromotionGiftBasicID { get; set; }

        /// <summary>
        /// 下限
        /// </summary>
        public decimal LowerLimit { get; set; }

        /// <summary>
        /// 上限
        /// </summary>
        public decimal UpperLimit { get; set; }

        /// <summary>
        /// 購物車折價金額
        /// </summary>
        public decimal DiscountAmount { get; set; }

        /// <summary>
        /// 折扣百分比 ex:95折請填入95
        /// </summary>
        public decimal DiscountPercent { get; set; }

        /// <summary>
        /// 建立者
        /// </summary>
        public string CreateUser { get; set; }

        /// <summary>
        /// 建立日期
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreateDate { get; set; }

        /// <summary>
        /// 最後修改者
        /// </summary>
        public string UpdateUser { get; set; }

        /// <summary>
        /// 最後修改時間
        /// </summary>
        public DateTime? UpdateDate { get; set; }
    }
}
