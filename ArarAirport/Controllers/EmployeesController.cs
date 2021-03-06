using ArarAirport.Models;
using ArarAirport.ViewModels;
using System.Web.Mvc;

namespace ArarAirport.Controllers
{
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
        public ActionResult Create(EmployeeViewModel VM)
        {
            var employee = new Employee
            {
                FullName = string.Format("{0} {1} {2}", VM.FirstName, VM.MidName, VM.LastName),
                DateofBirth = VM.DateofBirth,
                IDCodeNum = VM.IDCodeNum,
                ContractTypeID = VM.ContractTypeID,
                PositionID = VM.PositionID,
                MailAddress = VM.MailAddress,
                PhoneNumber = VM.PhoneNumber
            };

            _context.Employees.Add(employee);
            _context.SaveChanges();

            return RedirectToAction("Index", "Employees");
        }

        public ActionResult Index()
        {
            return View();
        }
    }
}