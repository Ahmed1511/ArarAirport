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
            var employees = _context.Employees.Where(a => a.IsCancel == false).ToList();

            return Ok(employees);
        }

        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var employee = _context.Employees.SingleOrDefault(a => a.ID == id);

            return Ok(employee);
        }

        public IHttpActionResult Delete(int id)
        {
            var employee = _context.Employees.SingleOrDefault(c => c.ID == id);
            employee.IsCancel = true;
            _context.SaveChanges();
            return Ok();
        }



    }
}
