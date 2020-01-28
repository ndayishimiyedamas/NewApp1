using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using NewApp.Models;

namespace NewApp.Repository
{
    public interface IEmployee
    {
        void InsertEmpRecord(Employee emp);
        IEnumerable<Employee> GetEmployees();
        void UpdateEmpRecord(Employee emp);
        void DeleteEmpRecord(int empId);
        Employee GetEmpById(int empId);

    }
}