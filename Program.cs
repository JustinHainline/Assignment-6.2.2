namespace Assignment_6._2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 5, 5, 5};
            int[] answer = ProductExceptSelf(nums);

            foreach (var item in answer)
            {
                Console.WriteLine(item);
            }
        }
        
        static int[] ProductExceptSelf(int[] nums)
        {
            int n = nums.Length;
            int[] leftProducts = new int[n];
            int[] rightProducts = new int[n];
            int[] result = new int[n];

            // compute prefix products
            int leftProduct = 1;
            for (int i = 0; i < n; i++)
            {
                leftProducts[i] = leftProduct;
                leftProduct *= nums[i];
            }

            // compute suffix products
            int rightProduct = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                rightProducts[i] = rightProduct;
                rightProduct *= nums[i];
            }

            // compute the final result
            for (int i = 0; i < n; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }
            return result;
        }
    }
}
