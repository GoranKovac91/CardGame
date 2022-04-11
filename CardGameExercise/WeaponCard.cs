using System;

namespace CardGameExcercise
{
    public class WeaponCard : CardMain
    {
        private int _attack;
        private int _durability;

        public WeaponCard(int manaCost, string name, Rarity rarity, int attack, int durability) : base(manaCost, name, rarity)
        {
            this._attack = attack;
            this._durability = durability;
        }
    }
}
