using System.Collections.Generic;

namespace AngularJS.Data
{
    public interface IDbAccess
    {
        IEnumerable<Employee> QueryAllEmployees();
        void Add(Employee staff);
        //Employee FindInfo(int id);
        //void Edit(Employee staff);
        
    }
}