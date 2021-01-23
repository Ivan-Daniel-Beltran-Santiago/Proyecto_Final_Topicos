using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    class SSupportMail : MasterMailS
    {
        public SSupportMail()
        {
            senderMail = "@mail";
            passw = "@pass";
            host = "smtp.gmail.com";
            port = 587;
            ssl = true;
            initializeStmlClient();
        }
    }
}
