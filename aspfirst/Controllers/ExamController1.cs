using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspfirst.Controllers
{
    public class ExamController1 : Controller
    {
        public IActionResult Result(int ? studentID , int year)
        {
            return Content(studentID.ToString() + " - " + year.ToString());

            //return View();
        }

        public ActionResult Detail(int id)
        {
            return Content(id.ToString());

        }
    }
}
