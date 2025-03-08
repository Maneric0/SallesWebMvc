using Microsoft.AspNetCore.Mvc;
using SallesWebMvc.Models;
using System.Collections.Generic;

namespace SallesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {
            List<Department> list = new List<Department>();
            list.Add(new Department { id = 1, Name = "Eletronics" });
            list.Add(new Department { id = 2, Name = "Fashion" });
            
            return View(list);
        }
    }
}
