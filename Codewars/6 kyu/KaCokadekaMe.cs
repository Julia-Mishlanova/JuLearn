using System.Text;

public class Kata
{
    public static string KaCokadekaMe(string word)
    {
        StringBuilder sb = new StringBuilder("ka" + word[0]);

        for (int i = 1; i < word.Length; i++)
        {
            if (IsVowel(word[i - 1]) && !IsVowel(word[i]))
            {
                sb.Append("ka");
            }
            sb.Append(word[i]);
        }
        return sb.ToString();
    }

    public static bool IsVowel(char letter)
    {
        char lowLetter = char.ToLower(letter);
        char[] vowels = new char[] { 'a', 'i', 'u', 'o', 'e' };

        foreach (var vowel in vowels)
        {
            if (lowLetter == vowel) return true;
        }
        return false;
    }
}
