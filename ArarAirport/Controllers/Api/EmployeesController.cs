using ArarAirport.Models;
using System.Data.Entity;
using System.Linq;
using System.Web.Http;

namespace ArarAirport.Controllers.Api
{

    public class EmployeesController : ApiController
    {
        private ApplicationDbContext _context;
        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var employees = _context.Employees.ToList();

            return Ok(employees);
        }

    }
}
