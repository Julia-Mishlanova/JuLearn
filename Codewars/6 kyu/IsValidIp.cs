using System;

namespace Solution
{
    class Kata
    {
        public static bool IsValidIp(string ipAddres)
        {
            var octets = ipAddres.Split('.');
            if (octets.Length != 4) return false;
            
            foreach (var octet in octets)
            {
                int checkNum;
                bool isNumber = Int32.TryParse(octet, out checkNum) || false;

                if (!isNumber) return false;
                if (octet == "") return false;

                if (octet[0] == '0' && octet.Length > 1) return false;
                if (octet.Trim().Length != octet.Length) return false;
                if (int.Parse(octet) > 255 || int.Parse(octet) < 0) return false;
            }
          return true;
        }
    }
}