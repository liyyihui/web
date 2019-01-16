using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web.Models
{
     
    public class LoginMsg
    {
        int code;
        string msg;

        public LoginMsg(int code,string msg) {
            this.code = code;
            this.msg = msg;
        }
     
    }
}