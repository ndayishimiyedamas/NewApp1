using System.ComponentModel.DataAnnotations;

namespace NewApp.Models
{
    public class Employee
    {
        [Key]
        public static int Id { get; set; }
        public string Name { get; set; }
        public static string Email { get; set; }
        public int Salary { get; set; }
    }
}