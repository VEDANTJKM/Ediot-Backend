namespace Dashboard.Models
{
    public class Login
    {
        public int UserId { get; set; }
        required
        public string email
        { get; set; }
        required
        public string Password
        { get; set; } // Avoid exposing raw passwords
        public string? Position { get; set; } // Add this
        public string? Username { get; set; } // Add this
    }
}
