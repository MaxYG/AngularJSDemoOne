using System.Collections.Generic;
using AngularJS.Data;

namespace AnjularJS.Repository
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> QueryAllEmployees();
        void Add(Employee staff);
//        Employee FindInfo(int Id);
//        void Edit(Employee staff);
       
    }
}