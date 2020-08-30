using System;

namespace BinarySort
{
    class Program
    {
        static int[] myNum = { 1, 7, 19, 32, 33, 48, 54, 65, 77, 89, 90, 91 };
        static void Main(string[] args)
        {
            for(int i = 0; i < 93; i++)
            {
                Console.WriteLine(BinarySort(i));
            }
        }
            
        static int BinarySort(int target)
        {
            int low = 0;
            int high = myNum.Length-1;
            int middle = (low + high) / 2;
            while (low < middle)
            {
                if (myNum[middle] == target)
                {
                    return middle;
                }
                else if (myNum[middle] < target)
                {
                    low = middle;
                }
                else if (myNum[middle] > target)
                {
                    high = middle;
                }
                else
                {
                    return -1;
                }
                middle = (low + high) / 2;
            }
            if (myNum[low] == target)
            {
                return low;
            }
            else if((myNum[high] == target)){
                return high;
            }
            return -1;
        }
    }
}
