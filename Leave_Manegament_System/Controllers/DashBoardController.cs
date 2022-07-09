using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Leave_Manegament_System.Controllers
{
    public class DashBoardController : Controller
    {
        public IActionResult HomeDash()
        {
            return View();
        }
        public IActionResult EmployeeDetail()
        {
            return View();
        }

        public IActionResult ManagerDetail(string a)
        {
            return View();
        }

        public IActionResult MyLeaveApplication()
        {
            return View();
        }
        public IActionResult NewLeaave()
        {
            return View();
        }
    }
}
