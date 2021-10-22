using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sphinx
{
    class Labyrinth
    {
            static void Main(string[] args)
            {

                Console.Title = "Secret Labyrinth of the Delphian Sphinx";
                Console.WriteLine("What is your name Adventurer?");
                string userName = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"{userName}: you are about to enter the Secret Labyrinth of the Delphian Sphinx. \nGather your wits, your courage and your weapon! \nYour Perilous Journey Begins...\n\n");

                int score = 0;

                //Instantiate a player >>Because player class includes "weapon", must instantiate equipped weapon for player first
                Armory armory = new Armory(3, Weapon.Longsword, 2, 1);
                //public Player(string name, int hitChance, int block, int life, int maxLife, Race charRace, Armory armedWeapon)
                Player player = new Player("Indiana Jones", 1, 1, 10, 10, Race.Orc, armory);

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

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nIn the back of the room you see " + monster.Description + " You think it must be a " + monster.Name + ".\n");
                    Console.ResetColor();

                    //Loop for the User menu
                    bool reload = false;
                    do
                    {
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine("\nPlease carefully choose your next course of action: \n\n" +
                            "S) Face the Sphinx\n" +//Answer riddle correctly for extra life
                            "A) Attack Monster\n" +
                            "F) Flee to Safety\n" +
                            "P) Player Info\n" +
                            "M) Monster Info\n" +
                            "X) Exit\n");
                        Console.WriteLine("------------------------------------");

                        ConsoleKey userChoice = Console.ReadKey(true).Key; //Capture user choice
                        Console.Clear();
                        switch (userChoice)
                        {
                            case ConsoleKey.S:
                                Console.WriteLine("In front of you you see a creature with the head of a woman, the haunches of a lion, \nand the wings of a bird. A realization comes upon you that you have just discovered the mysterious\n and treacherous Sphinx. It is rumored that the Sphinx is merciless, \nand will kill and eat those who cannot answer its riddle.");
                                //create a new instance of a sphinx. This will generate a riddle and answer property
                                Sphinxanswer sphinx = new Sphinxanswer();
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                Console.WriteLine("The Sphinx narrows its wide crystal blue eyes and asks you 'Are you ready to answer \nthe Riddle of the Sphinx? ");
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
                                        string userAnswer = Console.ReadLine().ToLower();
                                        //TODO: Compare user Answer to correct Answer from SphinxAnswer.cs
                                        if (userAnswer == sphinx.Answer.ToLower())
                                        {
                                            //If correct Answer - award User +2 Life Points and kick user out of room
                                            Console.WriteLine("Congratulations! You have solved the riddle of the Sphinx! You have been awarded additional life. Continue on your journey worthy adversary...");
                                            reload = true; // load a new room 
                                            player.Life += 2;
                                            score++;
                                        }
                                        else
                                        {
                                            //If incorrect Answer - Sphinx takes free attack and kick user out of room
                                            Console.WriteLine("You have failed to solve the riddle of the Sphinx! You are not worthy to continue...");
                                            Console.WriteLine($"{monster.Name} attacks you as you flee!");
                                            Combat.DoAttack(monster, player);
                                            reload = true; // load a new room 
                                            player.Life -= 1;
                                            score++;
                                        }
                                        break;
                                    case ConsoleKey.N:
                                        Console.WriteLine("Not everyone is up to the challenge of the Sphinx. Your journey continues...");
                                        reload = true;
                                        score++;
                                        break;
                                    default:
                                        Console.WriteLine("Input not recognized. Please choose a valid option from the menu...");
                                        break;
                                }
                                player.Life += 2;
                                break;
                            case ConsoleKey.A:
                                Combat.DoBattle(player, monster);
                                if (monster.Life <= 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine($"\nYou killed the {monster.Name}! and are immediately transported to another room.");
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
                                Console.WriteLine("No one likes a quitter....");
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
                Console.WriteLine("You defeated " + score + " monster" + (score == 1 ? "." : "s."));

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
               "Stinking smoke wafts up from braziers made of skulls set around the edges of this room. The walls bear \n" +
               "scratch marks and lines of soot that form crude pictures and what looks like words in some language [Goblin]. \n" +
               "To the left lies a pile of rubbish and rubble heaped into a crude dais. The dais has upon it an ironbound chest \n" +
               "that has been painted with a goblinlike face. Furs and skins of unknown origin are strewn haphazardly \n" +
               "about the floor before the dais." ,
               " There's a hiss as you open this door, and you smell a sour odor, like something rotten or fermented. \n" +
               "Inside you see a small room lined with dusty shelves, crates, and barrels. It looks like someone once \n" +
               "used this place as a larder, but it has been a long time since anyone came to retrieve food from it.",
               "The burble of water reaches your ears after you open the door to this room. You see the source of the noise \n" +
               "in the far wall: a large fountain artfully carved to look like a seashell with the figure of a seacat \n" +
               "spewing clear water into its basin.",
               "The door to this room swings open easily on well-oiled hinges. Beyond it you see that the chamber walls \n" +
               "have been disguised by wood paneling, and the stone ceiling and floor are hidden by bright marble tiles. \nSeveral large and well-stuffed chairs are arranged about the room along with some small reading tables." };
                Random rand = new Random();
                int indexNbr = rand.Next(rooms.Length);
                string room = rooms[indexNbr];
                return room;
            }//end method GetRoom()
        }//end class Labyrinth
    }//end Namespace