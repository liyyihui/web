using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using web.Models;

namespace web.Controllers
{
    public class LoginController : BaseController
    {
        // GET: Login
        public ActionResult mlogin()
        {
            return View();
        }
        // 登陆
        public String logincheck(string name, string password)
        {
            //List<user> userinfo = modeldb.user.Where(x => x.name == name && x.pas == password).ToList();
            user oneuserinfo = modeldb.user.FirstOrDefault(x => x.name == name && x.pas == password) ?? new user();
            if (oneuserinfo.Id == 0)
            {
                //没有用户信息
                return "登陆失败";
            }
            else
            {
                return "登陆成功";
            }
        }
        public JsonResult logincheckjson(string name, string password)
        {
            LoginMsg msg ;
            //List<user> userinfo = modeldb.user.Where(x => x.name == name && x.pas == password).ToList();
            user oneuserinfo = modeldb.user.FirstOrDefault(x => x.name == name && x.pas == password) ?? new user();
            if (oneuserinfo.Id == 0)
            {
                //没有用户信息
                msg = new LoginMsg(-1,"登陆失败");
                return ToJson(msg);
            }
            else
            {
                msg = new LoginMsg(1,"登陆成功");
                return ToJson(msg);
            }
        }
        public  HttpResponseMessage ToJson(Object obj)
        {
            String str;
            if (obj is String || obj is Char)
            {
                str = obj.ToString();
            }
            else
            {
                str = JsonConvert.SerializeObject(obj);
            }
            var result = new HttpResponseMessage { Content = new StringContent(str, Encoding.GetEncoding("UTF-8"), "application/json") };
            return result;
        }
    }
}