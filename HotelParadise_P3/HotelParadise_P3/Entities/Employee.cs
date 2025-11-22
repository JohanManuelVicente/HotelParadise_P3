using System.ComponentModel.DataAnnotations.Schema;

namespace HotelParadise_P3.Entities
{
    [Table("Employees")]
    public class Employee
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string? Position { get; set; }

        public string? Phone { get; set; }

        public DateTime Date_Admission { get; set; }

    }
}
