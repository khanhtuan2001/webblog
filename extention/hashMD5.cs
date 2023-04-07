using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Webblog.extention
{
    public static class hashMD5
    {
        public static string tomd5(this string str)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] bhash = md5.ComputeHash(Encoding.UTF8.GetBytes(str));
            StringBuilder sbhash = new StringBuilder();
            foreach (byte b in bhash)
                sbhash.Append(string.Format("{0:x2}", b));
            return sbhash.ToString();
        }
    }
}
