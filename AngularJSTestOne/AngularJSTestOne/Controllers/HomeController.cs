using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Anjular.Service;
using AnjularJS.ViewModel;

namespace AngularJSTestOne.Controllers
{
    public class HomeController : Controller
    {
         private readonly IEmployeeService _employeeService;

         public HomeController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        public ActionResult Index()
        {
            var indexModel = new IndexViewModel
            {
                Employees = _employeeService.QueryAllStaffs()
            };
            return View("Index", indexModel);

        }

    }
}