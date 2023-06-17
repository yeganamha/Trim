using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskTrim
{
    public static class TrimMethods
    {
        public static void Trim(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    string[] TrimedArr = new string[] { };

                    for (int j = 0; j < TrimedArr.Length; j++)
                    {
                        Console.WriteLine(TrimedArr);
                    }
                }
               
                
            }
            
            
        }

    }
}
