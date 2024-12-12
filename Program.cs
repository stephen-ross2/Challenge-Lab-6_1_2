namespace Challenge_Lab_6_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] nums = { 3, 0, 1 };
            int missing = MissingNumber(nums);
            Console.WriteLine("The missing number is: " + missing);
        }

        static int MissingNumber(int[] nums)
        {
            Dictionary<int, bool> dict = new Dictionary<int, bool>();
            foreach (int num in nums)
            {
                dict[num] = true;
            }

            
            int n = nums.Length;
            for (int i = 0; i <= n; i++)
            {
                if (!dict.ContainsKey(i))
                {
                    return i; 
                }
            }

            return -1;
        }
    }

}
 
