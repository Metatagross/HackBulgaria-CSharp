using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketSystem
{
    public class PasswordManager
    {
        public static PasswordWithSalt HashPassword(string password)
        {
            return new PasswordWithSalt(password , GenerateSalt());
        }
        private static string GenerateSalt()
        {
            return "ala";
        }
    }
    public class PasswordWithSalt
    {
        public PasswordWithSalt(string password, string salt)
        {

        }
        public string Password { get; set; }
        public string Salt { get; set; }
    }
}
