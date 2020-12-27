using DIgital_Diary.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIgital_Diary.BusinessLayer
{
    class UserService
    {
        UserAccess userAccess;
        public UserService()
        {
            this.userAccess = new UserAccess();
        }
        public bool LoginValidation(string username, string password)
        {
            return userAccess.LoginValidation(username, password);
        }
    }
}
