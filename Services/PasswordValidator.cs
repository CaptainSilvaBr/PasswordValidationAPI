using System;
using System.Linq;

public class PasswordValidator
{
    public bool IsValidPassword(string password)
    {
        // Verifica se a senha é nula ou vazia
        if (string.IsNullOrEmpty(password))
            return false;

        // Verifica o tamanho da senha
        if (password.Length < 9)
            return false;

        // Verifica se há pelo menos 1 número, 1 letra maiúscula, 1 letra minúscula e 1 caractere especial
        var hasNumber = password.Any(char.IsDigit);
        var hasUpper = password.Any(char.IsUpper);
        var hasLower = password.Any(char.IsLower);
        var hasSpecialChar = password.Any(c => "!@#$%^&*()-+".Contains(c));

        if (!hasNumber || !hasUpper || !hasLower || !hasSpecialChar)
            return false;

        // Verifica se não há caracteres repetidos
        if (password.Distinct().Count() != password.Length)
            return false;

        return true;
    }
}
