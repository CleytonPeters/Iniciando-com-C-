﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Aula_133_Classes_Abstratas.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        public double Balance { get; protected set; }

        public Account()
        {

        }
        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
        }

    }
}
