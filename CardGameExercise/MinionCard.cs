using System;
namespace CardGameExcercise
{
    public class MinionCard:CardMain
    {
        private  int _attack;
        private  int _health;


        public MinionCard(int manaCost, string name, Rarity rarity, int attack, int health) : base(manaCost, name, rarity)
        {
            this._attack = attack;
            this._health = health;

        }
        public  override string GetName()
        {
            return _name;
        }
        public override Rarity GetRarity()
        {
            return _rarity;
        }
     
      
        
       
    }
}


