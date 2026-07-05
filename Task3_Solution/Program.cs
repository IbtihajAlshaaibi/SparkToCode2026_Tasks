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

            //Console.WriteLine("Enter your full name:");
            //string fullName = Console.ReadLine();

            //string upperName = fullName.ToUpper();

            //string lowerName = fullName.ToLower();

            //int characters = fullName.Length;

            //Console.WriteLine("Uppercase: " + upperName);
            //Console.WriteLine("Lowercase: " + lowerName);
            //Console.WriteLine("Number of Characters: " + characters);

            //////////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Subscription End Date

            //Console.WriteLine("Enter the number of free trial days:");
            //int days = int.Parse(Console.ReadLine());

            //DateTime startDate = DateTime.Today;
            //DateTime endDate = startDate.AddDays(days);

            //Console.WriteLine("Trial End Date: " + endDate.ToString("yyyy-MM-dd"));

            //////////////////////////////////////////////////////////////////////////////////////

            // Task 5 - Grade Rounding System

            //Console.WriteLine("Enter your exam score:");
            //double score = double.Parse(Console.ReadLine());

            //double roundedScore = Math.Round(score);

            //Console.WriteLine("Rounded Score: " + roundedScore);

            //if (roundedScore >= 60)
            //{
            //    Console.WriteLine("Result: Pass");
            //}
            //else
            //{
            //    Console.WriteLine("Result: Fail");
            //}

            //////////////////////////////////////////////////////////////////////////////////////

            // Task 6 - Password Strength Checker

            //Console.WriteLine("Enter your password:");
            //string password = Console.ReadLine();

            //if (password.Length >= 8 && !password.ToLower().Contains("password"))
            //{
            //    Console.WriteLine("Strong Password");
            //}
            //else
            //{
            //    Console.WriteLine("Weak Password");

            //    if (password.Length < 8)
            //    {
            //        Console.WriteLine("Reason: Password must be at least 8 characters");
            //    }

            //    if (password.ToLower().Contains("password"))
            //    {
            //        Console.WriteLine("Reason: Password must not contain the word 'password'");
            //    }
            //}

            //////////////////////////////////////////////////////////////////////////////////////

            // Task 7 - Clean Name Comparator

            //Console.WriteLine("Enter the first name:");
            //string name1 = Console.ReadLine();

            //Console.WriteLine("Enter the second name:");
            //string name2 = Console.ReadLine();

            //if (name1.Trim().ToUpper() == name2.Trim().ToUpper())
            //{
            //    Console.WriteLine("Match");
            //}
            //else
            //{
            //    Console.WriteLine("No Match");
            //}

            //////////////////////////////////////////////////////////////////////////////////////

            // Task 8 - Membership Expiry Checker

            try
            {
                Console.WriteLine("Enter membership start date (yyyy-MM-dd):");
                DateTime startDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Enter the number of membership days:");
                int days = int.Parse(Console.ReadLine());

                DateTime expiryDate = startDate.AddDays(days);

                if (expiryDate >= DateTime.Today)
                {
                    Console.WriteLine("Active");
                }
                else
                {
                    Console.WriteLine("Expired");
                }

                Console.WriteLine("Expiry Date: " + expiryDate.ToString("yyyy-MM-dd"));
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }

            //////////////////////////////////////////////////////////////////////////////////////

            // Task 9 - Round Up / Round Down Explorer



        }
    }
}
