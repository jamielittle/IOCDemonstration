using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IOCDemonstration.Interfaces;
using StructureMap;

namespace IOCDemonstration
{
    public static class RegisterIOCContainer
    {
        public static void RegisterIOC()
        {
            var container = new Container();
            container.Configure(x =>
            {
                x.For<ICRMUserRegistration>().Use<CRMUserRegistration>();
                x.For<IMembershipEmailSender>().Use<MembershipEmailSender>();
                x.For<ISMTPService>().Use<SMTPService>();
                x.For<IUserEmailSender>().Use<UserEmailSender>();
                x.For<IUserRegistration>().Use<UserRegistration>();
            });
        }
    }
}
