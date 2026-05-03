namespace Next_Largest_Number_to_the_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> Input = new List<int> { 5, 2, 4, 6, 1 };
            List<int> Input = new List<int> { 1,1,2,3,2,3,2,4 };

            List<int> result = next_largest_number_to_the_right(Input);
            Console.WriteLine(string.Join(", ", result));
        }

        static List<int> next_largest_number_to_the_right(List<int> nums)
        {
            List<int> result = new List<int>(new int[nums.Count]);
            Stack<int> stack = new Stack<int>();

            for (int i = nums.Count - 1; i >= 0; i--)
            {
                while (stack.Count > 0 && stack.Peek() <= nums[i])
                {
                    stack.Pop();
                }

                result[i] = stack.Count == 0 ? -1 : stack.Peek();
                stack.Push(nums[i]);
            }

            return result;
        }
    }
}
