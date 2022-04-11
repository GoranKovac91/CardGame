using System;
namespace CardGameExcercise
{
    public abstract class CardMain
    {
        protected int _manaCost { get; set; }
        protected string _name {get; set; }
        protected Rarity _rarity { get; set; }

        public CardMain(int manaCost,string name,Rarity rarity)
        {
            this._manaCost = manaCost;
            this._name = name;
            this._rarity = rarity;
        }
        
    }
}

