using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
    }
}