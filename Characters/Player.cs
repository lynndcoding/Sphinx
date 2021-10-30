using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Characters
{
    public class Player : Character  //Player is a child of Character and inherits from it
    {
        //fields
        //We do not need to declare fields because the info specific to Player does NOT require business rules

        //properties
        public Race CharRace { get; set; } // calling from enum Race 

        public Armory ArmedWeapon { get; set; } // calling from Class Armory referencing enum Weapon
        public static object charRace { get; set; }

        //ctor
        public Player(string name, int hitChance, int block, int life, int maxLife, Race charRace, Armory armedWeapon)
        {
            //Since Life depends on MaxLife we will set a value for MaxLife first
            MaxLife = maxLife;
            Name = name;
            HitChance = hitChance;
            Block = block;
            Life = life;
            CharRace = charRace;
            ArmedWeapon = armedWeapon;

            switch (CharRace)
            {
                case Race.Orc:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
                case Race.Elf:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
                case Race.Human:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
                case Race.Gnome:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
                case Race.Dwarf:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
                case Race.DragonBorn:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
                case Race.Troll:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
                case Race.DarkElf:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
                case Race.Narwhal:
                    /*MaxLife += 10;*/
                    HitChance += 7;
                    Block += 5;
                    /*Life += 10;*/
                    break;
            }//end switch CharacterRace Hitchance
        }//end ctor

        //method
        public override string ToString()
        {
            string description = "";

            switch (CharRace)
            {
                case Race.Orc:
                    description = "Orc: a sneaky repulsive brutish creature.";
                    break;
                case Race.Elf:
                    description = "Elf: a very agile creature. Pointy ears. Super magical";
                    break;
                case Race.Human:
                    description = "Human: an ordinary and clumsy looking animal.";
                    break;
                case Race.Gnome:
                    description = "Gnome: a small impish supernatural spirit standing 16 - 24 inches tall wearing a pointed felt caps. Especially inventive or cunning and skilled with illusions. ";
                    break;
                case Race.Dwarf:
                    description = "Dwarf: a short stocky being with strong, muscly arms and legs. Extremely greedy when it comes to gold. ";
                    break;
                case Race.DragonBorn:
                    description = "DragonBorn: a humanoid creature resembling a dragon, with a scaled hide and a dragonlike head. They are proud and brave, with strong ties to clan, tradition, and family.";
                    break;
                case Race.Troll:
                    description = "Troll: an ugly distorted large humanoid being. Very stupid loner wishing it was underneath a bridge preventing anyone from passing.";
                    break;
                case Race.DarkElf:
                    description = "DarkElf: Graceful looking humanoid with purple skin, of a very dark, almost black hue. Known for their aggression, deceit, and stealth. They are very brutal and cruel by nature, having little mercy when it comes to cheating, battling, or anything dealing with the life of another being. They have little respect for even their own kind, at times waging war against each other.";
                    break;
                case Race.Narwhal:
                    description = "Narwhal: something between a dolphin and a whale with a blotchy sausage-shaped body, a rounded head with no beak, a ridge on their backs rather than a fin and short blunt flippers with upcurled edges. They have odd-shaped tail flukes that look as though they have been put on backwards. The most distinguishing feature is a massive 10 foot long tusk.";
                    break;
            }//end switch CharRace description

            return string.Format($"\n**********PLAYER INFO*********\n" +
                $"\nPlayer Name:{Name}" +
                $"\nDescription:\t You are a {description}" +
                $"\nLife: {Life} of {MaxLife}\n" +
                $"Your Weapon is:{ArmedWeapon}\n" +
                $"Hit Chance: {CalcHitChance()}\n" +
                $"Block: {Block}\n");
        }

        public override int CalcDamage()
        {
            //create a random object
            Random rand = new Random();
            //determine the Destruction
            int damage = rand.Next(ArmedWeapon.MinDestruction, ArmedWeapon.MaxDestruction + 1);

            return damage;
        }

        public override int CalcHitChance()
        {
            return base.CalcHitChance() + ArmedWeapon.BonusHitChance;
        }
    }//end class
}//end namespace
