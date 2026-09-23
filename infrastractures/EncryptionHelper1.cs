using System;
using System.Collections.Generic;
using System.Security;
using System.Text;

namespace infrastractures
{
    public class EncryptionHelper1
    {
        public static string Encryption(string text)
        {var hash=BCrypt.Net.BCrypt.HashPassword(text);
            return hash;

        }
        public static bool verify(string password,string hashpassword)
        {
        var iscorrect = BCrypt.Net.BCrypt.Verify(password , hashpassword);
            return iscorrect;
        }

    }
}
