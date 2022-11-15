using ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Service
{
	public class AtmService
	{
		public string chooseOption()
		{
			Console.WriteLine("Scegli una delle seguenti opzioni...");
			Console.WriteLine("1. Deposito");
			Console.WriteLine("2. Ritiro");
			Console.WriteLine("3. Mostra Saldo");
			Console.WriteLine("4. Esci");

			return Console.ReadLine();
		}

		public void Deposit(CardHolder cardHolder)
		{
			Console.WriteLine("Quanto vuoi depositare");
			double deposit = Double.Parse(Console.ReadLine());
			cardHolder.Balance += deposit;
		}

		public void Withdraw(CardHolder cardHolder)
		{
			Console.WriteLine("Quanto vuoi ritirare");
			double withdraw = Double.Parse(Console.ReadLine());
			if (cardHolder.getBalance() < withdraw)
			{
				Console.WriteLine("Siamo spiacenti, il saldo è inferiore al prelievo richiesto");
				return;
			}

			cardHolder.Balance -= withdraw;
			Console.WriteLine("Prelievo effettuato, grazie");
		}

		public void ShowBalance(CardHolder cardHolder)
		{
			Console.WriteLine($"Il saldo è:{cardHolder.getBalance()}");
		}
	}
}
