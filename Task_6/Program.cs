using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Metrics;

namespace Task_6
{
    public class BankAccount
    {
        //Properties

        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }


        // Constructors
        public BankAccount()
        {

        }

        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }


        // Read-Only Property
        public bool IsOverdrawn
        {
            get
            {
                return Balance < 0;
            }
        }

        //Methods

        public void Deposit(double amount)
        {
            Balance += amount;
            SendEmail();
        }
        public void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient Balance");
            }

            SendEmail();
        }
        public double CheckBalance() {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Account Number: " + AccountNumber);
            Console.WriteLine("Holder Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        private void SendEmail()
        {

        }



    }


    public class Student
    {
        // Properties
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }

        private string email { get; set; }
        private int age { get; set; }

        private static int studentCount = 0;
        private int pin;

        // Constructor
        public Student()
        {
            studentCount++;
        }

        // Write-Only Property
        public int SecurityPIN
        {
            set
            {
                pin = value;
            }
        }

        // Methods
        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        public static int GetStudentCount()
        {
            return studentCount;
        }

        private void SendEmail()
        {

        }
    }


    public class Product
    {
        //Properties
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        //Methods
        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock.");
            }

            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return Price * StockQuantity;
        }

        private void PrintDetails()
        {
            Console.WriteLine("Product Name: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Stock Quantity: " + StockQuantity);
        }

        private void LogTransaction()
        {

        }

    }


    internal class Program
    {
        static BankAccount b1 = new BankAccount();
        static BankAccount b2 = new BankAccount();

        static Student s1 = new Student();
        static Student s2 = new Student();

        static Product p1 = new Product();
        static Product p2 = new Product();





        static void Main(string[] args)
        {
            // BankAccount 1
            b1.AccountNumber = 1163;
            b1.HolderName = "karim";
            b1.Balance = 120;

            // BankAccount 2
            b2.AccountNumber = 15203;
            b2.HolderName = "Ali";
            b2.Balance = 63;

            // Student 1
            s1.Name = "Ali";
            s1.Address = "Muscat";
            s1.Grade = 65;

            // Student 2
            s2.Name = "Ahmed";
            s2.Address = "Muscat";
            s2.Grade = 70;

            // Product 1
            p1.ProductName = "Wireless Mouse";
            p1.Price = 5.500;
            p1.StockQuantity = 50;

            // Product 2
            p2.ProductName = "Mechanical Keyboard";
            p2.Price = 15.750;
            p2.StockQuantity = 20;








            bool exit = false;

            while (exit == false)
            {
                Console.WriteLine("\n------- Menu -------");
                Console.WriteLine("1. View Account Details");
                Console.WriteLine("2. Update Student Address");
                Console.WriteLine("3. Make a Deposit");
                Console.WriteLine("4. Make a Withdrawal");
                Console.WriteLine("5. View Product Details");
                Console.WriteLine("6. Register a Student");
                Console.WriteLine("7. Compare Two Account Balances");
                Console.WriteLine("8. Restock Product & Stock Level Check");
                Console.WriteLine("9. Transfer Between Accounts");
                Console.WriteLine("10. Update Student Grade");
                Console.WriteLine("11. Student Report Card");
                Console.WriteLine("12. Account Health Status");
                Console.WriteLine("13. Bulk Sale With Revenue Calculation");
                Console.WriteLine("14. Scholarship Eligibility Check");
                Console.WriteLine("15. Full Balance Top-Up Flow");
                Console.WriteLine("16. Quick Account Opening");
                Console.WriteLine("17. Total Students Counter");
                Console.WriteLine("18. Overdrawn Account Check");
                Console.WriteLine("19. Set Student Security PIN");
                Console.WriteLine("20. Exit");

                Console.Write("\nChoose an option: ");

                int choice;

                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Invalid input");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        ViewAccountDetails();
                        break;

                    case 2:
                        UpdateStudentAddress();
                        break;

                    case 3:
                        MakeDeposit();
                        break;

                    case 4:
                        MakeWithdrawal();
                        break;

                    case 5:
                        ViewProductDetails();
                        break;

                    case 6:
                        RegisterStudent();
                        break;

                    case 7:
                        CompareTwoAccountBalances();
                        break;

                    case 8:
                        RestockProductAndStockLevelCheck();
                        break;

                    case 9:
                        TransferBetweenAccounts();
                        break;

                    case 10:
                        UpdateStudentGrade();
                        break;

                    case 11:
                        StudentReportCard();
                        break;

                    case 12:
                        AccountHealthStatus();
                        break;

                    case 13:
                        BulkSaleWithRevenueCalculation();
                        break;

                    case 14:
                        ScholarshipEligibilityCheck();
                        break;

                    case 15:
                        FullBalanceTopUpFlow();
                        break;

                    case 16:
                        QuickAccountOpening();
                        break;

                    case 17:
                        TotalStudentsCounter();
                        break;

                    case 18:
                        OverdrawnAccountCheck();
                        break;

                    case 19:
                        SetStudentSecurityPIN();
                        break;

                    case 20:
                        exit = true;
                        Console.WriteLine("Goodbye!");
                        break;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }




        static void ViewAccountDetails()
        {
            Console.WriteLine("Choose Account:");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                b1.CheckBalance();
            }
            else if (choice == 2)
            {
                b2.CheckBalance();
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void UpdateStudentAddress()
        {
            Console.WriteLine("Choose Student:");
            Console.WriteLine("1. Ali");
            Console.WriteLine("2. Ahmed");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter new address: ");
            string address = Console.ReadLine();

            if (choice == 1)
            {
                s1.Address = address;
                Console.WriteLine("New Address: " + s1.Address);
            }
            else if (choice == 2)
            {
                s2.Address = address;
                Console.WriteLine("New Address: " + s2.Address);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void MakeDeposit()
        {
            Console.WriteLine("Choose Account:");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter deposit amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (choice == 1)
            {
                b1.Deposit(amount);
                Console.WriteLine("Holder: " + b1.HolderName);
                Console.WriteLine("Balance: " + b1.Balance);
            }
            else if (choice == 2)
            {
                b2.Deposit(amount);
                Console.WriteLine("Holder: " + b2.HolderName);
                Console.WriteLine("Balance: " + b2.Balance);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void MakeWithdrawal()
        {
            Console.WriteLine("Choose Account:");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter withdrawal amount: ");
            double amount = double.Parse(Console.ReadLine());

            if (choice == 1)
            {
                b1.Withdraw(amount);
                Console.WriteLine("Balance: " + b1.Balance);
            }
            else if (choice == 2)
            {
                b2.Withdraw(amount);
                Console.WriteLine("Balance: " + b2.Balance);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void ViewProductDetails()
        {
            Console.WriteLine("Choose Product:");
            Console.WriteLine("1. Wireless Mouse");
            Console.WriteLine("2. Mechanical Keyboard");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Inventory Value: " + p1.GetInventoryValue());
            }
            else if (choice == 2)
            {
                Console.WriteLine("Inventory Value: " + p2.GetInventoryValue());
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void RegisterStudent()
        {
            Console.WriteLine("Choose Student:");
            Console.WriteLine("1. Ali");
            Console.WriteLine("2. Ahmed");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter Email: ");
            string email = Console.ReadLine();

            if (choice == 1)
            {
                s1.Register(email);
            }
            else if (choice == 2)
            {
                s2.Register(email);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Console.WriteLine("Student registered successfully.");
        }

        static void CompareTwoAccountBalances()
        {
            if (b1.Balance > b2.Balance)
            {
                Console.WriteLine(b1.HolderName + " has more money.");
            }
            else if (b2.Balance > b1.Balance)
            {
                Console.WriteLine(b2.HolderName + " has more money.");
            }
            else
            {
                Console.WriteLine("Both accounts have the same balance.");
            }
        }

        static void RestockProductAndStockLevelCheck()
        {
            Console.WriteLine("Choose Product:");
            Console.WriteLine("1. Wireless Mouse");
            Console.WriteLine("2. Mechanical Keyboard");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter quantity: ");
            int quantity = int.Parse(Console.ReadLine());

            Product product;

            if (choice == 1)
            {
                product = p1;
            }
            else if (choice == 2)
            {
                product = p2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            product.Restock(quantity);

            Console.WriteLine("Stock Quantity: " + product.StockQuantity);

            if (product.StockQuantity < 10)
            {
                Console.WriteLine("Low");
            }
            else if (product.StockQuantity < 50)
            {
                Console.WriteLine("Moderate");
            }
            else
            {
                Console.WriteLine("Well Stocked");
            }
        }

        static void TransferBetweenAccounts()
        {
            Console.WriteLine("Source Account");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int source = int.Parse(Console.ReadLine());

            Console.WriteLine("Destination Account");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int destination = int.Parse(Console.ReadLine());

            Console.Write("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());

            BankAccount from;
            BankAccount to;

            if (source == 1)
                from = b1;
            else
                from = b2;

            if (destination == 1)
                to = b1;
            else
                to = b2;

            if (from.Balance >= amount)
            {
                from.Withdraw(amount);
                to.Deposit(amount);

                Console.WriteLine("Transfer completed.");
            }
            else
            {
                Console.WriteLine("Transfer failed.");
            }
        }

        static void UpdateStudentGrade()
        {
            Console.WriteLine("Choose Student:");
            Console.WriteLine("1. Ali");
            Console.WriteLine("2. Ahmed");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter new grade: ");

            int grade;

            if (!int.TryParse(Console.ReadLine(), out grade))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Grade must be between 0 and 100.");
                return;
            }

            if (choice == 1)
            {
                s1.Grade = grade;
            }
            else if (choice == 2)
            {
                s2.Grade = grade;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Console.WriteLine("Grade updated successfully.");
        }

        static void StudentReportCard()
        {
            Console.WriteLine("Choose Student:");
            Console.WriteLine("1. Ali");
            Console.WriteLine("2. Ahmed");

            int choice = int.Parse(Console.ReadLine());

            Student student;

            if (choice == 1)
            {
                student = s1;
            }
            else if (choice == 2)
            {
                student = s2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Console.WriteLine("\n----- Report Card -----");
            Console.WriteLine("Name: " + student.Name);
            Console.WriteLine("Address: " + student.Address);
            Console.WriteLine("Grade: " + student.Grade);

            if (student.Grade >= 60)
            {
                Console.WriteLine("Status: Pass");
            }
            else
            {
                Console.WriteLine("Status: Fail");
            }
        }

        static void AccountHealthStatus()
        {
            Console.WriteLine("Choose Account:");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int choice = int.Parse(Console.ReadLine());

            BankAccount account;

            if (choice == 1)
            {
                account = b1;
            }
            else if (choice == 2)
            {
                account = b2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            if (account.Balance < 50)
            {
                Console.WriteLine("Low Balance");
            }
            else if (account.Balance <= 1000)
            {
                Console.WriteLine("Healthy");
            }
            else
            {
                Console.WriteLine("Premium");
            }
        }

        static void BulkSaleWithRevenueCalculation()
        {
            Console.WriteLine("Choose Product:");
            Console.WriteLine("1. Wireless Mouse");
            Console.WriteLine("2. Mechanical Keyboard");

            int choice = int.Parse(Console.ReadLine());

            Product product;

            if (choice == 1)
            {
                product = p1;
            }
            else if (choice == 2)
            {
                product = p2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Console.Write("Enter quantity to sell: ");
            int quantity = int.Parse(Console.ReadLine());

            if (product.StockQuantity < quantity)
            {
                Console.WriteLine("Need " + (quantity - product.StockQuantity) + " more units.");
            }
            else
            {
                product.Sell(quantity);

                double revenue = quantity * product.Price;

                Console.WriteLine("Revenue: " + revenue);
            }
        }

        static void ScholarshipEligibilityCheck()
        {
            Console.WriteLine("Choose Student:");
            Console.WriteLine("1. Ali");
            Console.WriteLine("2. Ahmed");

            int studentChoice = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose Account:");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int accountChoice = int.Parse(Console.ReadLine());

            Student student;
            BankAccount account;

            if (studentChoice == 1)
                student = s1;
            else
                student = s2;

            if (accountChoice == 1)
                account = b1;
            else
                account = b2;

            if (student.Grade >= 80 && account.Balance >= 100)
            {
                Console.WriteLine("Eligible");
            }
            else
            {
                if (student.Grade < 80)
                {
                    Console.WriteLine("Student grade is below 80.");
                }

                if (account.Balance < 100)
                {
                    Console.WriteLine("Account balance is below 100.");
                }
            }
        }

        static void FullBalanceTopUpFlow()
        {
            Console.WriteLine("Choose Account:");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int choice = int.Parse(Console.ReadLine());

            BankAccount account;

            if (choice == 1)
            {
                account = b1;
            }
            else if (choice == 2)
            {
                account = b2;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            if (account.Balance < 50)
            {
                double before = account.Balance;

                double amount = 100 - account.Balance;

                account.Deposit(amount);

                Console.WriteLine("Before: " + before);
                Console.WriteLine("After: " + account.Balance);
            }
            else
            {
                Console.WriteLine("No top-up needed.");
            }
        }


        static void QuickAccountOpening()
        {
            Console.Write("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter Holder Name: ");
            string holderName = Console.ReadLine();

            Console.Write("Enter Starting Balance: ");
            double balance = double.Parse(Console.ReadLine());

            BankAccount account = new BankAccount(accountNumber, holderName, balance);

            account.CheckBalance();
        }

        static void TotalStudentsCounter()
        {
            Console.WriteLine("Total Students = " + Student.GetStudentCount());
        }

        static void OverdrawnAccountCheck()
        {
            Console.WriteLine("Choose Account:");
            Console.WriteLine("1. Karim");
            Console.WriteLine("2. Ali");

            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                if (b1.IsOverdrawn)
                {
                    Console.WriteLine("Account is Overdrawn.");
                }
                else
                {
                    Console.WriteLine("Account is NOT Overdrawn.");
                }
            }
            else if (choice == 2)
            {
                if (b2.IsOverdrawn)
                {
                    Console.WriteLine("Account is Overdrawn.");
                }
                else
                {
                    Console.WriteLine("Account is NOT Overdrawn.");
                }
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }

        static void SetStudentSecurityPIN()
        {
            Console.WriteLine("Choose Student:");
            Console.WriteLine("1. Ali");
            Console.WriteLine("2. Ahmed");

            int choice = int.Parse(Console.ReadLine());

            Console.Write("Enter 4-digit PIN: ");
            int pin = int.Parse(Console.ReadLine());

            if (pin < 1000 || pin > 9999)
            {
                Console.WriteLine("PIN must be 4 digits.");
                return;
            }

            if (choice == 1)
            {
                s1.SecurityPIN = pin;
            }
            else if (choice == 2)
            {
                s2.SecurityPIN = pin;
            }
            else
            {
                Console.WriteLine("Invalid choice.");
                return;
            }

            Console.WriteLine("PIN set successfully.");
        }
    } 

}


        

       