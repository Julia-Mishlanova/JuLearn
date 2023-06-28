using System.Text;

namespace Solution
{
    class FileNameExtractor
    {
        public static string ExtractFileName(string dirtFileName)
        {
            var cleanFileName = new StringBuilder();
            int i = 0;

            while (char.IsDigit(dirtFileName[i]))
            {
                i++;
            }
            if (!char.IsLetter(dirtFileName[i])) i++;

            int dotCounter = 0;
            for (int j = i; j < dirtFileName.Length; j++)
            {
                if (dirtFileName[j] == '.' && dotCounter >= 1) break;
                if (dirtFileName[j] == '.' && dotCounter < 1) dotCounter++;

                cleanFileName.Append(dirtFileName[j]);
            }
            return cleanFileName.ToString();
        }
    }
}