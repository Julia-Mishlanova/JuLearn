using System;
using System.Linq;

public static class Kata
{
    public static bool ValidPhoneNumber(string phoneNumber)
    {
        if (phoneNumber.Length != 14) return false;

        if (
            phoneNumber[0] != '('
            || phoneNumber[4] != ')'
            || phoneNumber[5] != ' '
            || phoneNumber[9] != '-'
        )
            return false;

        bool hasLetters = phoneNumber.Any(x => char.IsLetter(x));
        if (hasLetters == true) return false;

        return true;
    }
}
