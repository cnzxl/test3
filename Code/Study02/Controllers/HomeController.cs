using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Study02.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {

            return View();
        }

        public ActionResult Index2()
        {

            return View();
        }

        //来自分支1的控制器方法
        public ActionResult Index3()
        {

            return View();
        }

    }
}
