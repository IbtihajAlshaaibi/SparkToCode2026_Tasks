namespace Task4_Solution
{
    internal class Program
    {
        //Task 1 
        //static void PrintWelcome(string name)
        //{
        //    Console.WriteLine("Welcome " + name + "!");

        //}


        // Task 2
        //static int Square(int number)
        //{
        //    return number * number;
        //}

        // Task 3
        //static double CelsiusToFahrenheit(double celsius)
        //{
        //    return (celsius * 9 / 5) + 32;
        //}

        // Task 4
        //static void DisplayMenu()
        //{
        //    Console.WriteLine("1. Start");
        //    Console.WriteLine("2. Help");
        //    Console.WriteLine("3. Exit");
        //}


        // Task 5
        //static bool IsEven(int number)
        //{
        //    return number % 2 == 0;
        //}

        // Task 6
        //static double CalculateArea(double length, double width)
        //{
        //    return length * width;
        //}


        //static double CalculatePerimeter(double length, double width)
        //{
        //    return 2 * (length + width);
        //}

        // Task 7
        //static string GetGradeLetter(int score)
        //{
        //    if (score >= 90)
        //    {
        //        return "A";
        //    }
        //    else if (score >= 80)
        //    {
        //        return "B";
        //    }
        //    else if (score >= 70)
        //    {
        //        return "C";
        //    }
        //    else if (score >= 60)
        //    {
        //        return "D";
        //    }
        //    else
        //    {
        //        return "F";
        //    }
        //}


        // Task 8
        //static void Countdown(int start)
        //{
        //    for (int i = start; i >= 1; i--)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}


        // Task 9

        // Multiply 2 int parameters
        //static int Multiply(int a, int b)
        //{
        //    return a * b;
        //}

        // Multiply 2 double parameters
        //static double Multiply(double a, double b)
        //{
        //    return a * b;
        //}

        // Multiply 3 int parameters
        //static int Multiply(int a, int b, int c)
        //{
        //    return a * b * c;
        //}


        // Task 10
        // Square 
        static double CalculateArea(double side)
        {
            return side * side;
        }

        // Rectangle 
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }










        static void Main(string[] args)
        {

            // Task 1
            //Console.Write("Enter your name: ");
            //string userName = Console.ReadLine();
            //PrintWelcome(userName);

            ////////////////////////////////////////////////////////////////////


            // Task 2
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //int result = Square(num);
            //Console.WriteLine("The square is: " + result);

            ////////////////////////////////////////////////////////////////////


            // Task 3
            //Console.Write("Enter temperature in Celsius: ");
            //double celsius = double.Parse(Console.ReadLine());

            //double fahrenheit = CelsiusToFahrenheit(celsius);

            //Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);


            ////////////////////////////////////////////////////////////////////


            // Task 4
            //DisplayMenu();


            ////////////////////////////////////////////////////////////////////


            // Task 5
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());

            //if (IsEven(num))
            //{
            //    Console.WriteLine("Even");
            //}
            //else
            //{
            //    Console.WriteLine("Odd");
            //}

            ////////////////////////////////////////////////////////////////////


            // Task 6
            //Console.Write("Enter the length: ");
            //double length = double.Parse(Console.ReadLine());

            //Console.Write("Enter the width: ");
            //double width = double.Parse(Console.ReadLine());

            //double area = CalculateArea(length, width);
            //double perimeter = CalculatePerimeter(length, width);

            //Console.WriteLine("Area = " + area);
            //Console.WriteLine("Perimeter = " + perimeter);



            ////////////////////////////////////////////////////////////////////


            // Task 7
            //Console.Write("Enter your score: ");
            //int score = int.Parse(Console.ReadLine());

            //string grade = GetGradeLetter(score);

            //Console.WriteLine("Grade: " + grade);


            ////////////////////////////////////////////////////////////////////


            // Task 8
            //Console.Write("Enter starting number: ");
            //int number = int.Parse(Console.ReadLine());

            //Countdown(number);


            ////////////////////////////////////////////////////////////////////


            // Task 9
            //int result1 = Multiply(3, 4);
            //Console.WriteLine( result1);

            //double result2 = Multiply(2.5, 4.0);
            //Console.WriteLine( result2);

            //int result3 = Multiply(2, 3, 4);
            //Console.WriteLine( result3);



            ////////////////////////////////////////////////////////////////////


            // Task 10
            Console.WriteLine("Choose shape:");
            Console.WriteLine("1) Square");
            Console.WriteLine("2) Rectangle");
            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.Write("Enter side: ");
                double side = double.Parse(Console.ReadLine());

                double area = CalculateArea(side);
                Console.WriteLine("Square Area = " + area);
            }
            else if (choice == 2)
            {
                Console.Write("Enter length: ");
                double length = double.Parse(Console.ReadLine());

                Console.Write("Enter width: ");
                double width = double.Parse(Console.ReadLine());

                double area = CalculateArea(length, width);
                Console.WriteLine("Rectangle Area = " + area);
            }
            else
            {
                Console.WriteLine("Invalid choice");
            }







        }
    }
}
