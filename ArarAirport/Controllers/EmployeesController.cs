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
    }
}