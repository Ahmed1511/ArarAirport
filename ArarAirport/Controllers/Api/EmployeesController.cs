using ArarAirport.Dto;
using ArarAirport.Models;
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

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var employee = _context.Employees.SingleOrDefault(a => a.ID == id);

            return Ok(employee);
        }

        

    }
}
