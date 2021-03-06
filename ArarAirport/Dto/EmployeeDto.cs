using ArarAirport.Models;
using System;
using System.ComponentModel.DataAnnotations;

namespace ArarAirport.Dto
{
    public class EmployeeDto
    {
        public int ID { get; set; }

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