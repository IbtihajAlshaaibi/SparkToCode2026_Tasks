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

            //Console.WriteLine("Enter a decimal number:");
            //double number = double.Parse(Console.ReadLine());

            //double rounded = Math.Round(number);
            //double roundedUp = Math.Ceiling(number);
            //double roundedDown = Math.Floor(number);

            //Console.WriteLine("Nearest Whole Number: " + rounded);
            //Console.WriteLine("Always Rounded Up: " + roundedUp);
            //Console.WriteLine("Always Rounded Down: " + roundedDown);


            //////////////////////////////////////////////////////////////////////////////////////

            // Task 10 - Word Position Finder

            //Console.WriteLine("Enter a sentence:");
            //string sentence = Console.ReadLine();

            //Console.WriteLine("Enter a word to search:");
            //string word = Console.ReadLine();

            //if (sentence.Contains(word))
            //{
            //    int firstPosition = sentence.IndexOf(word);
            //    int lastPosition = sentence.LastIndexOf(word);

            //    Console.WriteLine("First Position: " + firstPosition);
            //    Console.WriteLine("Last Position: " + lastPosition);
            //}
            //else
            //{
            //    Console.WriteLine("Word not found.");
            //}


            //////////////////////////////////////////////////////////////////////////////////////

            // Task 11 - One-Time Password (OTP) Generator

            //Random random = new Random();
            //int otp = random.Next(1000, 10000);

            //Console.WriteLine("OTP Code: " + otp);

            //for (int i = 1; i <= 3; i++)
            //{
            //    try
            //    {
            //        Console.WriteLine("Enter the OTP:");
            //        int userOTP = int.Parse(Console.ReadLine());

            //        if (userOTP == otp)
            //        {
            //            Console.WriteLine("Verified");
            //            break;
            //        }
            //        else
            //        {
            //            Console.WriteLine("Incorrect OTP");
            //        }

            //        if (i == 3)
            //        {
            //            Console.WriteLine("Verification Failed");
            //        }
            //    }
            //    catch
            //    {
            //        Console.WriteLine("Invalid Input");

            //        if (i == 3)
            //        {
            //            Console.WriteLine("Verification Failed");
            //        }
            //    }
            //}


            //////////////////////////////////////////////////////////////////////////////////////

            // Task 12 - Birthday Insights

            try
            {
                Console.WriteLine("Enter your date of birth (yyyy-MM-dd):");
                DateTime birthDate = DateTime.Parse(Console.ReadLine());

                DateTime today = DateTime.Today;

                int age = today.Year - birthDate.Year;

                if (today.Month < birthDate.Month ||
                    (today.Month == birthDate.Month && today.Day < birthDate.Day))
                {
                    age--;
                }

                Console.WriteLine("Age: " + age);
                Console.WriteLine("Day of Birth: " + birthDate.DayOfWeek);
            }
            catch
            {
                Console.WriteLine("Invalid Input");
            }









        }
    }
}
