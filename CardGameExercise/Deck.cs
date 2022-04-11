using System;
using System.Collections.Generic;

namespace CardGameExcercise
{
    public class Deck
    {
        public string Name;
        private readonly int Size=30;
        public Dictionary <CardMain,int> DeckOfCards;
        
        public Deck(string name,int size)
        {
            this.Name = name;
            this.Size = size;
            DeckOfCards = new Dictionary<CardMain, int>(size);
            
        }
    }
}
