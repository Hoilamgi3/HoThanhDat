using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HoThanhDat_Buoi2_MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {        
            int[] array = { 3, 9, 10, 27, 38, 43, 82 };
            int search = 43;                  
            Console.WriteLine("phan tu can tim: " + search);       
            int index = BinarySearch(array, search);         
            if (index != -1)
            {
                Console.WriteLine(search+ " duoc thay tai vi tri: " + index);
            }
            else
            {
                Console.WriteLine(search + " khong tim thay.");
            }
            Console.ReadLine();
        }
        public static int BinarySearch(int[] array, int search)
        {
            int left = 0;              
            int right = array.Length - 1; 
            while (left <= right)
            {              
                int mid = left + (right - left) / 2;
                if (array[mid] == search)
                {
                    return mid;
                }            
                if (array[mid] < search)
                {
                    left = mid + 1;
                }              
                else
                {
                    right = mid - 1;
                }
            }
            return -1; 
        }
    }
}
