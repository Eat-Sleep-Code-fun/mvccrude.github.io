using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdminWeb.Models
{
    
    public class AuthUser
    {
        //Create private database entity for this class
        private MyDBEntities db = new MyDBEntities();
        

        //Check user crendetail with LINQU
        public User CheckUserLogin(string Email,string Password)
        {
            var data = db.Users.Where(a => a.UEmailID == Email && a.UPassword == Password ).FirstOrDefault();
            return data;
        }

    
    }
}