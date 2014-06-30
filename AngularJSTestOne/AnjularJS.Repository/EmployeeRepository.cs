using System.Collections.Generic;
using AngularJS.Data;

namespace AnjularJS.Repository
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly IDbAccess _dbAccess;

        public EmployeeRepository(IDbAccess dbAccess)
        {
            _dbAccess = dbAccess;
        }


        public IEnumerable<Employee> QueryAllEmployees()
        {
            return _dbAccess.QueryAllEmployees();
        }

        public void Add(Employee employee)
        {
            _dbAccess.Add(employee);
        }

        //public Employee FindInfo(int Id)
        //{
        //    return _dbAccess.FindInfo(Id);
        //}

        //public void Edit(Employee staff)
        //{
        //    _dbAccess.Edit(staff);
        //}

       
    }
}
