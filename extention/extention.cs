using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Webblog.extention
{
    public static class extention
    {
        public static string tovnd(this double dongia)
        {
            return dongia.ToString("#,##0") + " d";
        }
        public static string toUrlFriendly(this string url)
        {
            var result = url.ToLower().Trim();
            result = Regex.Replace(result, "áàạãảấầậẩẫắằặẵẳ", "a");
            result = Regex.Replace(result, "ẻéèẽẹểếềễệ", "e");
            result = Regex.Replace(result, "óỏòõọổồỗốộởờỡớợ", "o");
            result = Regex.Replace(result, "úùủũụứửừựữ", "u");
            result = Regex.Replace(result, "íìịĩỉ", "i");
            result = Regex.Replace(result, "ýỷỹỵỳ", "y");
            result = Regex.Replace(result, "đ", "d");
            result = Regex.Replace(result, "[^a-z0-9-]", "");
            result = Regex.Replace(result, "(-)+", "-");
            return result;
        }
    }
}
