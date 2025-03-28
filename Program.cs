using System.Diagnostics.CodeAnalysis;

namespace Arrays_brown_Jaylen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //asks a whole number and takes what the user answers with and makes it the array size
            Console.WriteLine("enter a whole number for the amount of number you want type");
            int arraySize = Convert.ToInt32(Console.ReadLine());
            //make an array
            int[] nums = new int[arraySize];
            //makes a int varable
            int sum = 0;
            //asks for numbers for the array and takes them and adds them togther and it repets as much as the size the user typed earlyer
            for(int i=0; i< arraySize; i++)
            {
                Console.WriteLine("add another whole number");
                nums[i] =  Convert.ToInt32(Console.ReadLine());
                sum += nums[i];
            }
            //tells the user the sum of the numbers typed
            Console.WriteLine($"The sum of the numbers typed is {sum}\n");
            //sorts the array
            Array.Sort( nums );
            //tells the user the order
            Console.WriteLine("the order of the numbers from smallest to biggest is");
            //puts the arrays in order by printing them over in over one by one in order
            foreach (int number in nums) 
            {
            //prints the numbers
            Console.WriteLine(number);
            }
        }
    }
}
