using System;
using System.ComponentModel.DataAnnotations;

namespace ArarAirport.Models
{
    public class Employee
    {
        public int ID { get; set; }

        [Required]
        public string FullName { get; set; }

        public DateTime DateofBirth { get; set; }

        public string IDCodeNum { get; set; }

        public string MailAddress { get; set; }

        public string PhoneNumber { get; set; }
        public ContractType ContractType { get; set; }

        [Required]
        public int ContractTypeID { get; set; }

        [Required]
        public Position Position { get; set; }

        public int PositionID { get; set; }

        public bool IsCancel { get; set; }
    }
}