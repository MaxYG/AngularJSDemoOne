using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnjularJS.ViewModel
{
    public class IndexViewModel
    {
        public IndexViewModel()
        {
            Employees = new List<Employee>();
        }
        public List<Employee> Employees { get; set; }

        public class Employee
        {
            public int Id { get; set; }

            public string Name { get; set; }
            public DateTime? BirthDay { get; set; }
            public string School { get; set; }
            public string Address { get; set; }
            public string WorkExperience { get; set; }
            public string SelfAssessment { get; set; }
            public bool Lock { get; set; }
            public string Picture { get; set; }
            public string Attachment { get; set; }
        }
    }
}
