using System;
namespace Hometasks.Hometask5
{
	public class CreditCard
	{
        string AccountNumber;
        int AccountCapacity;

        public CreditCard( string AccountNumber, int AccountCapacity)
		{
			this.AccountCapacity = AccountCapacity;
			this.AccountNumber = AccountNumber;
		}

		public void CapacityAdd(int ammount)
		{
            AccountCapacity = AccountCapacity + ammount;
		}

        public void CapacityWithdraw(int ammount)
        {
            AccountCapacity = AccountCapacity - ammount;
        }

        public void CardInfo()
        {
            Console.WriteLine($"Номер карты: {AccountNumber}, Сумма на карте: {AccountCapacity}");
        }

    }
}

