using Cy.RolePermission.Common;
using Cy.RolePermission.IBLL;
using Cy.RolePermission.Model;
using Cy.RolePermission.Model.ViewModel;
using System;
using System.Web;
using System.Web.Mvc;

namespace Cy.RolePermission.WebApp.Controllers
{
    public class LoginController : Controller
    {
        private IUserInfoService UserInfoService { get; set; }
        // GET: Login
        public ActionResult Index()
        {
            #region 
            //校验Cookie
            //if (CheckCookie())
            //{
            //   return RedirectToAction("Index","Home");
            //}
            //else
            //{
            //    return View();
            //} 
            #endregion
            CheckCookie();
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]//使用防伪造令牌来避免CSRE攻击
        public ActionResult Index(LogOnModel model)
        {
            #region 验证验证码
            if (model.ValidateCode == null)
            {
                Session["code"] = null;
                return Content("请输入验证码");
            }
            if (Session["code"] != null && !string.Equals(model.ValidateCode, Session["code"].ToString(), StringComparison.OrdinalIgnoreCase))
            {
                //ModelState.AddModelError("Error_Login", "验证码错误");
                Session["code"] = null;
                return Content("验证码错误");
            }
            #endregion
            if (ModelState.IsValid)
            {
                UserInfo userInfo = UserInfoService.ValidateUser(model.UserName, Encryption.GetMd5String(model.PassWord));
                //登录成功
                if (userInfo != null)
                {
                    //将用户信息写入Session
                    Session["UserInfo"] = userInfo;

                    //用户选择了记住我,将用户信息写入Cookie
                    if (model.RememberMe)
                    {
                        HttpCookie ck1 = new HttpCookie("cp1", model.UserName);
                        HttpCookie ck2 = new HttpCookie("cp2", Encryption.GetMd5String(model.PassWord));
                        ck1.Expires = DateTime.Now.AddDays(7);
                        ck2.Expires = DateTime.Now.AddDays(7);
                        Response.Cookies.Add(ck1);
                        Response.Cookies.Add(ck2);
                    }
                    return Content("ok");
                }
                return Content("用户名或密码错误!!!");
            }
            return Content("请输入用户名和密码");
        }

        /// <summary>
        /// 生成验证码图片
        /// </summary>
        /// <returns></returns>
        public ActionResult ShowValidateCode()
        {
            ValidateCode validateCode = new ValidateCode();
            string code = validateCode.CreateValidateCode(4);
            //将验证码存入Session中
            Session["code"] = code;
            byte[] buffer = validateCode.CreateValidateGraphic(code);
            return File(buffer, "image/jpeg");
        }

        /// <summary>
        /// 校验cookie
        /// </summary>
        private void CheckCookie()
        {
            if (Request.Cookies["cp1"] != null && Request.Cookies["cp2"] != null)
            {
                string userName = Request.Cookies["cp1"].Value;
                string passWord = Request.Cookies["cp2"].Value;
                UserInfo userInfo = UserInfoService.ValidateUser(userName, passWord);
                if (userInfo != null)
                {
                    //cookie信息正确
                    Response.Redirect("/Home/Index");
                    //RedirectToAction("Index","Home");
                }
                else
                {
                    //cookie信息错误,清除cookie
                    Response.Cookies["cp1"].Expires = DateTime.Now.AddDays(-1);
                    Response.Cookies["cp2"].Expires = DateTime.Now.AddDays(-1);

                }
            }

        }
    }
}