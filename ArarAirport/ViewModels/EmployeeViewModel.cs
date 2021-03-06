using ArarAirport.Models;
using System.ComponentModel.DataAnnotations;

namespace ArarAirport.ViewModels
{
    public class EmployeeViewModel
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "الاسم الاول")]
        public string FirstName { get; set; }

        [Display(Name = "الاسم الثاني")]
        [Required(ErrorMessage = "*")]
        public string MidName { get; set; }

        [Display(Name = "الاسم الاخير")]
        [Required(ErrorMessage = "*")]
        public string LastName { get; set; }

        [Display(Name = "تاريخ الميلاد")]
        [Required(ErrorMessage = "*")]
        public string DateofBirth { get; set; }

        [Display(Name = "الرقم الوظيفي ")]
        [Required(ErrorMessage = "*")]
        public string IDCodeNum { get; set; }

        [Display(Name = " البريد الالكتروني")]
        [Required(ErrorMessage = "*")]
        public string MailAddress { get; set; }

        [Required(ErrorMessage = "*")]
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
        public bool IsCancel { get; set; }
        public string FullName { get; set; }
    }


}