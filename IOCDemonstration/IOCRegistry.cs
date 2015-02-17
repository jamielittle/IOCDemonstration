using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using IOCDemonstration.Interfaces;
using StructureMap;
using StructureMap.Configuration.DSL;

namespace IOCDemonstration
{
    public class IOCRegistry : Registry
    {
        public IOCRegistry()
        {
            For<ICRMUserRegistration>().Use<CRMUserRegistration>();
            For<IMembershipEmailSender>().Use<MembershipEmailSender>();
            For<ISMTPService>().Use<SMTPService>();
            For<IUserEmailSender>().Use<UserEmailSender>();
            For<IUserRegistration>().Use<UserRegistration>();
        }
    }
}
