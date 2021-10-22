using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Character
    {
        //fields
        private int _life; // setting field as private to use in this function - then reset variable to public to use anywhere in this program

        //properties - automatic property syntax
        public string Name { get; set; }
        public int HitChance { get; set; }
        public int Block { get; set; }
        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                //business rule, life should never be more than maxLife
                if (value <= MaxLife)
                {
                    _life = value;
                }
                else
                {
                    _life = MaxLife;
                }

            }
        }

        //ctor (constructors)
        //We will only need the default ctor here. Therefore, we can use the free parameterless, default ctor the .NET Framework gives us.

        //methods
        //below are methods we want to be inherited by player and monster, so we are creating default versions here that the child classes will be able to use.
        //The child class can use the default functionality defined below. 
        //Or they can use the "override" keyword to replace the parent functionality with their own
        //Without the virtual keyword, the child cannot use the override functionality
        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

    }//end class
}//end namespace