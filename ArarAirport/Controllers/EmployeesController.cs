using ArarAirport.Models;
using ArarAirport.ViewModels;
using System;
using System.Linq;
using System.Web.Mvc;

namespace ArarAirport.Controllers
{
    [Authorize]
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;
        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public ActionResult Create()
        {
            var employee = new EmployeeViewModel();

            return View(employee);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EmployeeViewModel VM)
        {
            var employee = new Employee
            {
                FullName = string.Format("{0} {1} {2}", VM.FirstName, VM.MidName, VM.LastName),
                DateofBirth = DateTime.Parse(string.Format("{0}", VM.DateofBirth)),
                IDCodeNum = VM.IDCodeNum,
                ContractTypeID = VM.ContractTypeID,
                PositionID = VM.PositionID,
                MailAddress = VM.MailAddress,
                PhoneNumber = VM.PhoneNumber,
                IsCancel = VM.IsCancel
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("Index", "Employees");
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Update(int id)
        {

            var employee = _context.Employees.SingleOrDefault(a => a.ID == id);


            var vm = new EmployeeViewModel
            {
                FullName = employee.FullName,
                FirstName = employee.FullName,
                LastName = employee.FullName,
                MidName = employee.FullName,
                DateofBirth = employee.DateofBirth.ToString(),
                ContractTypeID = employee.ContractTypeID,
                IDCodeNum = employee.IDCodeNum,
                PositionID = employee.PositionID,
                MailAddress = employee.MailAddress,
                PhoneNumber = employee.PhoneNumber,
                IsCancel = employee.IsCancel
            };

            return View("Create", vm);
        }

        [HttpPost]
        public ActionResult UPdate(EmployeeViewModel VM)
        {
            var employee = new Employee
            {
                FullName = string.Format("{0} {1} {2}", VM.FirstName, VM.MidName, VM.LastName),
                DateofBirth = DateTime.Parse(string.Format("{0}", VM.DateofBirth)),
                IDCodeNum = VM.IDCodeNum,
                ContractTypeID = VM.ContractTypeID,
                PositionID = VM.PositionID,
                MailAddress = VM.MailAddress,
                PhoneNumber = VM.PhoneNumber
            };

            _context.SaveChanges();
            return RedirectToAction("Index", "Employees");
        }
    }
}