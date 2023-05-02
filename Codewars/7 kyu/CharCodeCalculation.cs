public static Int32 Calc(String s)
  {
            string total1 = "";
            for (int i = 0; i < s.Length; i++)
            {
                total1 += (int)s[i];
            }

            string total2 = "";
            for (int i = 0; i < total1.Length; i++)
            {
                if (total1[i] == '7') total2 += '1';
                else total2 += total1[i];
            }

            int sumOfTotal1 = 0;
            int sumOfTotal2 = 0;
            for (int i = 0; i < total1.Length; i++)
            {
                sumOfTotal1 += Int32.Parse(total1[i].ToString());
                sumOfTotal2 += Int32.Parse(total2[i].ToString());
            }
            return sumOfTotal1 - sumOfTotal2;
  }