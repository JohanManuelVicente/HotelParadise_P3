using HotelParadise_P3.Data;
using HotelParadise_P3.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HotelParadise_P3.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeesController : ControllerBase
    {

        private readonly HotelParadiseDBContext _context;
        public EmployeesController(HotelParadiseDBContext context)
        {

            _context = context;

        }

        //metodo GET para obtener todos los empleados de la BD
        [HttpGet]
        public IActionResult GetAllEmployees()
        {
            var Employees = _context.Employees.ToList();
            return Ok(Employees);
        }


        //metoo POST para crear y agregar un nuevo empleado en LA BD
        [HttpPost]
        public IActionResult PostEmployees([FromBody] Employee employee)
        {
            if (employee.Position == null)
            {
                return BadRequest($"Cargo no puede ser nulo");
            }

            employee.Date_Admission = DateTime.Now;
            _context.Add(employee);
            _context.SaveChanges();
            return Ok(employee);
        }
    }
}
