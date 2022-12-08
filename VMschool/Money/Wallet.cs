using System;
using VMschool.Money;

namespace VMschool.Money
{
    public class Wallet
    {
        private readonly Dictionary<Currency, int> Cash = new(); // directionary with currency 

        public Wallet()
        {
            InitMoney();
        }

        public void InitMoney()
        {
            Cash.Add(Currency.HUNDRED, 0);
            Cash.Add(Currency.FIFTY, 0);
            Cash.Add(Currency.TWENTY, 0);
            Cash.Add(Currency.TEN, 10);
            Cash.Add(Currency.FIVE, 10);
            Cash.Add(Currency.ONE, 10);
        }

        public int GetMoney()
        {
            var sum = 0;
            foreach (var key in Cash) sum += (int)key.Key * key.Value;
            return sum;
        }

        public string GetMoneyDetails()
        {
            var str = "";
            var sum = 0;
            foreach (var key in Cash)
            {
                str += key.Key + ": " + key.Value + "\n";
                sum += (int)key.Key * key.Value;
            }

            str += "Total amount: " + sum;
            return str;
        }

        private int RemoveAmount(int amount)
        {
            var walletAmount = GetMoney();

            var amountLeft = amount;
            foreach (var keyPair in Cash) // Loopa igenom alla valörer, högst till lägst.
            {
                if (amountLeft == 0) break;

                var value = (int)keyPair.Key;

                while (Cash[keyPair.Key] > 0 && amountLeft >= value) // Om vi har sedlar kvar och kvarvarande summa är större än= sedelns värde
                {
                    amountLeft -= value;
                    walletAmount -= value;
                    Cash[keyPair.Key] -= 1;
                }
                walletAmount -= Cash[keyPair.Key] * value; // Hur mycket pengar vi har kvar om alla sedlar av valören togs bort

                while (walletAmount < amountLeft) // Om vi inte har tillräckligt med pengar kvar då så måste vi ta av den högre valören
                {
                    amountLeft -= value;
                    Cash[keyPair.Key] -= 1;
                }
            }

            return amount - amountLeft;
        }

        public int Deposit(int amount)
        {
            if (GetMoney() < amount) throw new Exception("Not enough funds");
            var removedAmount = RemoveAmount(amount);
            return removedAmount;
        }

        public void ReturnFunds(int amount)
        {
            var amountLeft = amount;
            foreach (var keyPair in Cash) // Loopa igenom alla valörer, högst till lägst.
            {
                var value = (int)keyPair.Key;

                while (amountLeft >= value) // Så länge valören är mindre än summan som är kvar kan vi ge tillbaka en sån valör
                {
                    amountLeft -= value;
                    Cash[keyPair.Key] += 1;
                }
            }
        }
    }
}