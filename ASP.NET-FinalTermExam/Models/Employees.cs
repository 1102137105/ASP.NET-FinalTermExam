using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.NET_FinalTermExam.Models
{
    public class Employees
    {
        /// <summary>
        /// 員工編號
        /// </summary>
        public int EmployeeId { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// 員工姓名
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// 業務職稱
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// 職稱頭銜
        /// </summary>
        public string TitleOfCourtesy { get; set; }

        /// <summary>
        /// 出生日期
        /// </summary>
        public DateTime? BirthDate { get; set; }

        /// <summary>
        /// 雇用日期
        /// </summary>
        public DateTime? HireDdate { get; set; }

        /// <summary>
        /// 地址
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        public string City { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Region { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string PostalCode { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Country { get; set; }

        /// <summary>
        /// 電話
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string MnangerID { get; set; }

        
    }
}