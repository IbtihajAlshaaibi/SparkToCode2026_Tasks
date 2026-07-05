namespace Task3_Solution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 - Absolute Difference

            //Console.WriteLine("Enter the first number:");
            //float firstNumber = float.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the second number:");
            //float secondNumber = float.Parse(Console.ReadLine());

            //float difference = firstNumber - secondNumber;

            //float positiveDifference = Math.Abs(difference);

            //Console.WriteLine("Positive Difference: " + positiveDifference);

            //////////////////////////////////////////////////////////////////////////////////////

            // Task 2 - Power & Root Explorer

            //Console.WriteLine("Enter a number:");
            //float number = float.Parse(Console.ReadLine());

            //double square = Math.Pow(number, 2);

            //double squareRoot = Math.Sqrt(number);

            //Console.WriteLine("Square: " + square);
            //Console.WriteLine("Square Root: " + squareRoot);

            //////////////////////////////////////////////////////////////////////////////////////

            //Task 3 - Name Formatter

            Console.WriteLine("Enter your full name:");
            string fullName = Console.ReadLine();

            string upperName = fullName.ToUpper();

            string lowerName = fullName.ToLower();

            int characters = fullName.Length;

            Console.WriteLine("Uppercase: " + upperName);
            Console.WriteLine("Lowercase: " + lowerName);
            Console.WriteLine("Number of Characters: " + characters);

        }
    }
}
