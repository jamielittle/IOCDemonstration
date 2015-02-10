using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCDemonstration.Interfaces
{
    public interface IUserRegistration
    {
        bool RegisterUser(UserInformation userInfo);
    }
}
