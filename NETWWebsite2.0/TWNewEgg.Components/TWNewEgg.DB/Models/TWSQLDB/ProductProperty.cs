﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace TWNewEgg.DB.TWSQLDB.Models
{
    [Table("ProductProperty")]
    public partial class ProductProperty
    {
        public enum fronShow
         {
            Notshowfront = 1,
            showfront= 0
    
         }
        [Key, Column("ProductID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductID { get; set; }
        [Key, Column("ProductValueID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ProductValueID { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int GroupID { get; set; }
       [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PropertyNameID { get; set; }
        public string UserInputValue { get; set; }
        public string UserInputValueTW { get; set; }
        /// <summary>
        /// 0:Show
        /// 1:Not show 
        /// Default=0
        /// </summary>
        public int? Show { get; set; }
        /// <summary>
        /// 0:不產生
        /// 1:產生標籤
        /// </summary>
        public int? Label { get; set; }
        public string CreateUser { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}