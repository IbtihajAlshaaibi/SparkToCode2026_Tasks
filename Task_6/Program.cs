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

        //Methods

        public void Deposit(double amount) { }
        public void Withdraw(double amount) { }
        public double CheckBalance() {
            return 0;
        }

        private void PrintInformation()
        {

        }

        private void SendEmail()
        {

        }



    }


    public class Student
    {
        //Properties
        public int Grade { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        private string email { get; set; }
        private int age { get; set; }

        //Methods
        public void Register(string Email) { }

        private void SendEmail() { }

    }


    public class Product
    {
        //Properties
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }

        //Methods
        public void Sell(int quantity) { }
        public void Restock(int quantity) { }
        public double GetInventoryValue() 
        { return 0; }

        private void PrintDetails() { }
        private void LogTransaction() { }

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


            static void ViewAccountDetails()
            {

            }

            static void UpdateStudentAddress()
            {

            }

            static void MakeDeposit()
            {

            }

            static void MakeWithdrawal()
            {

            }

            static void ViewProductDetails()
            {

            }

            static void RegisterStudent()
            {

            }

            static void CompareTwoAccountBalances()
            {

            }

            static void RestockProductAndStockLevelCheck()
            {

            }

            static void TransferBetweenAccounts()
            {

            }

            static void UpdateStudentGrade()
            {

            }

            static void StudentReportCard()
            {

            }

            static void AccountHealthStatus()
            {

            }

            static void BulkSaleWithRevenueCalculation()
            {

            }

            static void ScholarshipEligibilityCheck()
            {

            }

            static void FullBalanceTopUpFlow()
            {

            }

            static void QuickAccountOpening()
            {

            }

            static void TotalStudentsCounter()
            {

            }

            static void OverdrawnAccountCheck()
            {

            }

            static void SetStudentSecurityPIN()
            {

            }



            


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
    }
}
