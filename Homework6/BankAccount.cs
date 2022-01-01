using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework6
{
    public enum Type
    {
        Дебетовый,
        Кредитовый,
        Накопительный
    }
    public class BankAccount : IEquatable<BankAccount> // наследование интерфейса для переопределения GetHashCode
    {
        private int numberAccount;
        private double balanceAccount;
        private Type typeAccount;

        public int NumberAccount
        {
            get
            {
                return this.numberAccount;
            }

            set
            {
                this.numberAccount = value;
            }

        }

        public double BalanceAccount
        {
            get
            {
                return this.balanceAccount;
            }

            set
            {
                this.balanceAccount = value;
            }

        }


        public Type TypeAccount
        {
            get
            {
                return this.typeAccount;
            }

            set
            {
                this.typeAccount = value;
            }

        }

        // переопределение оператора == для сравнения информации в двух счетах
        public static bool operator ==(BankAccount b1, BankAccount b2)
        {
            return b1.NumberAccount == b2.NumberAccount && b1.TypeAccount == b2.TypeAccount;
        }

        // переопределение оператора != для сравнения информации в двух счетах
        public static bool operator !=(BankAccount b1, BankAccount b2)
        {
            return b1.NumberAccount != b2.NumberAccount || b1.TypeAccount != b2.TypeAccount;
        }

        // переопределение Equals
        public bool Equals(BankAccount other)
        {
            return other == this;

        }

        public override bool Equals(object obj)
        {
            return Equals(obj as BankAccount);
        }
       


        //public override bool Equals(object obj)
        //{
        //    if (obj == null)
        //        return false;
        //    BankAccount b = obj as BankAccount;
        //    if (b as BankAccount == null)
        //        return false;

        //    return b.NumberAccount == this.NumberAccount && b.TypeAccount == this.TypeAccount;
        //}

        // переопределение ToString()
        public override string ToString()
        {
            return ("Номер счета: " + numberAccount + "; Баланс счета: "
                + balanceAccount + "; Тип счета: " + typeAccount);
        }

        // переопределение GetHashCode()
        public override int GetHashCode()
        {
            return HashCode.Combine(NumberAccount, TypeAccount);
        }

        // добавление на счет
        public void AddToAccount(double summ)
        {
            this.BalanceAccount = balanceAccount + summ;
            Console.WriteLine("Ваш счет увеличен на " + summ + ", " +
                "общая сумма по счету теперь составляет " + this.balanceAccount);
        }

        // снятие со счета
        public void Withdraw(double summ)
        {
            if (summ > this.balanceAccount)
            {
                Console.WriteLine("Снятие невозможно, поскольку запрошенная сумма больше остатка по счету");
            }
            else
            {
                this.BalanceAccount = balanceAccount - summ;
                Console.WriteLine("Ваш счет уменьшен на " + summ + ", " +
                "общая сумма по счету теперь составляет " + this.balanceAccount);
            }
        }

  





        //public void PrintAccountData() утратило актуальность, т.к. переопределен ToString()
        //{
        //    Console.WriteLine("Номер счета: " + numberAccount + "; Баланс счета: "
        //        + balanceAccount + "; Тип счета: " + typeAccount);
        //}
    }
}
