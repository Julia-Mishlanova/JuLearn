class Kata
{
    public static int StrCount(string str, string letter)
    {
        //Do Some Magic
            int count = 0;
            var ch = char.Parse(letter);
            char[] word = str.ToCharArray();

            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == ch)
                {
                    count =count + 1;
                }
            }
            return count;
    }
}