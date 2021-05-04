using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerCommLib
{
    public class CustomerComm
    {
        IMailSender _mailSender;

        public CustomerComm(IMailSender mailSender)
        {
            _mailSender = mailSender;
        }

        public bool SendMailToCustomer(string mail,string msg)
        {
            //Actual logic goes here 
            //define message and mail address 
           

            _mailSender.SendMail(mail,msg);

            return true;
        }
    }
}
