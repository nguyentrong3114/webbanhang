namespace MyFirstAspNetCoreApp.Models // Thay thế "YourNamespace" bằng namespace thực tế của bạn
{
    public class User
    {
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; } // Chứa mật khẩu chưa hash, nếu bạn chưa dùng hash
    }
}
