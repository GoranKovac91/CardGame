using System;

namespace CardGameExcercise
{
    public class SpellCard : CardMain
    {
        private string _spell;
        public SpellCard(int manaCost, string name, Rarity rarity, string spell) : base(manaCost, name, rarity)
        {
            this._spell = spell;
        }

        public override string GetName()
        {
            return _name;
        }

        public override Rarity GetRarity()
        {
            return _rarity;
        }
    }
}
