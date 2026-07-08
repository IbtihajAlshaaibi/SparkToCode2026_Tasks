namespace Task5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1 - Fixed Grades Array
            //int[] grades = new int[5];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write("Enter grade " + (i + 1) + ": ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //Console.WriteLine("Student Grades:");

            //foreach (int grade in grades)
            //{
            //    Console.WriteLine(grade);
            //}


            /////////////////////////////////////////////////////////////////////////////////

            // Task 2 - Dynamic To-Do List

            //List<string> todoList = new List<string>();

            //for (int i = 0; i < 5; i++)
            //{
            //    Console.Write("Enter task " + (i + 1) + ": ");
            //    todoList.Add(Console.ReadLine());
            //}

            //Console.WriteLine("To-Do List:");

            //foreach (string task in todoList)
            //{
            //    Console.WriteLine("- " + task);
            //}

            /////////////////////////////////////////////////////////////////////////////////

            // Task 3 - Browsing History Stack

            //Stack<string> browserHistory = new Stack<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter website " + (i + 1) + ": ");
            //    browserHistory.Push(Console.ReadLine());
            //}

            //browserHistory.Pop();

            //Console.WriteLine("You are now on: " + browserHistory.Peek());


            /////////////////////////////////////////////////////////////////////////////////

            // Task 4 - Customer Service Queue

            Queue<string> customers = new Queue<string>();

            for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter customer " + (i + 1) + ": ");
                customers.Enqueue(Console.ReadLine());
            }

            string servedCustomer = customers.Dequeue();

            Console.WriteLine("Served customer: " + servedCustomer);

        }
    }
}
