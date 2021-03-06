using ArarAirport.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ArarAirport.ViewModels
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "الاسم الاول")]
        public string FirstName { get; set; }
        [Display(Name = "الاسم الثاني")]
        public string MidName { get; set; }
        [Display(Name = "الاسم الاخير")]
        public string LastName { get; set; }
        [Display(Name = "تاريخ الميلاد")]
        public DateTime DateofBirth { get; set; }
        [Display(Name = "الرقم الوظيفي ")]
        public string IDCodeNum { get; set; }
        [Display(Name = " البريد الالكتروني")]
        public string MailAddress { get; set; }
        [Display(Name = " الجوال")]
        public string PhoneNumber { get; set; }
        [Display(Name = " نوع العقد")]
        public ContractType ContractType { get; set; }

        [Required]
        public int ContractTypeID { get; set; }

        [Required]
        [Display(Name = " المسمى الوظيفي")]
        public Position Position { get; set; }

        public int PositionID { get; set; }
    }


}