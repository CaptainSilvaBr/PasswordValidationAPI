using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace PasswordValidationAPI
{
    public static class PasswordValidator
    {
        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            if (password.Length < 9)
                return false;

            if (!password.Any(char.IsDigit))
                return false;

            if (!password.Any(char.IsLower))
                return false;

            if (!password.Any(char.IsUpper))
                return false;

            if (!Regex.IsMatch(password, @"[!@#$%^&*()\-\+]"))
                return false;

            if (password.Distinct().Count() != password.Length)
                return false;

            return true;
        }
    }
}
