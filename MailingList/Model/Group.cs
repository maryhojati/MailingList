using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingList.Model
{
    public class Group
    {
        public int GroupId { get; set; }

        public string GroupName { get; set; }

        public string Admin { get; set; }

        public DateTime CreateDate { get; set; }

        public bool IamAdmin { get; set; }
        public override string ToString()
        {
            var result = GroupName;
            if (IamAdmin)
                result += "(Admin)";
            return result;
        }
    }
}
