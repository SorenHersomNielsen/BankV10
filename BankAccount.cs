namespace BankV10
{
    public class BankAccount
    {
        #region Instance fields
        private double _balance;
        #endregion

        #region Constructor
        public BankAccount()
        {
            _balance = 0.0;
        }
        #endregion

        #region Properties
        public double Balance
        {
            get { return _balance; }
        }
        #endregion

        #region Methods
        public void Deposit(double amount)
        {
            if ( amount > 0)
            {_balance = _balance + amount;}
            else
            System.Console.WriteLine("det må ikke være minus tal");
        }

        public void Withdraw(double amount)
        {
            if( amount < Balance && amount > 0)
            {_balance = _balance - amount;}
            else 
            System.Console.WriteLine("det må ikke være minus tal");

        } 
        #endregion
    }
}