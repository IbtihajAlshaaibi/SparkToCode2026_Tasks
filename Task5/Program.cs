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

            //Queue<string> customers = new Queue<string>();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter customer " + (i + 1) + ": ");
            //    customers.Enqueue(Console.ReadLine());
            //}

            //string servedCustomer = customers.Dequeue();

            //Console.WriteLine("Served customer: " + servedCustomer);


            /////////////////////////////////////////////////////////////////////////////////
            // Task 5 - Array Grade Range

            //int[] grades = new int[5];

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    Console.Write("Enter grade " + (i + 1) + ": ");
            //    grades[i] = int.Parse(Console.ReadLine());
            //}

            //Array.Sort(grades);

            //int sum = 0;

            //for (int i = 0; i < grades.Length; i++)
            //{
            //    sum += grades[i];
            //}

            //double average = (double)sum / grades.Length;

            //Console.WriteLine("Results:");
            //Console.WriteLine("Lowest Grade: " + grades[0]);
            //Console.WriteLine("Highest Grade: " + grades[grades.Length - 1]);
            //Console.WriteLine("Average Grade: " + average);

            /////////////////////////////////////////////////////////////////////////////////

            //Task 6 - Filtered Shopping List

            //List<string> shoppingList = new List<string>();

            //string item = "";

            //while (item != "done")
            //{
            //    Console.Write("Enter an item (or type 'done' to finish): ");
            //    item = Console.ReadLine();

            //    if (item != "done")
            //    {
            //        shoppingList.Add(item);
            //    }
            //}

            //Console.WriteLine("Shopping List:");

            //foreach (string product in shoppingList)
            //{
            //    Console.WriteLine(product);
            //}

            //Console.Write("Enter item to remove: ");
            //string removeItem = Console.ReadLine();

            //shoppingList.Remove(removeItem);

            //Console.WriteLine("Shopping List After Removal:");

            //foreach (string product in shoppingList)
            //{
            //    Console.WriteLine(product);
            //}

            /////////////////////////////////////////////////////////////////////////////////

            // Task 7 - High Score Podium

            List<int> scores = new List<int>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter score " + (i + 1) + ": ");
                scores.Add(int.Parse(Console.ReadLine()));
            }

            scores.Sort();
            scores.Reverse();

            Console.WriteLine("Top 3 Scores:");
            Console.WriteLine("1st place: " + scores[0]);
            Console.WriteLine("2nd place: " + scores[1]);
            Console.WriteLine("3rd place: " + scores[2]);


        }
    }
}
