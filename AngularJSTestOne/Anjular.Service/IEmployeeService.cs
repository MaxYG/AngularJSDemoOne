using System.Collections.Generic;
using AnjularJS.ViewModel;

namespace Anjular.Service
{
    public interface IEmployeeService
    {
        List<IndexViewModel.Employee> QueryAllStaffs();
        //void Add(IndexViewModel.Staff vmStaff);
        //IndexViewModel.Staff FindInfo(int id);
        //void Edit(IndexViewModel.Staff staff);
        //void Edit(StaffEditModel staff, HttpPostedFileBase headPic, HttpPostedFileBase headAtt);
        //void Lock(int id);
        //List<IndexViewModel.Staff> Search(string name);
    }
}