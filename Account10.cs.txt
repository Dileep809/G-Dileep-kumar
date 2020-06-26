using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Assignment
{
    class Account10
    {
        public int accountno;
        public string customerName;
        public string accountType; //static variable
        public double amount;//static variable
        public double balance;

        public Account10(int ac, string cn, string actype, double am, double bl)
        {
            accountno = ac;
            customerName = cn;
            accountType = actype;
            amount = am;
            balance = bl;
        }
        public double credit(double amount)
        {
            double newBalance = balance + amount;
            return balance = newBalance;
        }

        public double deposite(double amount)
        {
            double newBalance = balance - amount;
            return balance = newBalance;
        }

        public void showData()
        {
            Console.WriteLine("AccountNo: " + accountno);
            Console.WriteLine("Customer name: " + customerName);
            Console.WriteLine("Account type: " + accountType);
            Console.WriteLine("Amount: " + amount);
            Console.WriteLine("balanace: " + balance);
        }

    }

    class Account_Test
    {
        static void Main()
        {
            Account10 ac = new Account10(321015224, "Maina", "Saving", 1000000, 800000);
            ac.showData();

            Console.WriteLine("Enter transaction type");
            string trans;
            string s1 = "Deposit";
            trans = Console.ReadLine();
            if (trans.Equals(s1))
            {
                Console.WriteLine(ac.credit(45000));

            }
            else
            {
                Console.WriteLine(ac.deposite(20000));
            }
            Console.ReadKey();

        } 
    }
}

    

