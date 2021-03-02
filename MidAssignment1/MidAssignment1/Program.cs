using System;

namespace MidAssignment1
{
    class Program
    {

        static int AccountNumberGen(int inc)
        {
            int AccNumStart = 500;
            int accNum = AccNumStart + inc;
            return accNum;
        }
        static void Main(string[] args)
        {
            bool flag = true;
            int numOfAcc;

            Account acc = new Account();
            Console.WriteLine("Number of accounts do you want to create? ");
            numOfAcc = Convert.ToInt32(Console.ReadLine());
            Bank bankAcc = new Bank("My Bank", numOfAcc);


            while (flag)
            {
                int choice;
                Console.WriteLine("1) Create Account \n2) Deposit \n3) Transfer \n4) Withdraw \n5) Delete \n6) Print \n7) Exit");
                Console.Write("Select 1 if you don't have any account: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Select wrong option, please select between 1-7");
                    continue;
                }
                switch (choice)
                {
                    case 1:

                        for (int i = 0; i < numOfAcc; i++)
                        {
                            Console.WriteLine("\nAccount Number: " + AccountNumberGen(i));
                            Console.Write("Name: ");
                            string name = Console.ReadLine();
                            Console.Write("Ammount: ");
                            double ammount = Convert.ToInt32(Console.ReadLine());
                            Console.Write("House no: ");
                            int houseNo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Road no: ");
                            int roadNo = Convert.ToInt32(Console.ReadLine());
                            Console.Write("City: ");
                            string city = Console.ReadLine();
                            Console.Write("Country: ");
                            string country = Console.ReadLine();
                            bankAcc.AddAccount(new Account(name, ammount, AccountNumberGen(i), new Address(houseNo, roadNo, city, country)));
                            Console.WriteLine("Account: " + (i + 1) + " Created Successfully!");
                        }
                        break;
                    case 2:
                        Console.Write("\nDeposit ammount: ");
                        double dep = Convert.ToInt32(Console.ReadLine());
                        acc.Deposit(dep);
                        break;
                    case 3:
                        Console.Write("\nTransfer ammount: ");
                        double trans = Convert.ToInt32(Console.ReadLine());
                        acc.Transfer(trans);
                        break;
                    case 4:
                        Console.Write("\nWithdraw ammount: ");
                        double withd = Convert.ToInt32(Console.ReadLine());
                        acc.Withdraw(withd);
                        break;
                    case 5:

                        Console.Write("Account Number: ");
                        int delAcc = Convert.ToInt32(Console.ReadLine());
                        bankAcc.DeleteAccount(delAcc);
                        break;
                    case 6:
                        bankAcc.PrintAllAccounts();
                        break;
                    case 7:
                        flag = false;
                        break;
                    default:
                        Console.WriteLine("\nSelect between 1-7\n");
                        continue;
                }

            }

        }

    }
}

