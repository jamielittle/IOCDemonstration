using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IOCDemonstration.Interfaces;

namespace IOCDemonstration
{
    public class UserRegistration : IUserRegistration
    {
        private ICRMUserRegistration _crmUserRegistration = null;
        private IUserEmailSender _usermiEmailSender = null;
        private IMembershipEmailSender _membershipEmailSender = null;

        public UserRegistration(ICRMUserRegistration crmUserRegistration, IUserEmailSender userEmailSender,
            IMembershipEmailSender membershipEmailSender)
        {
            _crmUserRegistration = crmUserRegistration;
            _usermiEmailSender = userEmailSender;
            _membershipEmailSender = membershipEmailSender;
        }

        public bool RegisterUser(UserInformation userInfo)
        {
            // Register information with a CRM
            _crmUserRegistration.RegisterUser(userInfo);

            // Send user email to signify successful registration
            _usermiEmailSender.SendEmail(userInfo);

            // Send email to membership department
            _membershipEmailSender.SendEmail(userInfo);

            return true;
        }
    }
}
