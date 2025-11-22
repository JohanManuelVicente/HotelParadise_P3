using HotelParadise_P3.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelParadise_P3.Data
{
    public class HotelParadiseDBContext : DbContext
    {
        public HotelParadiseDBContext(DbContextOptions<HotelParadiseDBContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
    }
}
