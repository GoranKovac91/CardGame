using System;
using System.Collections.Generic;

namespace CardGameExcercise
{
    public class Deck
    {
        public string Name;
        private readonly int Size = 30;
        public  List<CardMain> DeckOfCards;
        public int _countLegendary=0;
        public int _countRare=0;

        public Deck(string name, int size)
        {
            this.Name = name;
            this.Size = size;
            DeckOfCards = new List<CardMain>();

        }
        public void NumberOfCards()
        {
            if (DeckOfCards.Count>Size)
            {
                Console.WriteLine("Too many cards in deck");
                
            }
        }
        public void CheckRarity()
        {
            foreach (CardMain card in DeckOfCards)
            {
                if (card.GetRarity() == Rarity.Legendary && card.GetName() == card.GetName())
                {
                    _countLegendary++;
                    
                }
                else if (card.GetRarity()==Rarity.Rare && card.GetName()==card.GetName())
                {
                     _countRare++;
                    
                }
                if (_countLegendary > 1 || _countRare > 2)
                {
                    Console.WriteLine("Too many same cards in deck");
                }
            }
          
        }

      
        
       

    }

	
    
        
        
    
}
