using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfLogin.Context;

namespace WpfLogin.Controller
{
    public class UserController
    {
        public static void AddUser()
        {
            using (var ObjContext = new MyContext())
            {
                var User = new User
                {
                    userName = "Joshua",
                    Address = "Tanjung Duren"
                };
                ObjContext.Teachers.Add(Teacher);
                ObjContext.SaveChanges();
            }
        }
    }
}
