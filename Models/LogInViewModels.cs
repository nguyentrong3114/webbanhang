using System.ComponentModel.DataAnnotations;

namespace MyMvcApi.Models
{
    public class LogInViewModel
    {
        [Required(ErrorMessage = "Email không được để trống.")]
        [EmailAddress(ErrorMessage = "Email không hợp lệ.")]
        [StringLength(50, MinimumLength = 6, ErrorMessage = "Email phải có độ dài từ 6 đến 50 ký tự.")]
        public required string Email { get; set; }

        [Required(ErrorMessage = "Mật khẩu không được để trống.")]
        [DataType(DataType.Password)]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Mật khẩu phải có độ dài từ 6 đến 20 ký tự.")]
        public required string Password { get; set; }

        public bool RememberMe { get; set; }
    }
}
