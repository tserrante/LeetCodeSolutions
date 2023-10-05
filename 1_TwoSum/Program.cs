using System.Xml.Linq;

namespace TwoSum;

public class Program
{
    static void Main()
    {
       int[] answer = SolutionTwo_TwoSum(new int[]{1,2,3,4}, 7);

       foreach(int num in answer)
       {
            Console.WriteLine(num);
       }
    }

    static int[] SolutionOne_TwoSum(int[] nums, int target) {
        for(int i = 0; i < (nums.Length-1); i++)
        {
            for(int j = i + 1; j < nums.Length; j++)
            {
                if(nums[i] + nums[j] == target)
                {
                    return new int[] {i,j};
                }
            }
        }
        throw new ArgumentException("No solution found");
    }
    static int[] SolutionTwo_TwoSum(int[] numbers, int target) {
        var solutionsAndIndex = new Dictionary<int,int>(numbers.Length);

        for (int i = 0; i < numbers.Length; i++) {
            // Is the current number a solution to a previously seen one?
            if (solutionsAndIndex.ContainsKey(numbers[i])) {
                // if dictionary contains 'a', return the value (index of b) and the current index 'i' 
                // the index of the solution 
                return new int[] { i, solutionsAndIndex[numbers[i]]};
            }

            // Skip if we already encountered this solution/number
            // a+b = c -> a = c-b
            // save the solution a as a Key, and store the index of 'b' as its value
            var solution = target - numbers[i];
            
            if (!solutionsAndIndex.ContainsKey(solution)) {
                solutionsAndIndex.Add(solution, i);
            }
        }
        return default; // Given problem constraints we should never reach this, but compiler must be satisfied.
    }
}
