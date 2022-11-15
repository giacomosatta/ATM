namespace ATM.Models
{
	public class CardHolder
	{
		public string CardNum { get; set; }
		public int Pin { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public double Balance { get; set; }

		public CardHolder(string cardNum,int pin, string firstName, string lastName, double balance){
			this.CardNum = cardNum;
			this.Pin = pin;
			this.FirstName = firstName;
			this.LastName = lastName;
			this.Balance = balance;
		}

		public string getCardNum()
		{
			return CardNum;
		}

		public int getPin()
		{
			return Pin;
		}

		public string getFirstName()
		{
			return FirstName;
		}

		public string getLastName()
		{
			return LastName;
		}

		public double getBalance()
		{
			return Balance;
		}
	}
}
