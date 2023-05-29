public class Number
{
        public static int DigitalRoot(long n)
        {
            string num = n.ToString();
            while (num.Length != 1)
            {
                num = Sum(num);
            }
            return int.Parse(num);
        }

        public static string Sum(string n)
        {
            int sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                sum += int.Parse(n[i].ToString());
            }
            return sum.ToString();
        }
}