namespace Task4_Solution
{
    internal class Program
    {
        //Task 1 
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name + "!");
            
        }

        // Task 2
        static int Square(int number)
        {
            return number * number;
        }

        static void Main(string[] args)
        {
            // Task 1
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();
            PrintWelcome(userName);


            // Task 2
            Console.Write("Enter a number: ");
            int num = int.Parse(Console.ReadLine());

            int result = Square(num);
            Console.WriteLine("The square is: " + result);
        }
    }
}
