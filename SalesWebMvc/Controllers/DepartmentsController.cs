﻿using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department {Id = 1, Name = "Tecnology" });
            list.Add(new Department {Id = 2, Name = "Developing" });
            return View(list);
        }
    }
}
