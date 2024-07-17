using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoThanhDat_Nhansonguyenlon
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "12345";
            string num2 = "98765";
            string result = Nhan(num1, num2);
            Console.WriteLine("Result of {num1} * {num2} = {result}", num1, num2, result);
            Console.ReadLine();
        }
        public static string Nhan(string num1, string num2)
        {
            char[] charNum1 = num1.ToCharArray();
            char[] charNum2 = num2.ToCharArray();
            Array.Reverse(charNum1);
            Array.Reverse(charNum2);
            int m = charNum1.Length;
            int n = charNum2.Length;
            int[] result = new int[m + n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i + j] += (charNum1[i] - '0') * (charNum2[j] - '0');
                    result[i + j + 1] += result[i + j] / 10;
                    result[i + j] %= 10;
                }
            }
            int index = m + n - 1;
            while (index > 0 && result[index] == 0)
            {
                index--;
            }
            string multiplyResult = "";
            for (int k = index; k >= 0; k--)
            {
                multiplyResult += result[k];
            }

            return multiplyResult;
        }
       
    }
}
