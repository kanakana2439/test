using System;

namespace test1
{

    public class BankAccount
    {
        public string m_customerName{set;get;}

        public double m_balance{set;get;}
        

        private bool m_frozen = false;

        private BankAccount()
        {

        }

        public BankAccount(String customerName,double balance)
        {
            this.m_customerName =customerName;
            this.m_balance = balance;
        }

        public void Debit(double amount)
        {
            if(m_frozen)
            {
                throw new Exception("Account frozen");
            }

            if(amount > m_balance)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }

            m_balance += amount;
        }
        public void Credit(double amount)
        {
            if(m_frozen)
            {
                 throw new Exception("Account frozen");
            }

            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException("amount");
            }
            m_balance += amount;
        }

        private void FreexeAccount()
        {
            m_frozen = true;
        }

        private void UnfreezeAccount()
        {
            m_frozen = false;
        }

        public static void Main()
        {
            BankAccount ba = new BankAccount("Mr. bryab walton", 11.99);

            ba.Credit(5.77);
            ba.Debit(11.22);
            Console.WriteLine("Current Balance is ${0}",ba.m_balance);
        }


    }


}
