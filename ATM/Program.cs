using ATM.Data;
using ATM.Models;
using ATM.Service;



AtmService atmService = new AtmService();
List<CardHolder> cardHolders = new List<CardHolder>()
		{
			new CardHolder("132456789", 1111, "Carlo", "Giuli", 148.25),
			new CardHolder("147896321", 2458, "Luigi", "Sciolte", 110),
			new CardHolder("651789425", 9874, "Adelaide", "Bassi", 458.50),
			new CardHolder("478495412", 4578, "Kevin", "Belli", 10.50)
		};

Console.WriteLine("SPORTELLO ATM");
Console.WriteLine(new string('-', 30));
Console.WriteLine("Inserisci il numero della tua carta: ");
string debitCardNum = Console.ReadLine();

CardHolder currentUser = cardHolders.Where(x => x.CardNum == debitCardNum).FirstOrDefault();

if (currentUser == null)
{
	Console.WriteLine("Spiacenti, la carta associata a questo numero non è stato trovata");
	return;
}

Console.WriteLine("Inserisci il PIN:");
bool flag = CheckPin();

if (!flag)
{
	Console.WriteLine("Hai finito i tentativi, operazione bloccata");
	return;
}

Console.WriteLine($"Benvenuto {currentUser.FirstName} {currentUser.LastName}");

string chosenOption = string.Empty;

ExecuteLogic();


bool CheckPin()
{
	for (int i = 0; i < 3; i++)
	{
		int pin = int.Parse(Console.ReadLine());
		if (!currentUser.Pin.Equals(pin))
		{
			Console.WriteLine($"Spiacenti, il pin non è corretto, tentativi rimasti:{3 - (i + 1)}");
			continue;
		}
		return true;
	}
	return false;
}

void ExecuteLogic()
{
	do
	{
		Console.WriteLine(new string('-', 30));
		chosenOption = atmService.chooseOption();

		switch (chosenOption)
		{
			case "1":
				atmService.Deposit(currentUser);
				break;
			case "2":
				atmService.Withdraw(currentUser);
				break;
			case "3":
				atmService.ShowBalance(currentUser);
				break;
			case "4":
				Console.WriteLine("Grazie per aver utilizzto i nostri servizi");
				return;
			default:
				Console.WriteLine("Il numero inserito non corrisponde a nessuna azione");
				break;
		}
	} while (!chosenOption.Equals("4"));
}

