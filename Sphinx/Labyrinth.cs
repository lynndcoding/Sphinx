﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Characters;

namespace Labyrinth
{
    class Labyrinth
    {
        static void Main(string[] args)
        {
            Console.Title = "Secret Labyrinth of the Delphian Sphinx"; //Title for Console

            Console.WriteLine("                               .^^^^^^^^");
            Console.WriteLine("                             /xXX=====XXXx");
            Console.WriteLine("               //         , / / _/_/|_/_)");
            Console.WriteLine("              /';;       /'\'/////.-. .-./");
            Console.WriteLine("             / /;|      / . ,S'  -   - |");
            Console.WriteLine("            / -.;|      |'.SS/     =|  ;");
            Console.WriteLine("           ; '-.;/,     |'-.SS/   __  /S");
            Console.WriteLine("           |  _ ';//.   /'SSS/________/SS");
            Console.WriteLine("           |   '-';//. / _SSSS[XXXXXX]SS");
            Console.WriteLine("           /  '--.';;-.__.=SSS`//  /_SSS");
            Console.WriteLine("          /   .--'';;'..    =.=.=./././.=/");
            Console.WriteLine("           `.   .-'` __  _';;/.=.=.=.=.|.=|");
            Console.WriteLine("             ;-.__-' _'  __.;/=.=.=.=.=.=/ ");
            Console.WriteLine("     ,     _'     `' =.      ;/.=.=.=.=/ ");
            Console.WriteLine("     )/.'`  ___     `'__     .;| .=.=.=/");
            Console.WriteLine("     (_/ .-`   ' .    |      //      /");
            Console.WriteLine("      ///         / -,|       |.--'  |");
            Console.WriteLine("     /  /`,       //    /      |  |   |");
            Console.WriteLine("    ( (__) )    __-'--,  /     |  |   '--,");
            Console.WriteLine("     ;---'   -'--,__}}}  /    '--,   __}}}");
            Console.WriteLine("       /________}}}       /____}}}");

            int score = 0; //Declare and initiate variable to keep score for user
            int correctRiddle = 0;//Declare and initiate varible to keep track of correctly answered riddles
            int wrongRiddle = 0;//Declare and initiate varible to keep track of incorrectly answered riddles
            int loot = 0;
            Console.ForegroundColor = ConsoleColor.Red;//change text color in console to red
            Console.WriteLine($"Adventurer you are about to enter the Secret Labyrinth of the Delphian Sphinx.\nIt is rumored that the Sphinx can answer the questions of the universe\nand may appear and grant favor upon the true of heart when summoned. \nLegends also say the Sphinx is a merciless beast \nthat will kill and eat those who cannot answer its riddle.\nGather your wits, your courage and your weapon!\n\n");//Welcome the user to the game
            Console.ResetColor();//reset text color in console

            Console.WriteLine("Are you sure you wish to continue?");
            ConsoleKey cont = Console.ReadKey(true).Key; //Capture user choice
            if (cont == ConsoleKey.N)//give user option to leave game
            {
                Console.WriteLine("Not everyone is up to the challenge of the Sphinx...");
                System.Environment.Exit(0);
            }

            //Instantiate a player >>Because player class includes "weapon", must instantiate equipped weapon for player first
            ////Allow user to select public Weapon WeaponType
            Weapon selectedWeapon = Weapon.Longsword;//Declare variable to hold default weapon from the armory
                                                     //Loop for the User menu
            Console.Clear(); // Clear Console of all text

            bool loadmenu = false; //bool to run the switch & break out when user selects option
            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\nWhat Weapon would you like to arm yourself with \nwhile facing the perils of the mysterious labyrinth? Choose your weapon wisely!\n\n" +
                    "L) Longsword\n" +
                    "K) Knife\n" +
                    "D) Dagger\n" +
                    "S) Spear\n" +
                    "B) Bluntstave\n" +
                    "P) Polearm\n" +
                    "A) Axe\n" +
                    "T) Throwingstar\n" +
                    "G) Dartgun\n" +
                    "J) Javelin\n");
                Console.WriteLine("------------------------------------");
                ConsoleKey userWpn = Console.ReadKey(true).Key; //Capture user choice
                switch (userWpn) //switch method that reads keys input from user 
                {
                    case ConsoleKey.L:
                        selectedWeapon = Weapon.Longsword;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} is a good choice for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    case ConsoleKey.K:
                        selectedWeapon = Weapon.Knife;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} is a good choice for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    case ConsoleKey.D:
                        selectedWeapon = Weapon.Dagger;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} is a good choice for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    case ConsoleKey.S:
                        selectedWeapon = Weapon.Spear;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} is an interesting choice for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    case ConsoleKey.B:
                        selectedWeapon = Weapon.Bluntstave;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} is an interesting choice for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    case ConsoleKey.P:
                        selectedWeapon = Weapon.Polearm;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} will serve you well for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    case ConsoleKey.A:
                        selectedWeapon = Weapon.Axe;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"You have chosen an { selectedWeapon} for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    case ConsoleKey.T:
                        selectedWeapon = Weapon.Throwingstar;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} is one way to go. \nIt may not serve you well for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    case ConsoleKey.G:
                        selectedWeapon = Weapon.Dartgun;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} is an interesting choice for the perils \nthat lie ahead of you. Good luck with the dragon!");
                        loadmenu = true;
                        break;
                    case ConsoleKey.J:
                        selectedWeapon = Weapon.Javelin;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine($"A { selectedWeapon} is a good choice for the perils that lie ahead of you");
                        loadmenu = true;
                        break;
                    default:
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine("Input not recognized. Please choose a valid option from the menu...");
                        loadmenu = false;
                        break;
                }//end switch
            } while (!loadmenu); //end do while

            Random random = new Random(); //Declare Random to use for 
                                          //properties on the Armory obj

            //getting random values for min/maxDestruction and bonusHitChance
            int maxDestruction = random.Next(1, 10);
            int minDestruction = random.Next(1, maxDestruction + 1); //min is always less than max 
            int bonusHitChance = random.Next(1, 5);

            //NOTE: ctor = public Armory(int maxDestruction, Weapon weaponType, int bonusHitChance, int minDestruction)

            Armory armory = new Armory(maxDestruction, selectedWeapon, bonusHitChance, minDestruction);
            //ctor = public Player(string name, int hitChance, int block, int life, int maxLife, Race charRace, Armory armedWeapon)

            Console.WriteLine(armory);
            //TODO: Add functionality for player to choose their race

            Player player = new Player(" ", 25, 5, 10, 25, Race.Orc, armory);//Declare & Initialize default player and race

            do
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("\nWhat race will you be \nwhile facing the perils of the mysterious labyrinth?\n\n" +
                    "O) Orc\n" +
                    "E) Elf\n" +
                    "H) Human\n" +
                    "G) Gnome\n" +
                    "D) Dwarf\n" +
                    "B) DragonBorn\n" +
                    "T) Troll\n" +
                    "K) DarkElf\n" +
                    "N) Narwhal");
                Console.WriteLine("------------------------------------");
                ConsoleKey menurace = Console.ReadKey(true).Key; //Capture user choice
                switch (menurace) //switch method that reads keys input from user 
                {
                    case ConsoleKey.O:
                        player.CharRace = Race.Orc;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    case ConsoleKey.E:
                        player.CharRace = Race.Elf;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    case ConsoleKey.H:
                        player.CharRace = Race.Human;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    case ConsoleKey.G:
                        player.CharRace = Race.Gnome;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    case ConsoleKey.D:
                        player.CharRace = Race.Dwarf;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    case ConsoleKey.B:
                        player.CharRace = Race.DragonBorn;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    case ConsoleKey.T:
                        player.CharRace = Race.Troll;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    case ConsoleKey.K:
                        player.CharRace = Race.DarkElf;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    case ConsoleKey.N:
                        player.CharRace = Race.Narwhal;
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = true;
                        break;
                    default:
                        Console.Clear(); // Clear Console of all text
                        Console.WriteLine(player);
                        loadmenu = false;
                        break;
                }//end switch
            } while (!loadmenu); //end do while


            Console.WriteLine("What is your name Adventurer?"); //Ask user for their name
            string userName = Console.ReadLine(); // Read user's response
            player.Name = userName; // Reassign user's response userName as Name variable inside Player class
            Console.Clear(); // Clear Console of all text
            Console.WriteLine($"{player.Name}: Your Perilous Journey Begins...\n\n");

            bool exit = false;
            //Loop for the environment
            do
            {
                //Call GetRoom method that generates random room descriptions
                Console.WriteLine(GetRoom());
                //Instantiate monster in room for the player to battle
                Monster m1 = new Monster("Vampire", 15, 15, 30, 3, 5, "a strangely pale creature with a sinister smile\n that reveals two perfectly sharpened fangs", 2);
                Monster m2 = new Monster("Banshee", 10, 10, 20, 1, 5, "an ugly frightening hag dressed in a tattered grey hooded cloak.\n It appears to be running a comb through long stringy hair dripping in blood.\n The creature senses you and begins screaming nonstop as though in anguish.", 1);
                Monster m3 = new Monster("Zombie", 5, 5, 3, 1, 5, "a terrible and lifeless being with a distinctive\n blue-green hue to its skin. Upon closer inspection it appears to be eating \nwhat can only be described as the remnants of a human brain.", 3);
                Monster m4 = new Monster("Hydra", 20, 15, 15, 5, 5, "a gigantic water-snake-like monster with eight heads, \nand what appears to be another head growing out of a tentacle that looks to be recently cut off.", 3);
                Monster m5 = new Monster("Dragon", 30, 20, 20, 5, 5, "a huge, bat-winged, fire-breathing, scaly lizard \nwith a barbed tail.", 3);
                Monster[] monsters = { m1, m2, m3, m4, m5 };
                //randomly select a monster for the room
                Random rand = new Random();
                int randomNbr = rand.Next(monsters.Length);
                Monster monster = monsters[randomNbr];

                Console.ForegroundColor = ConsoleColor.Yellow;//change color of text
                Console.WriteLine("\nIn the back of the room you see " + monster.Description);
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine(" \nYou think it must be a " + monster.Name + ".\n");
                Console.ResetColor();//reset color of text

                //Loop for the User menu
                bool reload = false; // Boolean to control loop execution
                do
                {
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine("\nPlease carefully choose your next course of action: \n\n" +
                        "S) Summon the Sphinx\n" +//Answer riddle correctly for extra life
                        "A) Attack Monster\n" +
                        "F) Flee to Safety\n" +
                        "P) Player Info\n" +
                        "M) Monster Info\n" +
                        "X) Exit\n");
                    Console.WriteLine("------------------------------------");

                    ConsoleKey userChoice = Console.ReadKey(true).Key; //Capture user choice
                    Console.Clear();
                    switch (userChoice) //switch method that reads keys input from user (userChoice)
                    {
                        case ConsoleKey.S:
                            Console.WriteLine($"A creature with the head of a woman, the haunches of a lion, and the wings of a bird \nmysteriously appears next to the { monster.Name}. \n\n\nA realization comes upon you that you are now facing the mysterious\n and treacherous Sphinx. It is rumored that the Sphinx is merciless, \nand will kill and eat those who cannot answer its riddle.\n\n");
                            Console.WriteLine("                               .^^^^^^^^");
                            Console.WriteLine("                             /xXX=====XXXx");
                            Console.WriteLine("               //         , / / _/_/|_/_)");
                            Console.WriteLine("              /';;       /'\'/////.-. .-./");
                            Console.WriteLine("             / /;|      / . ,S'  -   - |");
                            Console.WriteLine("            / -.;|      |'.SS/     =|  ;");
                            Console.WriteLine("           ; '-.;/,     |'-.SS/   __  /S");
                            Console.WriteLine("           |  _ ';//.   /'SSS/________/SS");
                            Console.WriteLine("           |   '-';//. / _SSSS[XXXXXX]SS");
                            Console.WriteLine("           /  '--.';;-.__.=SSS`//  /_SSS");
                            Console.WriteLine("          /   .--'';;'..    =.=.=./././.=/");
                            Console.WriteLine("           `.   .-'` __  _';;/.=.=.=.=.|.=|");
                            Console.WriteLine("             ;-.__-' _'  __.;/=.=.=.=.=.=/ ");
                            Console.WriteLine("     ,     _'     `' =.      ;/.=.=.=.=/ ");
                            Console.WriteLine("     )/.'`  ___     `'__     .;| .=.=.=/");
                            Console.WriteLine("     (_/ .-`   ' .    |      //      /");
                            Console.WriteLine("      ///         / -,|       |.--'  |");
                            Console.WriteLine("     /  /`,       //    /      |  |   |");
                            Console.WriteLine("    ( (__) )    __-'--,  /     |  |   '--,");
                            Console.WriteLine("     ;---'   -'--,__}}}  /    '--,   __}}}");
                            Console.WriteLine("       /________}}}       /____}}}");
                            //create a new instance of a sphinx. This will generate a riddle and answer property
                            Sphinxanswer sphinx = new Sphinxanswer();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("The Sphinx narrows its wide crystal blue eyes and asks you 'Are you ready to answer \nthe Riddle of the Sphinx? \n");
                            Console.WriteLine("Type 'Y if you want to answer a riddle' or 'N if you are not up to the task'. ");
                            Console.ResetColor();
                            ConsoleKey userEntry = Console.ReadKey(true).Key; //Capture user choice
                            Console.Clear();
                            switch (userEntry)
                            {
                                case ConsoleKey.Y:
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    Console.WriteLine("Here is your riddle then. Think about it and answer carefully...");
                                    Console.WriteLine(sphinx.Riddle);
                                    Console.ResetColor();
                                    //Capture user Answer to Riddle
                                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                                    string userAnswer = Console.ReadLine().ToLower();
                                    Console.ResetColor();
                                    //TODO: Compare user Answer to correct Answer from SphinxAnswer.cs
                                    if (userAnswer == sphinx.Answer.ToLower())
                                    {
                                        //If correct Answer - award User +2 Life Points and kick user out of room
                                        Console.WriteLine("Congratulations! You have solved the riddle of the Sphinx! You have been awarded additional life. \nContinue on your journey worthy adversary...");
                                        reload = true; // load a new room 
                                        player.Life += 1; //increase player.Life by 1 as reward for answering question
                                        correctRiddle++; // keep track of riddles answered correctly
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine("You are not sure how you left the room with the Sphinx, it was like you materialized somewhere else magically \nonly to be confronted with another door...");
                                        Console.ResetColor();
                                    }
                                    else
                                    {
                                        //If incorrect Answer - Sphinx takes free attack and kick user out of room
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("The Sphinx suddenly rears up on its back legs and growls at you!!\nIt spews fire from three of its heads and bellows \nloudly ''You have failed to solve the riddle of the Sphinx!'' \nYou have had some of your life points removed for your insolence! \nYou are not worthy to continue...");
                                        Console.ResetColor();
                                        Console.WriteLine($"The Sphinx and {monster.Name} both attack you as you flee!");
                                        Combat.DoAttack(monster, player);
                                        player.Life -= 1;
                                        wrongRiddle++;
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine($"The Sphinx seems to have landed a blow. You should inspect your condition.\n");
                                        Console.ResetColor();
                                        reload = true; // load a new room 
                                    }
                                    break;
                                case ConsoleKey.N:
                                    Console.WriteLine("Not everyone is up to the challenge of the Sphinx. Your journey continues...");
                                    score++;
                                    reload = true;
                                    break;
                                default:
                                    Console.WriteLine("Input not recognized. Please choose a valid option from the menu...");
                                    break;
                            }
                            break;
                        case ConsoleKey.A:
                            Combat.DoBattle(player, monster);
                            if (monster.Life <= 0)
                            {
                                loot+= 5;
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                Console.WriteLine($"You loot the {monster.Name} and receive 5 gold.");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine($"\nYou killed the {monster.Name}! and are somehow magically transported to another room.");
                                Console.ResetColor();
                                reload = true; // this breaks us out of the loop to get a new room and new monster
                                score++;
                            }
                            break;
                        case ConsoleKey.F:// If User "Flees" Monster "free attack"
                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                            Combat.DoAttack(monster, player);
                            Console.WriteLine();
                            reload = true; // load a new room 
                            break;
                        case ConsoleKey.P:
                            Console.WriteLine("Player Info");
                            Console.WriteLine(player);
                            break;
                        case ConsoleKey.M:
                            Console.WriteLine("Monster Info");
                            Console.WriteLine(monster);
                            break;
                        case ConsoleKey.X:
                        case ConsoleKey.E:
                            Console.WriteLine("No one likes a quitter. Safe journeys my friend...");
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Input not recognized. Please choose a valid option from the menu...");
                            break;
                    }

                    if (player.Life <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("You're DEAD! You're dead! You're dead! You're dead! You're dead!");
                        Console.ResetColor();
                        exit = true;
                    }//breaks out of both loops

                } while (!exit && !reload); // same as  }while (exit==false && reload == false)

            } while (!exit); // same as: }while (exit == false)

            //Show player how many monsters they defeated
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));
            Console.WriteLine("You collected " + loot + " gold in loot" + (loot == 1 ? "." : "s."));
            Console.WriteLine("You correctly answered " + correctRiddle + " riddle" + (correctRiddle == 1 ? "." : "s."));
            Console.WriteLine("You incorrectly answered " + wrongRiddle + " riddle" + (wrongRiddle == 1 ? "." : "s."));
            Console.ResetColor();
        }//end Main()

        private static string GetRoom()
        {
            string[] rooms =
             {
               "Stinking smoke wafts up from braziers made of skulls set around the edges of this room. \n" +
               "The walls bear scratch marks and lines of soot that form crude pictures and what looks like words \n" +
               "in some language [Goblin]. To the left lies a pile of rubbish and rubble heaped into a crude dais. \n" +
               "The dais has upon it an ironbound chest that has been painted with a goblinlike face. Furs and skins \n" +
               "of unknown origin are strewn haphazardly about the floor before the dais.",
               " There's a hiss as you open this door, and you smell a sour odor, like something rotten or fermented. \n" +
               "Inside you see a small room lined with dusty shelves, crates, and barrels. It looks like someone once \n" +
               "used this place as a larder, but it has been a long time since anyone came to retrieve food from it.",
               "The burble of water reaches your ears after you open the door to this room. You see the source of the noise \n" +
               "in the far wall: a large fountain artfully carved to look like a seashell with the figure of a seacat \n" +
               "spewing clear water into its basin.",
               "The door to this room swings open easily on well-oiled hinges. Beyond it you see that the chamber walls \n" +
               "have been disguised by wood paneling, and the stone ceiling and floor are hidden by bright marble tiles. \nSeveral large and well-stuffed chairs are arranged about the room along with some small reading tables.",
            "This otherwise bare room has one distinguishing feature. \nThe stone around one of the other doors has been pulled over its edges, \nas though the rock were as soft as clay and could be moved with fingers. \nThe stone of the door and wall seems hastily molded together.",
            "A liquid-filled pit extends to every wall of this chamber. \nThe liquid lies about 10 feet below your feet and is so murky that you can't see its bottom. \nThe room smells sour. A rope bridge extends from your door to the room's other exit.",
            "A crack in the ceiling above the middle of the north wall allows a trickle of water to flow down to the floor. \nThe water pools near the base of the wall, and a rivulet runs along the wall an out into the hall. \nThe water smells fresh.",
            "A huge stewpot hangs from a thick iron tripod over a crackling fire in the center of this chamber. A hole in the ceiling allows some of the smoke from the fire to escape, but much of it expands across the ceiling and rolls down to fill the room in a dark fog. Other details are difficult to make out, but some creature must be nearby, because it smells like a good soup is cooking.",
            "You open the door, and the room comes alive with light and music. A sourceless, warm glow suffuses the chamber, and a harp you cannot see plays soothing sounds. Unfortunately, the rest of the chamber isn't so inviting. The floor is strewn with the smashed remains of rotting furniture. It looks like the room once held a bed, a desk, a chest, and a chair.",
            "This room is hung with hundreds of dusty tapestries. All show signs of wear: moth holes, scorch marks, dark stains, and the damage of years of neglect. They hang on all the walls and hang from the ceiling to brush against the floor, blocking your view of the rest of the room.",
            " A dozen statues stand or kneel in this room, and each one lacks a head and stands in a posture of action or defense. All are garbed for battle. It's difficult to tell for sure without their heads, but two appear to be dwarves, one might be an elf, six appear human, and the rest look like they might be orcs.",
            "You peer into this room and spot the white orb of a skull lying on the floor. Suddenly a stone falls from the ceiling and smashes the skull to pieces. An instant later, another stone from the ceiling drops to strike the floor and shatter. You hear a low rumbling and cracking noise.",
            "This chamber holds one occupant: the statue of a male figure with elven features but the broad, muscular body of a hale human. It kneels on the floor as though fallen to that posture. Both its arms reach upward in supplication, and its face is a mask of grief. Two great feathered wings droop from its back, both sculpted to look broken. The statue is skillfully crafted."
            };
            Random rand = new Random();
            int indexNbr = rand.Next(rooms.Length);
            string room = rooms[indexNbr];
            return room;
        }//end method GetRoom()
    }//end class Labyrinth
}//end Namespace