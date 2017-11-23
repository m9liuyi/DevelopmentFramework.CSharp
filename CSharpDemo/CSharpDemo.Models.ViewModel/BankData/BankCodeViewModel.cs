using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDemo.Models.ViewModel
{
    public class BankCodeViewModel
    {
        /// <summary>
        /// 
        /// </summary>
        public int ZJBankCodeID { set; get; }

        /// <summary>
        /// 银行国家代码
        /// </summary>
        public string CountryCode { set; get; }
        /// <summary>
        /// 银行代码
        /// </summary>
        public string BankCode { set; get; }
        /// <summary>
        /// 银行名称
        /// </summary>
        public string BankName { set; get; }
        /// <summary>
        /// 联行号
        /// </summary>
        public string CNAPS { set; get; }
        /// <summary>
        /// 分行
        /// </summary>
        public string BranchName { set; get; }
        /// <summary>
        /// 地区
        /// </summary>
        public string RegionCode { set; get; }
        /// <summary>
        /// 城市
        /// </summary>
        public string City { set; get; }
        /// <summary>
        /// 街道
        /// </summary>
        public string Street { set; get; }
        /// <summary>
        /// SWIFT
        /// </summary>
        public string SWIFT { set; get; }
        /// <summary>
        /// 银行组
        /// </summary>
        public string BankGroup { set; get; }
        /// <summary>
        /// 是否邮政银行的往来账户号
        /// </summary>
        public string LinkPSBC { set; get; }
        /// <summary>
        /// YYYYMMDD
        /// </summary>
        public string CreateDate { set; get; }
        /// <summary>
        /// HH:mm:ss
        /// </summary>
        public string CreateTime { set; get; }
        public string Creator { set; get; }
        public string ModifyDate { set; get; }
        public string ModifyTime { set; get; }
        public string Modifier { set; get; }
        public string IsDeleted { set; get; }
    }
}
