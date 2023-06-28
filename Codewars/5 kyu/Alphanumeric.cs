public class Kata
{
    public static bool Alphanumeric(string str)
    {
        if (str == "") return false;
        for (int i = 0; i < str.Length; i++)
        {
            if (IsLetter(str[i]) == false && IsNumber(str[i]) == false)
            {
                return false;
            }
        }
        return true;
    }

    public static bool IsNumber(char symbol)
    {
        const int NUMBER_MIN = 48;
        const int NUMBER_MAX = 57;

        if ((byte)symbol >= NUMBER_MIN && (byte)symbol <= NUMBER_MAX)
        {
            return true;
        }

        return false;
    }

    public static bool IsLetter(char symbol)
    {
        const int LOWERCASE_MIN = 97;
        const int LOWERCASE_MAX = 122;

        const int UPPERCASE_MIN = 65;
        const int UPPERCASE_MAX = 90;

        if ((byte)symbol >= LOWERCASE_MIN && (byte)symbol <= LOWERCASE_MAX)
        {
            return true;
        }
        else if ((byte)symbol >= UPPERCASE_MIN && (byte)symbol <= UPPERCASE_MAX)
        {
            return true;
        }
        return false;
    }
}
