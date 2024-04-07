using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class ReverseString
    {
        public static string ReverseStringMethod(string inputString)
        {
            
            int length;
            
            string reverseString = "";
            length = inputString.Length;
            Console.WriteLine("  String is length = {0}", length);
            for (int i = length; i > 0; i--)
            {
                reverseString += inputString[length - 1];
                length--;
            }
           // Console.WriteLine(" Reverse String is = {0}", reverseString);
            return reverseString;
        }

        static void ReverseArray(char[] array, int start, int end)
        {
            while (start < end)
            {
                char temp = array[start];
                array[start] = array[end];
                array[end] = temp;
                start++;
                end--;
            }
        }
    }
}
