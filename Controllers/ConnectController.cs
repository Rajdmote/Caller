using Connect.Models;
using Fluentx.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Connect.Controllers
{
    public class ConnectController : Controller
    {
        // GET: Connect
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// This action is to by pass for Profiler along with UserData
        /// </summary>
        /// <returns></returns>
        public ActionResult ByPassToProfiler() 
        {
            // User information which we will get after connect login session.
            UserInfo obj_UserInfo = new UserInfo();
            obj_UserInfo.UserId = 1;
            obj_UserInfo.Username = "Alex";
            obj_UserInfo.ticket = "xyzabceruhsndfhrvsxgs"; // This unique ticket key will provide security.
            obj_UserInfo.Company = "ccs";
            obj_UserInfo.COC_Number = 6620;


            // Wrapping into dictionary to pass profiler application so we can bypass login and coc steps.
            Dictionary<string, object> param = new Dictionary<string, object>();
            param.Add("UserId", obj_UserInfo.UserId);
            param.Add("Username", obj_UserInfo.Username);
            param.Add("ticket", obj_UserInfo.ticket); // This unique ticket key will provide security.
            param.Add("Company", obj_UserInfo.Company);
            param.Add("COC_Number", obj_UserInfo.COC_Number);

            // Using Fluent.mvc RedirectAndPost Method for redirection to profiler Application
            return this.RedirectAndPost("https://localhost:44396/Profiler/LoginFromConnect", param);
            //return View();
        }

       
    }
}