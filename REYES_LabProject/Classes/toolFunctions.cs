using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;

namespace REYES_LabProject
{
    internal class toolFunctions
    {
        public static string CalculateMD5Hash(string input)
        {
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to a hexadecimal string
                StringBuilder hashStringBuilder = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    hashStringBuilder.Append(hashBytes[i].ToString("x2"));
                }

                return hashStringBuilder.ToString();
            }
        }

        public static bool IsStrongPassword(string input)
        {
            // Use regular expressions to check for the required criteria
            // At least one capital letter, one small letter, one digit, and one of ?!_
            bool hasCapital = Regex.IsMatch(input, "[A-Z]");
            bool hasSmall = Regex.IsMatch(input, "[a-z]");
            bool hasDigit = Regex.IsMatch(input, @"\d");
            bool hasSpecialChar = Regex.IsMatch(input, "[?!_#]");

            // Check if all criteria are met
            return hasCapital && hasSmall && hasDigit && hasSpecialChar;
        }
    }
}
