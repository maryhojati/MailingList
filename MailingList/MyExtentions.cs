using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingList
{
    public static class MyExtentions
    {
        /// <summary>
        /// اولین ورودی جایگزین {0} می شود دومین جایگزین {1} و الی آخر . . .
        /// </summary>
        /// <param name="Str"></param>
        /// <param name="objs">ورودی ها</param>
        /// <returns></returns>
        public static string FormatReplace(this string Str, params object[] objs)
        {
            StringBuilder sb = new StringBuilder(Str);
            for(int i = 0;i < objs.Length;i++)
            {
                sb.Replace('{' + i.ToString() + '}', objs[i] == null ? "" : objs[i].ToString());
            }

            return sb.ToString();
        }

    }
}
