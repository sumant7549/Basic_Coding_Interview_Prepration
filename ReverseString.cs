using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview_Prepartion_All_basic_Coding
{
    public class ReverseString
    {
        public string Reverse(string input)
        {
            char[] result = new char[input.Length];
            for (int i = input.Length-1, j= 0; i >= 0; i--,j++)
            {
                result[j] = input[i];
            }
            //Array.Reverse(charArray);
            return new string(result);
        }
    }
}
