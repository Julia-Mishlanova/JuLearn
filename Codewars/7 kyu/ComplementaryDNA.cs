using System.Collections.Generic;

public class DnaStrand 
{
        public static string MakeComplement(string dna)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            var key = "ATGC";
            var value = "TACG";

            for (int i = 0; i < key.Length; i++)
            {
                dict.Add(key[i].ToString(), value[i].ToString());
            }

            var complement = string.Empty;
            for (int i = 0; i < dna.Length; i++)
            {
                if (dict.ContainsKey(dna[i].ToString())) complement += dict[dna[i].ToString()];
            }
            return complement;
        }
}