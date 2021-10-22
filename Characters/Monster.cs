using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Monster : Character
    {
        //fields
        private int _minDamage;
        //propfull tab tab                                              <<---COOL KEYBOARD SHORTCUT

        //properties
        public int MaxDamage { get; set; }
        public string Description { get; set; }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        //ctors
        public Monster()
        {
            //default ctor
        }

        public Monster(string name, int life, int maxLife, int hitChance, int block, int maxDamage, string description, int minDamage)
        {
            MaxLife = maxLife;
            MaxDamage = maxDamage;
            Description = description;
            MinDamage = minDamage;
            Name = name;
            Life = life;
            HitChance = hitChance;
            Block = block;
        }

        //methods
        public override string ToString()
        {
            return string.Format($"\n**********MONSTER*********\n" +
                $"Before you stands a {Name}\n" + $" {Description}\n" +
                $"Life: {Life} of {MaxLife}\n" +
                $"Damage: {MinDamage}\n" +
                $"Block: {Block}\n");
        }

        //Override the base functionality for calcDamage() to use the MinDamage and MaxDamage properties from this class
        public override int CalcDamage()
        {
            //return base.CalcDamage(); - this just returns 0
            Random rand = new Random();
            return rand.Next(MinDamage, MaxDamage + 1);
        }
    }//end class
}//end namespace