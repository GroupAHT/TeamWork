using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ThuenhatroAPI.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }
        [Required(ErrorMessage = "Họ không được để trống!")]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Tên không được để trống!")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Tài khoản không được để trống!")]
        [StringLength(50, MinimumLength = 5, ErrorMessage = "Tài khoản từ 5 đến  50 ký tự")]
        [DataType(DataType.Text)]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mật khẩu không đuọc để trống!")]
        [StringLength(20, MinimumLength = 8, ErrorMessage = "Mật khẩu từ 8 đến  20 ký tự")]
        [DataType(DataType.Text)]
        public string PassWord { get; set; }
        public bool IsAdmin { get; set; }
        public bool Status { get; set; }
        public string MembershipCode { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
