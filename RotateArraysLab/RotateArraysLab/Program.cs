using System.Reflection;

namespace RotateArraysLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shifty shifty numbers");
            int[] nums1 = {1,2,3};
            Console.Write("\nFirst set rotated is: ");
            int[] rot1 = RotateLeft3(nums1);
            foreach (int x in rot1)
            {
                Console.Write(x + " ");
            }

            int[] nums2 = { 5, 11, 9 };
            Console.Write("\n\nsecond set rotated is: ");
            int[] rot2 = RotateLeft3(nums2);
            foreach (int y in rot2)
            {
                Console.Write(y + " ");
            }

            int[] nums3 = { 7, 0, 0 };
            Console.Write("\n\nthird set rotated is: ");
            int[] rot3 = RotateLeft3(nums3);
            foreach (int z in rot3)
            {
                Console.Write(z + " ");
            }
        }

        public static int[] RotateLeft3(int[] nums) 
        {
            //first int
            int i = nums[0];

            int[] shiftedNums = new int[nums.Length];
            Array.Copy(nums, 1, shiftedNums, 0, nums.Length-1);
            shiftedNums[shiftedNums.Length - 1] = i;

            
            return shiftedNums;
        }
    }
}
