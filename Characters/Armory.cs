using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Armory
    {
        //field
        private int _minDestruction; // setting field private to use in this function - then reset variable to public to use anywhere in this program

        //properties
        public Weapon WeaponType { get; set; } //calling from enum Weapon
        public int MaxDestruction { get; set; }
        public int BonusHitChance { get; set; }

        public int MinDestruction
        {
            get { return _minDestruction; }
            set
            {
                //minDestruction has to do some damange - it can't be 0, and it can't be more than maxDestruction 
                if (value > 0 && value <= MaxDestruction)
                {
                    //< max and >1
                    _minDestruction = value;
                }//end if
                else
                {
                    _minDestruction = 1;
                }//end else
            }//end get set
        }//end property MinDestruction

        //ctor
        public Armory(int maxDestruction, Weapon weaponType, int bonusHitChance, int minDestruction)
        {
            MaxDestruction = maxDestruction;
            WeaponType = weaponType;
            BonusHitChance = bonusHitChance;
            MinDestruction = minDestruction;
        }

        //method
        public override string ToString()
        {
            return string.Format($"{WeaponType}\t Deals Damage: {MinDestruction} to {MaxDestruction}\nBonus Hit: {BonusHitChance}");
        }

    }//end class
}//end namespace