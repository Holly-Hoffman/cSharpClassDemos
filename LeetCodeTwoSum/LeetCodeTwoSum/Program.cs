namespace LeetCodeTwoSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
       // }

        //public int[] TwoSum(int[] nums, int target)
        //{
            int[] nbrs = [3, 3];
            int[] idxs = TwoSum(nbrs, 6);
            Console.WriteLine($"idxs = {PrintIt(idxs)}");

        }

        public static string PrintIt(int[] nbrs)
        {
            string retStr = "";
            foreach (int nbr in nbrs)
            {
                retStr += nbr + " ";
            }
            return retStr;
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int[] idxs = [];
            for (int i = 0; i < nums.Length; i++)
            {
                if (idxs.Length > 0) { break; }
                for (int j = 0; j < nums.Length; j++)
                {
                    //if (j != i)
                    //{
                        if (nums[i] + nums[j] == target)
                        {
                            Console.WriteLine($"target: {i}:{nums[i]} + {j}: {nums[j]}");
                            idxs = [i, j];
                            if (j == i) { continue; }
                            break;
                        }
                    //}
                    
                }
            }
            return idxs;
        }
    }
}
