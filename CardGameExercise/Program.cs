using System;

namespace CardGameExcercise
{

    class Program
    {
        static void Main(string[] args)
        {
            MinionCard minion = new MinionCard(10, "name", Rarity.Legendary, 20, 50);
            MinionCard minion2 = new MinionCard(2, "name", Rarity.Legendary, 30, 30);
         
            Deck deckA = new Deck("name",20);
            deckA.DeckOfCards.Add(minion2);
            deckA.DeckOfCards.Add(minion);
            deckA.CheckRarity();
            
           
            
          
        }
    }
}
