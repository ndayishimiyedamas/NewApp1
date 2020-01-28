using System.Collections.Generic;
using NewApp.Models;

namespace NewApp.Repository
{
    public class RepositoryEmployee: IEmployee
    {
        public void InsertEmpRecord(Employee emp)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Employee> GetEmployees()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateEmpRecord(Employee emp)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteEmpRecord(int empId)
        {
            throw new System.NotImplementedException();
        }

        public Employee GetEmpById(int empId)
        {
            throw new System.NotImplementedException();
        }
    }
}