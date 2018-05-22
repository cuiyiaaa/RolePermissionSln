using Cy.RolePermission.IBLL;
using Cy.RolePermission.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cy.RolePermission.WebApp.Controllers
{
    public class HomeController : Controller
    {
        public IUserInfoService UserInfoService { get; set; }
        public ActionResult Index()
        {
            UserInfo user = UserInfoService.GetAllEntity(u => u.Name == "admin").FirstOrDefault();
            ViewBag.Msg = user.Name;
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {

            return View();
        }
    }
}