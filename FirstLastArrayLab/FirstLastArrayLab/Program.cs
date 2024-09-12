namespace FirstLastArrayLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First Last 6 Time!\n");


            int[] nums1 = new int[3];
            Console.Write("First set: 1, 2, 6: ");
            Console.WriteLine(FirstLast6([1,2,6]));
            int[] nums2 = new int[4];
            Console.Write("First set: 6, 1, 2, 3: ");
            Console.WriteLine(FirstLast6([6,1,2,3]));
            int[] nums3 = new int[5];
            Console.Write("First set: 13, 6, 1, 2, 3: ");
            Console.WriteLine(FirstLast6([13,6,1,2,3]));
        }
        public static bool FirstLast6(int[] nums)
        {
            bool isSix = true;

            if (nums[0] == 6)
            {
                isSix = true;

            }
            else if (nums[nums.Length - 1] == 6)
            {
                isSix = true;
            }
            else
            { 
                isSix = false; 
            }

            return isSix;
        }
    }

}
