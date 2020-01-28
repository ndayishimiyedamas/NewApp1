
using System.Collections.Generic;
using NewApp.Models;
namespace NewApp.ViewModel
{
    public class HomeViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }
        public object Employee { get; set; }
    }
}