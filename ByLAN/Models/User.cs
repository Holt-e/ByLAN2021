using System;

namespace ByLAN.Models
{
    public class User
    {
        public String Username { get; set; }

        public String Hashedpassword { get; set; }

        public Boolean Admin { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}