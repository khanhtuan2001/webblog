using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Webblog.Areas.Admin.Models
{
    public class LoginViewModel
    {
        [Key]
        [MaxLength(50)]
        [Required(ErrorMessage = "vui lòng nhập lại email")]
        [Display(Name = "địa chỉ email")]
        [DataType(DataType.EmailAddress)]
        [EmailAddress(ErrorMessage = "vui lòng nhập email")]
        public string Email { get; set; }
        

        [Display(Name ="mat khau")]
        [Required(ErrorMessage ="vui lòng nhập lại mật khẩu")]
        [MaxLength(30,ErrorMessage ="mật khẩu chi tối đa 30 kí tự")]
        public string Password { get; set; }
    }
}
