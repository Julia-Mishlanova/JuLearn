using System.Collections.Generic;
using System.Linq;

    public static class Kata
    {
        public static object[] RemoveEveryOther(object[] arr)
        {
            bool flag = true;
            var objectList = new List <object>();
            
            for (int i = 0; i < arr.Length; i++)
            {
                if (flag == true)
                {
                    objectList.Add(arr[i]);
                    flag = false;
                }
                else if (flag == false)
                {
                    flag = true;
                }
            }
            return objectList.ToArray();
        }
    }