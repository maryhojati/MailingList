using System;

namespace MailingList.Model
{
    public class Email
    {
        public int EmailId { get; set; }

        public string Sender { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public byte[] Attachment { get; set; } = null;

        public DateTime CreateDate { get; set; }

        public DateTime SendDate { get; set; }
    }
}
