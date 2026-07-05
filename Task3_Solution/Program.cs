namespace Task3_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference

            Console.WriteLine("Enter the first number:");
            float firstNumber = float.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            float secondNumber = float.Parse(Console.ReadLine());

            float difference = firstNumber - secondNumber;

            float positiveDifference = Math.Abs(difference);

            Console.WriteLine("Positive Difference: " + positiveDifference);
        }
    }
}
