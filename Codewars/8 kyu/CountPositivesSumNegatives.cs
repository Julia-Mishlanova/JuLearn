public static int[] CountPositivesSumNegatives(int[] input)
    {
            if (input == null) return new int[] {};
            if (input.Length == 0) return new int[] {};
            
            int pos = 0;
            int neg = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > 0)
                {
                     pos+=1;
                  
                }
                else if (input[i] < 0)
                {
                    neg += input[i];
                }
                
            }
            int[] arr = { pos, neg };
            return arr;
    }