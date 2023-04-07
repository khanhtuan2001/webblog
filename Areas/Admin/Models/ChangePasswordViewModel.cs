using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webblog.Areas.Admin.Models
{
    public class ChangePasswordViewModel
    {
        [Key]
        public int AccountId { get; set; }
        [Display(Name = "mật khẩu hiện tại")]
        public string PasswordNow { get; set; }
        [Display(Name = "mật khẩu mới")]
        [Required(ErrorMessage = "vui lòng nhập mật khẩu")]
        [MinLength(5, ErrorMessage = "bạn cần đặt mật khẩu tối thiểu 5 ký tự")]
        public string Password { get; set; }
        [MinLength(5, ErrorMessage = "bạn cần đặt mật khẩu tối thiểu 5 ký tự")]
        [Display(Name = "nhập lại mật khẩu mới")]
        [Compare("Password",ErrorMessage ="mat khau khong giong nhau")]
        public string ConfirmPassword { get; set; }
    }
}
