using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using YemekKalori.Domain.Enums;

namespace YemekKalori.Domain.Entities
{
    public class User : BaseClass
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DietType Diet {  get; set; }
        public decimal Weight { get; set; }
        public decimal Height { get; set; }
        public string Username { get; set; }
        public AccountStatus Status { get; set; }
        public GoalType Goal { get; set; }
        private string _hashedPassword;

        public string Password
        {
            
            set { _hashedPassword = HashPassword(value); }
        }

        public bool VerifyPassword(string password)
        {
            return HashPassword(password) == _hashedPassword;
        }

        private string HashPassword(string password)
        {
            using (var sha256 = SHA256.Create())
            {
                var hashedBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                return BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            }
        }



    }
}
