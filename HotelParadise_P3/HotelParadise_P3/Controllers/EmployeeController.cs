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

    }
}
