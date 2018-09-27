using System;
using System.Collections.Generic;
using System.Text;

namespace Banking.Models.Domain
{
    public class BankAccount //visibiliteit is internal als default (zonder public ervoor) => binnen dezelfde assembly
    {
        //attributen in java => fields in c#
        //private string _accountNumber;
        /*private decimal _balance; // decimal => integer

        public decimal GetBalance()
        {
            return _balance;
        }

        private void SetBalance(decimal value) //private want we mogen niet van buitenaf het bedrag veranderen enkel door storting / afhaling
        {
            _balance = value;
        }*/

        //public decimal Balance { get; private set; } //verkorte notatie van alles hierboven in commentaar, getter => public, setter moeten we specifiek private zetten. visibiliteit geven aan de methode want default is private
        //{get; private set } is een automatic property.
        #region Fields
        public const decimal WithdrawCost = 0.10M;
        public string AccountNumber { get; set; } //prop + tab + tab

        
        private decimal _balance;
        #endregion 
        #region Properties
        public decimal Balance //property heeft alleen een get en set dus private decimal _balance moet erbuiten
        {
            get { return _balance; }
            private set
            { //gebruik maken van een backing field => dit is een full property, men maakt gebruikt van _balance.
                if (value < 0)
                    throw new ArgumentException("Invalid value for balance");
                _balance = value; //binnen een property heeft value speciale betekenis, nl. de parameter die wordt meegegeven.
            }
        } 
        #endregion

        #region Constructors
        public BankAccount(string accountNumber) //ctor + tab + tab
        {
            AccountNumber = accountNumber;
        }

        public BankAccount(string accountNumber, decimal balance) : this(accountNumber) //andere constructor eerst aanroepen, moet eerste statement zijn gelijk bij java
        {
            Balance = balance;
        }
        #endregion



        #region Methods
        public void Deposit(decimal amount)//,int nrOfTimes = 1) // door een waarde aan toetekennen nrOfTimes wordt dit een optionele parameter, er moet niet noodzakelijk een waarde aan meegegeven worden
        {
            Balance += amount;// * nrOfTimes; in commentaar is de optionele parameter.
        }

        public void Withdraw(decimal amount)
        {
            Balance -= amount + WithdrawCost;
        } 
        #endregion
    }
}
