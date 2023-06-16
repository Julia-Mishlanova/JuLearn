public class Kata
{
    public static char FindMissingLetter(char[] arr)
    {
        char[] array = arr;
        bool beUpper = false;
        if (char.IsUpper(arr[0]))
        {
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = char.ToLower(arr[i]);
            }
            beUpper = true;
        }

        string newAlphabet = GetAlphabet(array[0]);
        char miss = '?';
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] != newAlphabet[i])
            {
                miss = newAlphabet[i];
                break;
            }
        }
        return beUpper ? char.ToUpper(miss) : miss;
    }

    public static string GetAlphabet(char firstCh)
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        string result = string.Empty;
        for (int i = 0; i < alphabet.Length; i++)
        {
            if (alphabet[i] >= firstCh) result += alphabet[i];
        }
        return result;
    }
}
