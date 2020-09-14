using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RainbowLibrary;
using EnemyLibrary;

namespace BeyondTheRainbow
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Intro
            Console.Beep(240, 250);
            Console.Beep(340, 220);
            Console.Beep(370, 220);
            Console.Beep(400, 220);
            Console.Beep(320, 260);


            Console.ForegroundColor = ConsoleColor.DarkYellow;




            Console.Title = "Beyond The Rainbow";
            Console.WriteLine("BEYOND THE RAINBOW");
            System.Threading.Thread.Sleep(3200);
            Console.WriteLine("Created by: Lance Vogel 2020");
            System.Threading.Thread.Sleep(3200);
            Console.Clear();
            Console.WriteLine("You wake up in the stale air of a warm bedroom. Dust floats in the last beams of the evening sun between a pair of torn curtains. Everything feels wrong...\n");
            System.Threading.Thread.Sleep(3000);
            #endregion

            #region Hero Selection  
            //Weapons
            Weapon pitchfork = new Weapon("Pitchfork", 4, 6, 4, false, 0);
            Weapon axe = new Weapon("Axe", 6, 8, 2, false, 0);
            Weapon teeth = new Weapon("Claws and Fangs", 4, 6, 2, true, 5);
            //Lion teeth might need a bool instead of an int for chance to eat

            Console.WriteLine("You see three objects placed intentionally in front of the closed bedroom door: A clump of straw tied together with a green rope, an oil can with a heart drawn on with lipstick and a large chipped feline tooth. Which one do you pick up?");

            //Player List

            Player p1 = new Player("Strawman", 100, 100, 5, 7, pitchfork, Heroes.Strawman);
            Player p2 = new Player("Tinheart", 100, 100, 8, 6, axe, Heroes.Tinheart);
            Player p3 = new Player("Werelion", 100, 100, 5, 4, teeth, Heroes.Werelion);


            //Player [] playerChoice  = player;


            Player characterChoice = p1;
            bool exit = false;
            do
            {
                //Choose your hero
                Console.WriteLine("Choose an action:\n" +
                    "S)traw\n" +
                    "O)il\n" +
                    "T)ooth \n" +

                    "E)xit");

                //Catch the user choice
                ConsoleKey charChoice = Console.ReadKey(true).Key;
                Console.Clear();


                //8 TODO Build out the switch for the user choice
                switch (charChoice)
                {

                    case ConsoleKey.S:
                        //INCLUDE PERSONAL MUSIC FOR EACH CHARACTER
                        Console.WriteLine("You feel a flood of thoughts and feelings pour over you . . .");
                        System.Threading.Thread.Sleep(1600);
                        Console.WriteLine("You thought you knew everything until something heavy landed on your head. Now it's as if you've been reset in your knowledge.\nWhen you look down at your arms they are no longer covered in flesh, but living, breathing straw.\nYou often strike true: +2 hit bonus.\nYour weapon is the pitchfork which keeps the crows away: +10 block to normal Crows");

                        Console.ReadLine();
                        exit = true;
                        break;

                    case ConsoleKey.O:
                        Console.WriteLine("You feel love lost and deep despair . . .");
                        System.Threading.Thread.Sleep(1600);
                        Console.WriteLine("Your optimism was once full and you once knew what you stood for . . . until you decided to try the game of love. Now, none of that past enthusiasm means a thing. Your cold, hollow heart is encased in rusted tin.\n Your tin flesh boosts your armor: +3 to block and +10 maxlife .\nYour weapon is an axe");
                        characterChoice = p2;
                        Console.ReadLine();
                        exit = true;
                        break;

                    case ConsoleKey.T:
                        Console.WriteLine("You feel shame from your overwhelming fear . . .");
                        System.Threading.Thread.Sleep(1600);
                        Console.WriteLine("You remember the fearlessness of your stride. There were no obstacles, just paths. Your confidence was unmatched. But then you failed to save someone. And the doubt in yourself grew and grew until it shattered any forward momentum in your life. You let out a roar in self-pity.\nYou often doubt yourself: -3 to hit bonus.\nBut when rage fills your blood, you fight with fangs and claws: Critical hits result in instant enemy consumption.");
                        characterChoice = p3;
                        Console.ReadLine();
                        exit = true;
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Game Over . . .");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Choosing nothing is not an option");
                        break;
                }
            } while (!exit);
            #endregion

            #region Munchkin Riddle
            Console.Clear();
            Console.WriteLine("Though much weighs on you, you know one is for sure: You need to get out of this house.\nYou open the door and walk into a narrow hallway with oil paintings of munchkins on both walls. As you walk past them, you can feel their eyes following you.\nWhen you reach the end of the hall, a large painting of the munchkin mayor drops down in front you like a guilliotine, blocking the way . . .");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("A booming voice from painting startles you: " + "MY TOWN IS USED TO YOUR KIND, PASSING THROUGH AS IF WE ARE SIMPLY BACKGROUND CHARACTERS IN YOUR OWN LITTLE ADVENTURE.\nWE ARE NOT HERE SIMPLY TO MAKE YOU SMILE AND THEN BE FORGOTTEN. WE MUNCHKINS NEVER FORGET.THE SELFFISHNESS OF OUTSIDERS TAINTS MY TRUST. ANSWER ME THIS, WHAT ARE YOU ABLE TO KEEP, EVEN AFTER GIVING IT TO SOMEONE?");
            do
            {
                Console.WriteLine("Choose an answer:\n" +
                        "L)Your life\n" +
                        "W)Your word\n" +
                        "T)Your trust\n" +
                        "E)Your time\n" +
                        "M)Your money");

                ConsoleKey riddleOneChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (riddleOneChoice)
                {

                    case ConsoleKey.L:
                        //INCLUDE PERSONAL MUSIC FOR EACH CHARACTER
                        Console.WriteLine("Pain fills your body . . .");
                        System.Threading.Thread.Sleep(1600);
                        Console.WriteLine("ONCE YOUR LIFE IS GIVEN, IT IS GONE, NOT KEPT! -5 to Life");
                        Console.ReadLine();
                        Console.Clear();
                        //Add Damage to Health
                        characterChoice.Life -= 5;
                        exit = true;
                        break;

                    case ConsoleKey.W:
                        Console.WriteLine("You feel better. . .");
                        System.Threading.Thread.Sleep(1600);
                        Console.WriteLine("THAT IS THE RIGHT ANSWER. MAY YOU HAVE THE STRENGTH AND INTEGRITY TO KEEP YOUR WORD FOR THE REST OF YOUR DAYS!");
                        Console.ReadLine();
                        Console.Clear();
                        exit = true;
                        break;

                    case ConsoleKey.T:
                        Console.WriteLine("Pain fills your body . . .");
                        System.Threading.Thread.Sleep(1600);
                        Console.WriteLine("THE LIAR GIVES TRUST BUT DOES NOT KEEP IT. -5 to Health");
                        Console.ReadLine();
                        Console.Clear();
                        //Add damage to health
                        characterChoice.Life -= 5;
                        exit = true;
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Pain fills your body . . .");
                        System.Threading.Thread.Sleep(1600);
                        Console.WriteLine("TIME IS FLEETING AND NEVER KEPT. -5 to Health");
                        Console.ReadLine();
                        Console.Clear();
                        //Add damage to health
                        characterChoice.Life -= 5;
                        exit = true;
                        break;

                    case ConsoleKey.M:
                        Console.WriteLine("Pain fills your body . . .");
                        System.Threading.Thread.Sleep(3200);
                        Console.WriteLine("MONEY CANNOT BE KEPT AFTER GIVING. -5 to Health");
                        Console.ReadLine();
                        Console.Clear();
                        //Add damage to health
                        characterChoice.Life -= 5;
                        exit = true;
                        break;

                    default:
                        exit = false;
                        Console.WriteLine("YOU MUST CHOOSE!");
                        break;

                }
            } while (!exit);
            #endregion

            #region Conservatory Battle
            Console.WriteLine("The painting slides up and you continue on your way until you reach a consertatory. Two leafless bonsais sit on the windowsill.\nUpon closer viewing, you discern small ghastly faces carved into their trunks and small arm-like, grasping branches. You see a large bush with pink flowers in the corner. The sweet aroma of the healthy flowers contradicts the stale air you've experienced thus far. Upon getting closer to smell one, the bush begins to shake violently.\nSomething emerges . . .");

            Console.ReadLine();
            Console.Clear();

            Crow c1 = new Crow("Crow", 10, 10, 1, 2, 1, 3, "Winged pest of the cornfields", 45, false);
            Crow c2 = new Crow("Crow Fiend", 13, 13, 2, 3, 2, 5, "Scarred crow with high pitch caw that summons others", 51, true);
            FlyingMonkey m1 = new FlyingMonkey("Flying Monkey", 11, 11, 4, 1, 1, 5, "Terrifying monkey of the skies", 49);
            FlyingMonkey m2 = new FlyingMonkey("Flying Gorilla", 15, 15, 4, 2, 2, 6, "Massive flying ape with a tough hide", 51);

            Enemy[] enemies =
                {
                    c1, c1, c1, c2, m1, m1, c2  //Higher chance of summoning weaker demon (imp) 
                    //Polymorphism in action with the demon objects in the Monster array

                };

            Enemy enemy = enemies[new Random().Next(enemies.Length)];  //new monster variable to pick random monster 
                                                                       //from length of monsters (max monsters)
            Console.WriteLine("It's a " + enemy.Name + "!");
            bool battleExit = true;
            bool death = true;
            do
            {

                Console.WriteLine("Choose an action:\n" +
                        "A)ttack \n" +
                        "P)layer Stats \n" +
                        "M)onster Stats \n" +
                        "E)xit");

                //Will need to split into three sections for each hero (p1,p2,p3)
                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();

                //STRAWMAN BONUS VS CROWS
                if (characterChoice == p1 && enemy == c1)
                {
                    p1.Block += 10;
                }


                switch (userChoice)
                {

                    case ConsoleKey.A:
                        Combat.DoBattle(characterChoice, enemy);

                        if (enemy.Life <= 0)
                        {
                            Console.WriteLine("You killed the {0}", enemy.Name);
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            battleExit = false;
                        }

                        break;

                    case ConsoleKey.P:
                        Console.WriteLine(characterChoice);
                        break;
                    case ConsoleKey.M:
                        Console.WriteLine(enemy);   //Added Info when hit M
                        break;
                    case ConsoleKey.E:
                        Console.WriteLine("Farewell...");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Make a choice");
                        break;
                }

                if (characterChoice.Life <= 0)
                {
                    Console.WriteLine("You have been slain by the {0}!",
                        enemy.Name);
                    Environment.Exit(0);

                } while (!battleExit && !death) ;

            } while (battleExit);
            //Victory and progression
            #endregion
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            #region Tortoise in the Kitchen
            Console.WriteLine("The beast lays dead at your feet. You turn from your fallen foe in the conservatory and begin descending down a flight of stairs. You end up in candlelit kitchen. The walls are a seemlingly cream color and the shadows of thick cobwebs swing in the candlelight. The window over the empty sink shows that it is completely dark outside which brings new feelings of isolation. You hear a crunch behind and when you turn around, you see a tortoise on the counter with a half eaten apple in front of it . . .");
            Console.ReadLine();
            Console.Clear();



            Console.WriteLine("Hmmm I'm Po. Could you do an ol' tortoise a favor and reach out that window and tell me the temperature outside(Fahrenheit)?");

            string celcs = Console.ReadLine();
            int numb = -1;
            if (!int.TryParse(celcs, out numb))
            {
                Console.WriteLine("Don't understand weather? mmmm");
            }

            else
            {
                int temper = int.Parse(celcs);

                int tempConvert = temper - 32 / (9 / 5);
                Console.WriteLine("So {0} degrees Celsius then. Hmmm. Too chilly for my liking. The tarantula who lives in the corner doesn't seem to mind, seeing as it's been hanging out in the bush under the window\nHumored a tortoise (+2 to health)", tempConvert);
                characterChoice.Life += 2;
            }

            Console.ReadLine();
            Console.Clear();
            //Change Converter
            Console.WriteLine("Not to get too personal, but hmmm how much money do you have on you? (example: 5.36, 8.50, 4, etc.)");


            string userEntry = Console.ReadLine();
            decimal num;
            if (!Decimal.TryParse(userEntry, out num))
            {
                Console.WriteLine("Hmmm that is not quite what I was looking for . . .");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                decimal dollars = Convert.ToDecimal(userEntry);
                int quarters, dimes, nickels, pennies;

                quarters = (int)(dollars / .25m);
                dollars = dollars % .25m;

                dimes = (int)(dollars / .10m);
                dollars = dollars % .10m;


                nickels = (int)(dollars / .05m);
                dollars = dollars % .05m;

                pennies = (int)(dollars / .01m);

                Console.WriteLine($"Hmmm so {quarters} quarters, {dimes} dimes, {nickels} nickels, and {pennies} pennies. I love counting change. \nHumored a tortoise (+2 to health)");
                characterChoice.Life += 2;
                Console.ReadLine();
                Console.Clear();

            }


            DateTime turtleBirth = new DateTime(1902, 06, 15, 09, 56, 0);
            DateTime turtleNow = DateTime.Now;
            TimeSpan turtleTime = turtleNow.Subtract(turtleBirth);
            Console.WriteLine("Hmmm You told me quite a bit of personal information about yourself so hmmm it'd only be fair if I shared a bit of personal information with you. I was born June 15, 1902. As of today, I am {0} days and {1} hour{2} old.",
                turtleTime.Days,
                turtleTime.Hours,
                turtleTime.Hours == 1 ? "" : "s");
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Thank you for humoring an ol' tortoise. You're very very kind. I hope you find what you're looking for. Hmmm also who are you again and why are in this house?");

            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("You leave the inquisitive tortoise on the counter and walk into the livng room. A mustard yellow floral couch sits in front of a small wooden coffee table. You can see a bright yellow door with a stenciled-in brick pattern beyond the living room. You have a deep apprehension to go out into the night. As you weigh your options, two legs covered in striped leggings unravel from under the couch and twist around each of your legs like pythons. A screech echos through the living room and a dark shadow forms in the wall. Something evil is here . . .");

            Console.ReadLine();
            Console.Clear();
            #endregion

            #region Living Room Witch Battle
            Witch w1 = new Witch("Wicked Western Witch", 15, 15, 3, 3, 3, 6, "Only cruelty follows in her wake", 35);
            Witch w2 = new Witch("Wicked Eastern Witch", 17, 17, 2, 3, 2, 4, "Less cruel than her western sister, but more durable", 25);
            WitchGuard g1 = new WitchGuard("Witch Guard", 13, 13, 4, 2, 2, 5, "Defender of Witch Tyranny", 35);
            WitchGuard g2 = new WitchGuard("Witch Honor Guard", 15, 15, 5, 2, 2, 6, "Heavily armored personal witch guard", 51);

            Enemy[] enemies2 =
                {
                    w1, w1, w2, w2, g1, g1, g2

                };

            Enemy enemy2 = enemies2[new Random().Next(enemies2.Length)];
                                                                          
            Console.WriteLine("It's a " + enemy2.Name + "!");
            bool battle2Exit = false;
            bool death2 = true;
            do
            {

                Console.WriteLine("Choose an action:\n" +
                        "A)ttack \n" +
                        "P)layer Stats \n" +
                        "M)onster Stats \n" +
                        "E)xit");


                ConsoleKey userChoice = Console.ReadKey(true).Key;
                Console.Clear();

                switch (userChoice)
                {

                    case ConsoleKey.A:
                        Combat.DoBattle(characterChoice, enemy2);
                        if (enemy2.Life <= 0)
                        {
                            Console.WriteLine("You killed the {0}", enemy2.Name);
                            System.Threading.Thread.Sleep(2000);
                            Console.Clear();
                            battle2Exit = true;
                        }

                        break;

                    case ConsoleKey.P:
                        Console.WriteLine(characterChoice);
                        break;

                    case ConsoleKey.M:
                        Console.WriteLine(enemy2);
                        break;

                    case ConsoleKey.E:
                        Console.WriteLine("Farewell...");
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Make a choice");
                        break;
                }

                if (p1.Life <= 0)
                {
                    Console.WriteLine("You have been slain by the {0}!",
                        enemy2.Name);
                    Console.ReadLine();
                    Console.WriteLine("Game Over");
                    Environment.Exit(0);

                } while (!battle2Exit && !death2) ;

            } while (!battle2Exit);

            //Console.WriteLine();
            #endregion

            #region Tornado Cutscene
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Enough is enough. You kick the now weakened serpentine legs away and march towards the door. You grab the door ice cold door knob and twist it. The door, though only wooden, feels like it weighs 500 lbs as you strain to pull it open enough to step through. There is only darkness beyond it. When you step out, you feel the humid air. Warm wind hits your face. It is silent at first, but then it begins to howl louder and louder until eventually it sounds like a train in speeding through your forehead. The tornado . . . It took you away and brought you back. It was the cause of so many things . . . people you loved were scattered away . . . your mind . . . shattered . . . were you ever really here or there?");

            Console.ReadLine();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Then a familiar woman's voice silences the roaring wind and echos in your mind. . . ");
            Console.ReadLine();
            Console.WriteLine(". . . Dorothy.");
            Console.ReadLine();
            Console.WriteLine("Am I here or am I back there? Or am I . . . in between?");
            Console.ReadLine();
            Console.Clear();

            #endregion

            #region The Wonderful Wizard
            Console.WriteLine("As you seem to fall deeper into the windy darkness, a small green star in dark appears. The green glow grows brighter and brighter until you begin to discern human features. It's an old bearded man's face and he's smiling.");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Hello again. You seem lost? Was the wish I granted you not enough? Are you still not satisfied? It's upsetting helping people only to watch them return time and time again.\nLife is relative. Everything is always out of reach . . . beyond the rainbow. Will you ever be whole? This I do not know. But you do interest me. Are you ready for another step down the endless road? Or are you finally ready to let go?");

            Console.ReadLine();

            do
            {
                Console.WriteLine("Choose an answer:\n" +
                        "L)et go and embrace the inevitable\n" +
                        "F)ocus\n" +
                        "A)ttack him\n"
                        );

                ConsoleKey wizardChoice = Console.ReadKey(true).Key;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                switch (wizardChoice)
                {

                    case ConsoleKey.L:

                        Console.WriteLine("You feel lighter and lighter as you fall deeper and deeper away.");
                        Console.ReadLine();
                        Console.WriteLine("The man's head smiles and fades away . . .");
                        Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Your last thoughts are wondering where you will wake up. . .");
                        System.Threading.Thread.Sleep(3200);
                        Console.WriteLine("The End . . .");
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;

                    case ConsoleKey.F:
                        Console.WriteLine("When you open your mouth, no words come out. Fear overwhelms you as the old man begins to smile. When he smiles in front of you, a familiarity grows . . . Dorothy . . . the yellow brick door. . . endless road . . . the wish. You were just like this before . . .");
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("You were with her, before you met him. You were supposed to be better now. But your loss . . . doesn't change the fact that you had good in you at one time. Remembering this awakens your senses. You find your voice again . . .");
                        Console.ReadLine();
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("I may have lost my gift, but I have not lost my resolve. I hate that I'm back to where I started, but I know even though I'm back to where I started, I have good intentions. And I will strive to maintain my character, no matter what physical or emotional setbacks I may face.");
                        Console.ReadLine();
                        Console.Clear();

                        Console.WriteLine("The Wizard stares a you and you even see a tear roll down his cheek as he begins to shrink. No matter what he was, he is gone. You feel a warmth you once knew. And knowing this warmth a second time makes you all the more gracious. You still see darkness, but you swear you can hear the straining ropes of a hot air balloon. You feel closer and closer to where everything made sense. And it fills you with joy . . .");

                        Console.ReadLine();

                        System.Threading.Thread.Sleep(3200);
                        Console.WriteLine("The End");
                        Console.ReadLine();
                        break;

                    case ConsoleKey.A:
                        Console.WriteLine("You glare at the old man's head. How dare he kick you when you are down. It matters not what he has given you. It's broken now. It's all broken. Your frustration takes over and you rush towards his menacing green face . . .");
                        Console.ReadLine();
                        Wizard z1 = new Wizard("Wonderful Wizard", 32, 32, 7, 4, 4, 12, "Is he a benevolent god or a prideful demon?", true);
                        Wizard z2 = new Wizard("Old man behind the curtain", 8, 8, 2, 1, 1, 3, "The liar himself. Pitiful.", false);

                        Enemy[] enemies3 = { z1, z1, z1, z1, z1, z1, z1, z1, z1, z1, z1, z2 };

                        Enemy enemy3 = enemies3[new Random().Next(enemies3.Length)];  //Rare chance to face weak true form

                        Console.WriteLine("It's a " + enemy3.Name + "!");
                        bool battle3Exit = false;
                        bool death3 = true;
                        do
                        {

                            Console.WriteLine("Choose an action:\n" +
                                    "A)ttack \n" +
                                    "P)layer Stats \n" +
                                    "M)onster Stats \n" +
                                    "E)xit");


                            ConsoleKey userChoice = Console.ReadKey(true).Key;
                            Console.Clear();

                            switch (userChoice)
                            {

                                case ConsoleKey.A:
                                    Combat.DoBattle(characterChoice, enemy3);
                                    if (enemy3.Life <= 0)
                                    {
                                        Console.WriteLine("You killed the {0}", enemy3.Name);
                                        System.Threading.Thread.Sleep(2000);
                                        Console.Clear();
                                        battle3Exit = true;
                                    }

                                    break;

                                case ConsoleKey.P:
                                    Console.WriteLine(characterChoice);
                                    break;

                                case ConsoleKey.M:
                                    Console.WriteLine(enemy3);
                                    break;

                                case ConsoleKey.E:
                                    Console.WriteLine("Farewell...");
                                    Environment.Exit(0);
                                    break;

                                default:
                                    Console.WriteLine("Make a choice");
                                    break;
                            }

                            if (p1.Life <= 0)
                            {
                                Console.WriteLine("Your existence has been vaporized by the {0}!",
                                    enemy3.Name);
                                Console.ReadLine();
                                Console.WriteLine("Game Over");
                                Environment.Exit(0);

                            } while (!battle3Exit && !death3) ;

                        } while (!battle3Exit);
                        Console.WriteLine("You watch as fear enters his face, mirroring your own.The old man screams and bellows smoke from his mouth, covering his features. Soon his cries are drowned out by the stormy wind. When the smoke clears you see. . .");
                        System.Threading.Thread.Sleep(5400);
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("yourself");
                        System.Threading.Thread.Sleep(3600);
                        Console.WriteLine("In a moment you are sent beaming through the universe, unimaginable energy flowing through your veins. You know you've lost something dear . . . but the exhilaration is too strong. You're an all powerful wizard now and so, you think. . . it matters not.");
                        System.Threading.Thread.Sleep(4000);
                        Console.WriteLine("The End");
                        Environment.Exit(0);
                        break;
                }
            } while (!exit);

            #endregion

            //Need to Do
            //Make Final Boss Fight Clean

            //Ideas for Additional Content
            //Add Dorothy as a hidden playable character who overwrites the current characterChoice
            



        }
    }//end class
}//end namespace

