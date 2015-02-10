using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOCDemonstration.Interfaces;

namespace IOCDemonstration
{
    public class MembershipEmailSender : IMembershipEmailSender
    {

        private ISMTPService _smtpService = null;

        public MembershipEmailSender(ISMTPService smtpService)
        {
            _smtpService = smtpService;
        }

        public void SendEmail(UserInformation userInfo)
        {
            Email mail = new Email();
            _smtpService.SendEmail(mail);
        }
    }
}
