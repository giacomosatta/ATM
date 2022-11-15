using ATM.Models;

namespace ATM.Data
{
	public class MockDB
	{
		List<CardHolder> cardHolders = new List<CardHolder>()
		{
			new CardHolder("132456789", 1111, "Carlo", "Giuli", 148.25),
			new CardHolder("147896321", 2458, "Luigi", "Sciolte", 110),
			new CardHolder("651789425", 9874, "Adelaide", "Bassi", 458.50),
			new CardHolder("478495412", 4578, "Kevin", "Belli", 10.50)
		};
	}
}


