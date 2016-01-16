using Pz.Weixin.Config.Api.Model.Result;
using Pz.Weixin.Logic.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Pz.Weixin.Test.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            GetAllSubScriptUserOpenIdResult result = UserHelper.GetAllUserOpenIds();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}