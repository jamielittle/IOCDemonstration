using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOCDemonstration.Interfaces;
using StructureMap;

namespace IOCDemonstration
{
    public class RegistrationControler
    {
        public void RegisterUser(UserInformation info)
        {
            // Without IOC Container
            IUserRegistration registration = new UserRegistration(new CRMUserRegistration(), 
                new UserEmailSender(new SMTPService()),
                new MembershipEmailSender(new SMTPService()));

            // With IOC Container (container walks down dependency chain to avoid the complexity of the above)
            Container container = new Container();
            IUserRegistration userRegistration = container.GetInstance<IUserRegistration>();
        }
    }
}
