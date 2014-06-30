using System.Collections.Generic;
using System.Data.Entity;

namespace AngularJS.Data
{
    public class DbAccess :IDbAccess
    {
        private readonly AngularDb _angularDb;
        public DbAccess(AngularDb angularDb)
        {
            _angularDb = angularDb;
        }

        public IEnumerable<Employee> QueryAllEmployees()
        {
            return _angularDb.Employees;
        }

        public void Add(Employee staff)
        {
            _angularDb.Employees.Add(staff);
            _angularDb.SaveChanges();
        }

        //public Employee FindInfo(int id)
        //{
        //    return _angularDb.Employees.Find(id);
        //}

        //public void Edit(Employee employee)
        //{
        //    _angularDb.Entry(employee).State = EntityState.Modified;
        //    _angularDb.SaveChanges();

        //}
    }
}
