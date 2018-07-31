using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ArrayListLab9
{
    class Program
    {
        //public static int Count { get; private set; }

        private class Student
        {

            public string Name;
            public readonly List<string> InfoName;

            public List<string> InfoBody { get; }

            public Student()
            {
                Name = "";
                InfoName = new List<string>();
                InfoBody = new List<string>();

            }

        }

        static Student[] CreateRoster()
        {

            Student[] classList = new Student[20];

            for (int i = 0; i < classList.Length; i++)
            {

                classList[i] = new Student();

            }

            classList[0].Name = "Amire Cross";
            classList[0].InfoName.Add("nickname");
            classList[0].InfoBody.Add("Mir");
            classList[0].InfoName.Add("favorite meme");
            classList[0].InfoBody.Add("Birds");

            classList[1].Name = "Drew";
            classList[1].InfoName.Add("hometown");
            classList[1].InfoBody.Add("Detroit");
            classList[1].InfoName.Add("favorite food");
            classList[1].InfoBody.Add("tacos");

            classList[2].Name = "Jacob Snover";
            classList[2].InfoName.Add("hometown");
            classList[2].InfoBody.Add("Merrillville");
            classList[2].InfoName.Add("Favorite food");
            classList[2].InfoBody.Add("Pizza.");

            classList[3].Name = "Kristen Rieske";
            classList[3].InfoName.Add("Favorite cod");
            classList[3].InfoBody.Add("Black Ops 2.");
            classList[3].InfoName.Add("college studies");
            classList[3].InfoBody.Add("Physics.");

            classList[4].Name = "Tyire Cross";
            classList[4].InfoName.Add("something cool");
            classList[4].InfoBody.Add("cool");
            classList[4].InfoName.Add("something amazing");
            classList[4].InfoBody.Add("*just learned how to crawl");

            classList[5].Name = "James Gill";
            classList[5].InfoName.Add("Favorite number");
            classList[5].InfoBody.Add("75");
            classList[5].InfoName.Add("favorite hobby");
            classList[5].InfoBody.Add("Sitting outside");

            classList[6].Name = "Jordan";
            classList[6].InfoName.Add("Best year?");
            classList[6].InfoBody.Add("97'");
            classList[6].InfoName.Add("Best player");
            classList[6].InfoBody.Add("Me");

            classList[7].Name = "Goku";
            classList[7].InfoName.Add("favorite food");
            classList[7].InfoBody.Add("anything that he can put in his moouth");
            classList[7].InfoName.Add("Favorite Syain");
            classList[7].InfoBody.Add("4 i miss my tail");

            classList[8].Name = "Trunks";
            classList[8].InfoName.Add("favorite mode of transportation");
            classList[8].InfoBody.Add("instant transmtion");
            classList[8].InfoName.Add("why im like this");
            classList[8].InfoBody.Add("I went back in time fucked shit up.");

            classList[9].Name = "Goten";
            classList[9].InfoName.Add("favorite champion");
            classList[9].InfoBody.Add("My Pops");
              classList[9].InfoName.Add("favorite game");
            classList[9].InfoBody.Add("League of Please-Stop-playing-this-Broken-Game");

            classList[10].Name = "Subzero";
            classList[10].InfoName.Add("fighting style");
            classList[10].InfoBody.Add("All in, never look back, pure anime fighting spirit!");
            classList[10].InfoName.Add("lifestyle");
            classList[10].InfoBody.Add("Depending on where you are in the show: no.");

            classList[11].Name = "Lex";
            classList[11].InfoName.Add("forehead size");
            classList[11].InfoBody.Add("Bigger than a school bus.");
            classList[11].InfoName.Add("favorite movie");
            classList[11].InfoBody.Add("ANYTHING without those little yellow minions in it.");

            classList[12].Name = "Ali-A";
            classList[12].InfoName.Add("intro");
            classList[12].InfoBody.Add("*Loud bass-boosted music plays*");
            classList[12].InfoName.Add("favorite game");
            classList[12].InfoBody.Add("\"Fortnite\"");

            classList[13].Name = "Ajit Pai";
            classList[13].InfoName.Add("favorite hobby");
            classList[13].InfoBody.Add("Returning humanity to the Dark Ages");
            classList[13].InfoName.Add("favorite food");
            classList[13].InfoBody.Add("Hopes and dreams of a true free market.");

            classList[14].Name = "Mark Zuckerberg";
            classList[14].InfoName.Add("species");
            classList[14].InfoBody.Add("Some sort of reptile, I think. Like an Argonian from Skyrim.");
            classList[14].InfoName.Add("data");
            classList[14].InfoBody.Add("Error: OverflowException\nWay too much data on EVERYONE\nThe CIA should hire this dude.");

            classList[15].Name = "Elon Musk";
            classList[15].InfoName.Add("overwatch rank");
            classList[15].InfoBody.Add("If this dude finds Overwatch soothing, there's no way he's anywhere above gold.");
            classList[15].InfoName.Add("fun machines");
            classList[15].InfoBody.Add("Elon's collection includes: Flamethrowers, Rockets, Electric cars (in space), probably his own personal super computer.");

            classList[16].Name = "Bill Gates";
            classList[16].InfoName.Add("net worth");
            classList[16].InfoBody.Add("93.3 Billion USD.");
            classList[16].InfoName.Add("fun");
            classList[16].InfoBody.Add("Probably pretends to be one of the little kids who pretends to be more powerful than he really is on Xbox Live. It's fun because Bill could do anything he wants to anyone in his lobby.");

            classList[17].Name = "Dr.j";
            classList[17].InfoName.Add("favorite move");
            classList[17].InfoBody.Add("out of bonds dunking");
            classList[17].InfoName.Add("intelligence");
            classList[17].InfoBody.Add("INT: 1");

            classList[18].Name = "Lil wayne";
            classList[18].InfoName.Add("things he wants to love");
            classList[18].InfoBody.Add("Pusssy, money, weed!");
            classList[18].InfoName.Add("survivor status");
            classList[18].InfoBody.Add("True");

            classList[19].Name = "Jmp";
            classList[19].InfoName.Add("Favorite game");
            classList[19].InfoBody.Add("pokemon");
            classList[19].InfoName.Add("Hobby");
            classList[19].InfoBody.Add("loves to smoke");

            //List<student> roster = classList.OfType<student>().ToList();
            //return roster;

            return classList;

        }

        private static bool KeepLearning()
        {
            string cont = "";

            Console.WriteLine("Would you like to learn more? (Y/N)");

            do
            {

                try
                {

                    cont = Console.ReadLine();

                    if (cont != null && (cont.ToLower() == "yes" || cont.ToLower() == "y"))
                    {

                        return true;

                    }

                    if (cont != null && (cont.ToLower() == "no" || cont.ToLower() == "n"))
                    {

                        return false;

                    }

                    Console.WriteLine("Error!");
                    Console.WriteLine("Redo the prompt");

                }
                catch (OverflowException)
                {

                    Console.WriteLine("Entry was too large.");
                    Console.WriteLine("Redo the prompt");

                }
                catch (NullReferenceException)
                {

                    Console.WriteLine("CTRL + Z was a cool trick until everyone knew it.");
                    Console.WriteLine("lmao");

                }

                Console.WriteLine("Please enter Y or N: ");

            } while (true);

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

        static int SelectStudent(List<Student> roster)
        {

            for (int i = 0; i < roster.Count; i++)
            {

                Console.WriteLine($"{i + 1}. {roster[i].Name}");

            }

            do
            {

                Console.WriteLine(value: $"Please enter a number 1 through {roster.Count} (inlusive): ");
            
                try
                {
                    //object  = ();
                    var output = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
                    output--;
                    if (output <= roster.Count && output >= 1)
                    {

                        //Console.WriteLine($"You have selected {roster[output]}!");
                        return output;

                    }

                    Console.WriteLine(value: "Error!");
                    Console.WriteLine(value: "This time follow the prompt.");
                }
                catch (OverflowException)
                {

                    Console.WriteLine(value: "Entry was too WAY large.");

                }
                catch (NullReferenceException)
                {

                    Console.WriteLine(value: "Error!!!!");

                }

            } while (true);

        }

        //private static string NewMethod() => throw new InvalidOperationException();

        static int FactSelector(Student subject)
        {
            Console.Write($"Would you like to learn about {subject.Name}'s "); //{subject.infoName1} or {subject.infoName2}?");
            

            for (int i = 1; i < subject.InfoName.Count -1; i++)
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

                    var selection = Console.ReadLine();

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

                        Console.WriteLine("Error!");
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
            Console.WriteLine("Would you like to learn about a student or add an entry? (L/A)");

            do
            {

                try
                {
                    var cont = Console.ReadLine();

                    if (cont != null)
                        switch (cont.ToLower())
                        {
                            case "learn":
                            case "l":
                                return true;
                            case "add":
                            case "a":
                                return false;
                            default:
                                Console.WriteLine("Error! ");
                                Console.WriteLine("This time follow the prompt.");
                                break;
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

            } while (true);
        }

        static bool Exists()
        {
            Console.WriteLine("Would you like to add to an existing student or add a new student? (E/N)");

            do
            {

                try
                {
                    var cont = Console.ReadLine();

                    if (cont != null && (cont.ToLower() == "existing" || cont.ToLower() == "e"))
                    {

                        return true;

                    }

                    if (cont != null && (cont.ToLower() == "new" || cont.ToLower() == "n"))
                    {

                        return false;

                    }

                    Console.WriteLine("Error! ID: 10-T.");
                    Console.WriteLine("This time follow the prompt.");
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

            } while (true);
        }

        static Student CreateStudent()
        {

            Student temp = new Student();

            Console.WriteLine("Please name your student: ");
            temp.Name = Console.ReadLine();
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
                        cont = Char.Parse(Console.ReadLine()?.ToLower() ?? throw new InvalidOperationException());
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

                } while (!whileBreak);

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
                        cont = Char.Parse(Console.ReadLine()?.ToLower() ?? throw new InvalidOperationException());
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

         static void Main()
        {

            Student[] roster = CreateRoster();
            // ReSharper disable once RedundantEnumerableCastCall
            List<Student> classList = roster.OfType<Student>().ToList();

            Console.WriteLine("Welcome to the Made-Up-Info-About-This-Class Wiki!");
            do
            {
                for (int i = 0; i < classList.Count; i++) //displays table
                {
                    Console.WriteLine($"{i + 1}. {classList[i].Name}");
                }
                int stuSel = 0;
                if (MoreFacts())
                {

                    stuSel = SelectStudent(classList);
                    var inSel = FactSelector(classList[stuSel]);
                    FunFact(classList[stuSel], inSel);

                }
                else
                {

                    if (Exists())
                    {

                        stuSel = SelectStudent(classList);
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



