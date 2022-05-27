using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspfirst.Controllers
{
    public class HomeController:Controller
    {
        //public ContentResult Index()
        //{
        //    return Content("I'M INDEX PAGE");
        //}

        public ViewResult About()
        {
            var view = new ViewResult();
            view.ViewName = "About";
            return view;
        }

        public ViewResult Index()
        {
            //var views = new ViewResult();
            //views.ViewName = "Index";
            //return views;

            return View();
        }
    }
}
