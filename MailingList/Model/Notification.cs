using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingList.Model
{
    public class Notification
    {
        public int NotifId { get; set; }
        public string Body { get; set; }

        public string Subject { get; set; }

        public DateTime date { get; set; }

        public string Receiver { get; set; }

        public DateTime SeenDate { get; set; }
    }
}
