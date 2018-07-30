using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLab9
{
    class Program
    {
        public static int Count { get; private set; }

        private class Student
            {

                public string name;
                public readonly List<string> InfoName;
            private readonly List<string> infoBody;

            public List<string> InfoBody => infoBody;

            public Student()
                {
                    name = "";
                    InfoName = new List<string>();
                    infoBody = new List<string>();

                }

            }

            static Student[] CreateRoster()
            {

                Student[] classList = new Student[20];

                for (int i = 0; i < classList.Length; i++)
                {

                    classList[i] = new Student();

                }

                classList[0].name = "William Twomey";
                classList[0].InfoName.Add("nickname");
                classList[0].InfoBody.Add("Ash, similar to Ash from Pokemon, however he was actually named after Ash Williams from the Evil Dead trilogy so now Terrell can stop with the Pokemon talk. He probably won't though.");
                classList[0].InfoName.Add("favorite meme");
                classList[0].InfoBody.Add("Take a closer look at that snout! Just a clip from a nature documentary that is very versatile in uses. Also elephant shrews are just kinda goofy lookin', ya feel me?");

                classList[1].name = "Dr. K";
                classList[1].InfoName.Add("hometown");
                classList[1].InfoBody.Add("Detroit. Hey, that's where we are!");
                classList[1].InfoName.Add("favorite food");
                classList[1].InfoBody.Add("Burgers.");

                classList[2].name = "Jacob Snover";
                classList[2].InfoName.Add("hometown");
                classList[2].InfoBody.Add("Merrillville. That's near Gary. Geary? I think it's in Indiana...");
                classList[2].InfoName.Add("favorite food");
                classList[2].InfoBody.Add("Pizza.");

                classList[3].name = "Kristen Rieske";
                classList[3].InfoName.Add("favorite cod");
                classList[3].InfoBody.Add("Black Ops 2. Me personally, I think BO3 was pretty good but I'm just a filthy zombies player so what do I know.");
                classList[3].InfoName.Add("college studies");
                classList[3].InfoBody.Add("Physics.");

                classList[4].name = "Student 5";
                classList[4].InfoName.Add("something cool");
                classList[4].InfoBody.Add("cool it worked");
                classList[4].InfoName.Add("something amazing");
                classList[4].InfoBody.Add("*Lifts car*");

                classList[5].name = "Lucifer S. Aeytan";
                classList[5].InfoName.Add("favorite number");
                classList[5].InfoBody.Add("66666666666666666... Likes lots of sixes...");
                classList[5].InfoName.Add("favorite hobby");
                classList[5].InfoBody.Add("Messing with the lives of mortals.");

                classList[6].name = "RNGesus";
                classList[6].InfoName.Add("7");
                classList[6].InfoBody.Add("...out of 20 is a pretty bad roll, the dragon roasts you alive.");
                classList[6].InfoName.Add("roll for dex");
                classList[6].InfoBody.Add("You roll a 1. You drop your bow and it somehow fires into your face. You died.");

                classList[7].name = "Arima Kousei";
                classList[7].InfoName.Add("favorite food");
                classList[7].InfoBody.Add("Egg salad sandwiches. This guy can go on and on about them...");
                classList[7].InfoName.Add("colorblindness");
                classList[7].InfoBody.Add("He no longer sees the world in monochrome but that wasn't a cheap upgrade.");

                classList[8].name = "Fictional Person 445";
                classList[8].InfoName.Add("favorite mode of transportation");
                classList[8].InfoBody.Add("Yeetasaurus-Rex. This dude memes on the haters.");
                classList[8].InfoName.Add("why im like this");
                classList[8].InfoBody.Add("I really don't know.");

                classList[9].name = "Death Metal Kitten";
                classList[9].InfoName.Add("favorite champion");
                classList[9].InfoBody.Add("Nidalee, she turns in to a cat.");
                classList[9].InfoName.Add("favorite game");
                classList[9].InfoBody.Add("League of Please-Stop-playing-this-Broken-Game");

                classList[10].name = "Kamina";
                classList[10].InfoName.Add("fighting style");
                classList[10].InfoBody.Add("All in, never look back, pure anime fighting spirit!");
                classList[10].InfoName.Add("lifestyle");
                classList[10].InfoBody.Add("Depending on where you are in the show: no.");

                classList[11].name = "Lex";
                classList[11].InfoName.Add("forehead size");
                classList[11].InfoBody.Add("Bigger than a school bus.");
                classList[11].InfoName.Add("favorite movie");
                classList[11].InfoBody.Add("ANYTHING without those little yellow minions in it.");

                classList[12].name = "Ali-A";
                classList[12].InfoName.Add("intro");
                classList[12].InfoBody.Add("*Loud bass-boosted music plays*");
                classList[12].InfoName.Add("favorite game");
                classList[12].InfoBody.Add("\"Fortnite\"");

                classList[13].name = "Ajit Pai";
                classList[13].InfoName.Add("favorite hobby");
                classList[13].InfoBody.Add("Returning humanity to the Dark Ages");
                classList[13].InfoName.Add("favorite food");
                classList[13].InfoBody.Add("Hopes and dreams of a true free market.");

                classList[14].name = "Mark Zuckerberg";
                classList[14].InfoName.Add("species");
                classList[14].InfoBody.Add("Some sort of reptile, I think. Like an Argonian from Skyrim.");
                classList[14].InfoName.Add("data");
                classList[14].InfoBody.Add("Error: OverflowException\nWay too much data on EVERYONE\nThe CIA should hire this dude.");

                classList[15].name = "Elon Musk";
                classList[15].InfoName.Add("overwatch rank");
                classList[15].InfoBody.Add("If this dude finds Overwatch soothing, there's no way he's anywhere above gold.");
                classList[15].InfoName.Add("fun machines");
                classList[15].InfoBody.Add("Elon's collection includes: Flamethrowers, Rockets, Electric cars (in space), probably his own personal super computer.");

                classList[16].name = "Bill Gates";
                classList[16].InfoName.Add("net worth");
                classList[16].InfoBody.Add("93.3 Billion USD. \nyikes");
                classList[16].InfoName.Add("fun");
                classList[16].InfoBody.Add("Probably pretends to be one of the little kids who pretends to be more powerful than he really is on Xbox Live. It's fun because Bill could do anything he wants to anyone in his lobby.");

                classList[17].name = "Bricky";
                classList[17].InfoName.Add("favorite operator");
                classList[17].InfoBody.Add("Brazilian Spook Factory (Caveira)");
                classList[17].InfoName.Add("intelligence");
                classList[17].InfoBody.Add("INT: 1");

                classList[18].name = "David Hasselhoff";
                classList[18].InfoName.Add("things he wants to love");
                classList[18].InfoBody.Add("You: all night long, with his song.");
                classList[18].InfoName.Add("survivor status");
                classList[18].InfoBody.Add("True");

                classList[19].name = "Final Boss";
                classList[19].InfoName.Add("roll");
                classList[19].InfoBody.Add("You dodged his attack but you rolled off the edge and suffered an environmental death.");
                classList[19].InfoName.Add("attack");
                classList[19].InfoBody.Add("You swing your sword but are killed midway through your attack. git gud.");

                //List<student> roster = classList.OfType<student>().ToList();
                //return roster;

                return classList;

            }

        private static bool KeepLearning()
            {

                bool whileBreak = false;
                string cont = "";

                Console.WriteLine("Would you like to learn more? (Y/N)");

                do
                {

                    try
                    {

                        cont = Console.ReadLine();

                        if (cont.ToLower() == "yes" || cont.ToLower() == "y")
                        {

                            return true;

                        }
                        else if (cont.ToLower() == "no" || cont.ToLower() == "n")
                        {

                            return false;

                        }
                        else
                        {

                            Console.WriteLine("Error! ID: 10-T.");
                            Console.WriteLine("This time follow the prompt.");

                        }

                    }
                    catch (OverflowException)
                    {

                        Console.WriteLine("Entry was too large.");
                        Console.WriteLine("Try using a sinlge letter like I asked for.");

                    }
                    catch (NullReferenceException)
                    {

                        Console.WriteLine("CTRL + Z was a cool trick until everyone knew it.");
                        Console.WriteLine("A for effort though...");

                    }

                    Console.WriteLine("Please enter Y or N: ");

                } while (!whileBreak);

                return false;

            }

            static void FunFact(Student subject, int selection)
            {

                if (selection >= 0 || selection < subject.InfoBody.Count)
                {

                    Console.WriteLine(subject.InfoBody[selection]);

                }
                else
                {

                    Console.WriteLine("Here's a catch all statement because some unexpected error occured.");

                }

            }

            static int SelectStudent(int length)
            {
                do
                {

                    Console.WriteLine(value: $"Please enter a number 1 through {length} (inlusive): ");

                    try
                {
                    object  = ();
                    var output = int.Parse(s: Console.ReadLine() ?? ) - 1;

                    if (output <= length && output >= 1)
                    {

                        //Console.WriteLine($"You have selected {roster[output]}!");
                        return output;

                    }
                    else
                    {

                        Console.WriteLine(value: "Error! ID: 10-T.");
                        Console.WriteLine(value: "This time follow the prompt.");

                    }
                }
                catch (OverflowException)
                    {

                        Console.WriteLine(value: "Entry was too WAY large.");

                    }
                    catch (NullReferenceException)
                    {

                        Console.WriteLine(value: "You know very well what you did and were trying to do, shame on you!");

                    }

                } while (true);

            }

        private static string NewMethod() => throw new InvalidOperationException();

        static int FactSelector(Student subject)
            {

                string selection = "";
                Console.Write($"Would you like to learn about {subject.name}'s "); //{subject.infoName1} or {subject.infoName2}?");

                for (int i = 0; i < subject.InfoName.Count - 1; i++)
                {

                    Console.Write($"{subject.InfoName[i]}, ");

                }

                Console.Write($"or {subject.InfoName[subject.InfoName.Count - 1]}.\n");

                do
                {

                    try
                    {

                        int ind = -1;
                        int counter = 0;

                        selection = Console.ReadLine();

                        foreach (string name in subject.InfoName)
                        {

                            if (name == selection)
                            {

                                return counter;

                            }

                            counter++;

                        }

                        if (ind == -1)
                        {

                            Console.WriteLine("Error! ID: 10-T.");
                            Console.WriteLine("This time follow the prompt.");

                        }

                    }
                    catch (OverflowException)
                    {

                        Console.WriteLine("Entry was too large.");

                    }
                    catch (NullReferenceException)
                    {

                        Console.WriteLine("Ha ha, very funny. Stop trying this though. I'm copy and pasting these exception handlers everywhere.");

                    }

                    Console.Write("Please enter: ");

                    for (int i = 0; i < subject.InfoName.Count - 1; i++)
                    {

                        Console.Write($"{subject.InfoName[i]}, ");

                    }

                    Console.Write($"or {subject.InfoName[subject.InfoName.Count - 1]}.\n");

                } while (true);

            }

            static bool MoreFacts()
            {

                bool whileBreak = false;
                string cont = "";

                Console.WriteLine("Would you like to learn about a student or add an entry? (L/A)");

                do
                {

                    try
                    {

                        cont = Console.ReadLine();

                        if (cont.ToLower() == "learn" || cont.ToLower() == "l")
                        {

                            return true;

                        }
                        else if (cont.ToLower() == "add" || cont.ToLower() == "a")
                        {

                            return false;

                        }
                        else
                        {

                            Console.WriteLine("Error! ID: 10-T.");
                            Console.WriteLine("This time follow the prompt.");

                        }

                    }
                    catch (OverflowException)
                    {

                        Console.WriteLine("Entry was too large.");
                        Console.WriteLine("Try using a sinlge letter like I asked for.");

                    }
                    catch (NullReferenceException)
                    {

                        Console.WriteLine("CTRL + Z was a cool trick until everyone knew it.");
                        Console.WriteLine("A for effort though...");

                    }

                    Console.WriteLine("Please enter L or A: ");

                } while (!whileBreak);

                return false;

            }

            static bool Exists()
            {

                bool whileBreak = false;
                string cont = "";

                Console.WriteLine("Would you like to add to an existing student or add a new student? (E/N)");

                do
                {

                    try
                    {

                        cont = Console.ReadLine();

                        if (cont.ToLower() == "existing" || cont.ToLower() == "e")
                        {

                            return true;

                        }
                        else if (cont.ToLower() == "new" || cont.ToLower() == "n")
                        {

                            return false;

                        }
                        else
                        {

                            Console.WriteLine("Error! ID: 10-T.");
                            Console.WriteLine("This time follow the prompt.");

                        }

                    }
                    catch (OverflowException)
                    {

                        Console.WriteLine("Entry was too large.");
                        Console.WriteLine("Try using a sinlge letter like I asked for.");

                    }
                    catch (NullReferenceException)
                    {

                        Console.WriteLine("CTRL + Z was a cool trick until everyone knew it.");
                        Console.WriteLine("A for effort though...");

                    }

                    Console.WriteLine("Please enter Y or N: ");

                } while (!whileBreak);

                return false;

            }

            static Student CreateStudent()
            {

                Student temp = new Student();

                Console.WriteLine("Please name your student: ");
                temp.name = Console.ReadLine();
                char cont = 'y';

                do
                {

                    Console.WriteLine("Please enter your fact subject. (i.e. nickname, hometown, favorite food, etc.: ");
                    temp.InfoName.Add(Console.ReadLine());

                    Console.WriteLine("Please enter the fact itself: ");
                    temp.InfoBody.Add(Console.ReadLine());

                    bool whileBreak = false;

                    do
                    {

                        try
                        {

                            Console.WriteLine("Would you like to add another fact? (Y/N)");
                            cont = Char.Parse(Console.ReadLine().ToLower());
                            if (cont == 'y' || cont == 'n')
                            {

                                whileBreak = true;

                            }
                            else
                            {

                                Console.WriteLine("Y or N please.");

                            }

                        }
                        catch (FormatException)
                        {

                            Console.WriteLine("Nice format exception! Try a single digit next time.");

                        }
                        catch (NullReferenceException)
                        {

                            Console.WriteLine("CTRL+Z isn't funny anymore.");

                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("An unknown error occured: " + e);

                        }

                    } while (whileBreak);

                } while (cont == 'y');

                return temp;

            }

            static Student EditStudent(Student subject)
            {

                char cont = 'y';

                do
                {

                    Console.WriteLine("Please enter your fact subject. (i.e. nickname, hometown, favorite food, etc.: ");
                    subject.InfoName.Add(Console.ReadLine());

                    Console.WriteLine("Please enter the fact itself: ");
                    subject.InfoBody.Add(Console.ReadLine());

                    bool whileBreak = false;

                    do
                    {

                        try
                        {

                            Console.WriteLine("Would you like to add another fact? (Y/N)");
                            cont = Char.Parse(Console.ReadLine().ToLower());
                            if (cont == 'y' || cont == 'n')
                            {

                                whileBreak = true;

                            }
                            else
                            {

                                Console.WriteLine("Y or N please.");

                            }

                        }
                        catch (FormatException)
                        {

                            Console.WriteLine("Nice format exception! Try a single digit next time.");

                        }
                        catch (NullReferenceException)
                        {

                            Console.WriteLine("CTRL+Z isn't funny anymore.");

                        }
                        catch (Exception e)
                        {

                            Console.WriteLine("An unknown error occured: " + e);

                        }

                    } while (whileBreak);

                } while (cont == 'y');

                return subject;

            }

            static void Main(string[] args)
            {

                Student[] roster = CreateRoster();
                List<Student> classList = roster.OfType<Student>().ToList();

                Console.WriteLine("Welcome to the Made-Up-Info-About-This-Class Wiki!");
                int stuSel = 0;
                int inSel = 0;

                do
                {
                    for (int i = 0; i<>[.Count; i++) //displays table
                    {
                        Console.WriteLine(StudentName[i]);
                    }
                if (MoreFacts())
                    {

                        stuSel = SelectStudent(classList.Count);
                        inSel = FactSelector(classList[stuSel]);
                        FunFact(classList[stuSel], inSel);

                    }
                    else
                    {

                        if (Exists())
                        {

                            stuSel = SelectStudent(classList.Count);
                            classList[stuSel] = EditStudent(classList[stuSel]);

                        }
                        else
                        {

                            classList.Add(CreateStudent());

                        }

                    }

                } while (KeepLearning());

                Console.WriteLine("See ya next time...");

            }

        }

    }

    

