using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje2Form.Controllers
{
    static class UserController
    {
        public static Models.User GetUserById(int ID)
        {
            return Database.GetUserByID(Convert.ToInt32(ID));
        }

        public static int CreateUser(string name, string surname)
        {
            return Database.RegisterUser(name, surname);
        }

        public static void UserUpdate(int ID, string name, string surname)
        {
            Database.UserUpdate(ID, name, surname);
        }
    }
}
