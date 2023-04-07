using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using System.Text.RegularExpressions;
using System.Net;
using System.Numerics;
namespace Webblog.helper
{
    public static class utility
    {
        public static int Page_size = 20;
        public static async Task<string> UPloadfile(Microsoft.AspNetCore.Http.IFormFile file,string sdirectory,string newname = null)
        {
            try
            {
                if (newname == null) newname = file.FileName;
                string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", sdirectory,newname);
                string path2 = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", sdirectory);
                if (!System.IO.Directory.Exists(path2)){
                    System.IO.Directory.CreateDirectory(path2);
                }
                var supportedtypes = new[] { "jpg", "jpeg", "png", "gif" };
                var fileext = System.IO.Path.GetExtension(file.FileName).Substring(1);
                if (!supportedtypes.Contains(fileext.ToLower()))
                {
                    return null;
                }
                else
                {
                    using(var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                    return newname;
                }
            }
            catch
            {
                return null;
            }
        }
        public static string seourl(string url)
        {

            url = url.ToLower();
            url = Regex.Replace(url, @"[áàạãảấầậẩẫắằặẵẳ]", "a");
            url = Regex.Replace(url, @"[ẻéèẽẹểếềễệ]", "e");
            url = Regex.Replace(url, @"[óỏòõọổồỗốộởờỡớợ]", "o");
            url = Regex.Replace(url, @"[úùủũụứửừựữ]", "u");
            url = Regex.Replace(url, @"[íìịĩỉ]", "i");
            url = Regex.Replace(url, @"[ýỷỹỵỳ]", "y");
            url = Regex.Replace(url, @"[đ]", "d");
            url = Regex.Replace(url.Trim(), @"[^0-9a-z-\s]", "").Trim();
            url = Regex.Replace(url.Trim(), @"\s+", "-");
            url = Regex.Replace(url.Trim(), @"\s", "-");
            while (true)
            {
                if (url.IndexOf("--") != -1)
                {
                    url = url.Replace("--", ("-"));
                }else
                {
                    break;
                }
            }
            return url;
        }
        public static string getrandomkey(int length = 5)
        {
            string pattern = @"123456789zxcvbnmasdfghjklqwertyuiop[]{}:~!@#$%^&*()+";
            Random rd = new Random();
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < length; i++)
            {
                sb.Append(pattern[rd.Next(0, pattern.Length)]);
            }
            return sb.ToString();
        }
    }
}
