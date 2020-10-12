namespace SOLID.I_SRP
{
    internal class User
    {
        public string Uasername { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
    }

    class EmailValidator
    {
        public static bool ValidateEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
    }
}
