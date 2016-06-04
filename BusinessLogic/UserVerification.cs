using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObjects;
using DataAccess;

namespace BusinessLogic
{
    public class UserVerification
    {
        private DataAccess.UserVerification verificator = new DataAccess.UserVerification();

        public bool verifyPassword(string cedula, string password)
        {
            return verificator.userVerification(cedula, password);
        }
        

    }
}
