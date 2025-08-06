namespace skywalkAssessment.model
{
    public class Users
    {
        // John Doe,john@example.com,2022-01-12,2023-02-05,free
        // name,email,signup_date,last_login,plan
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public DateTime SignupDate { get; set; }
        public DateTime LastLogin { get; set; }
        public string Plan { get; set; } = string.Empty;

    }
}
