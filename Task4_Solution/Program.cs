namespace Task4_Solution
{
    internal class Program
    {
        //Task 1 - Personalized Welcome Function
        static void PrintWelcome(string name)
        {
            Console.WriteLine("Welcome " + name + "!");
            
        }
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string userName = Console.ReadLine();


            PrintWelcome(userName);
        }
    }
}
