using BLL.Services.EmployeeServices;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UI.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly IEmployeeServices emp;

        public EmployeeController(IEmployeeServices emp)
        {
            this.emp = emp;
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(EmployeeVM model)
        {
            if (ModelState.IsValid)
            {
                var check = emp.Add(model);
                if (check == 1)
                {
                    ViewBag.Success = 1;
                }
            }

            return View();
        }
    }
}
