using System;
using System.Collections.Generic;
using System.Text;

namespace KiemTra_Lan2.Cau3
{
    public class Account : IAccount
    {
        private int balance;
        public int AccountId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }


        public int Balance { get => balance; set => balance = value; }

        public int PayInto()
        {
            return Balance;
        }

        public string ShowInfo()
        {
            return $"AccountId: {AccountId}  FirstName: {FirstName} LastName: {LastName} " +
                  $"PhoneNumber: {Gender} Balance: {PayInto()}";
        }
    }
}
