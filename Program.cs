using System;
using System.Collections.Generic;
using System.Linq;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank newBank = new Bank();
            double TotalPayPercent = 100;
            var rolodex = new List<IRobber>();
            var robber1 = new Muscle()
            {
                Name = "Subway",
                SkillLevel = 100,
                PercentageCut = 20,
            };
            var robber2 = new Muscle()
            {
                Name = "Garrett",
                SkillLevel = 55,
                PercentageCut = 20,
            };
            var robber3 = new LockSpec()
            {
                Name = "John Boy",
                SkillLevel = 100,
                PercentageCut = 20,
            };
            var robber4 = new Hacker()
            {
                Name = "Namita",
                SkillLevel = 100,
                PercentageCut = 20,
            };
            var robber5 = new Muscle()
            {
                Name = "James",
                SkillLevel = 100,
                PercentageCut = 80,
            };
            var robber6 = new Hacker()
            {
                Name = "Heidi",
                SkillLevel = 67,
                PercentageCut = 54,
            };
            var robber7 = new LockSpec()
            {
                Name = "Jansen",
                SkillLevel = 62,
                PercentageCut = 34,
            };
            var robber8 = new Hacker()
            {
                Name = "Holden",
                SkillLevel = 67,
                PercentageCut = 45,
            };
            var robber9 = new Hacker()
            {
                Name = "Taylor",
                SkillLevel = 72,
                PercentageCut = 30,
            };

            rolodex.Add(robber1);
            rolodex.Add(robber2);
            rolodex.Add(robber3);
            rolodex.Add(robber4);
            rolodex.Add(robber5);
            rolodex.Add(robber6);
            rolodex.Add(robber7);
            rolodex.Add(robber8);
            rolodex.Add(robber9);
            Console.WriteLine(rolodex.Count);
            Console.WriteLine(@"
||====================================================================||
||//$\\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\//$\\||
||(100)==================| FEDERAL RESERVE NOTE |================(100)||
||\\$//        ~         '------========--------'                \\$//||
||<< /        /$\              // ____ \\                         \ >>||
||>>|  12    //L\\            // ///..) \\         L38036133B   12 |<<||
||<<|        \\ //           || <||  >\  ||                        |>>||
||>>|         \$/            ||  $$ --/  ||        One Hundred     |<<||
||<<|      L38036133B        *\\  |\_/  //* series                 |>>||
||>>|  12                     *\\/___\_//*   1989                  |<<||
||<<\      Treasurer     ________/HEIST\_________     Secretary 12 />>||
||//$\                ~| TEXTUAL ESPIONAGE ACTION |~              /$\\||
||(100)=================  HIDDEN IN PLAIN SIGHT  ================(100)||
||\\$//\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\/\\$//||
||====================================================================||
            ");
            Console.WriteLine();
            Console.WriteLine("Plan Your...");
            Console.WriteLine(@"
 __  __     ______     __     ______     ______
/\ \_\ \   /\  ___\   /\ \   /\  ___\   /\__  _\
\ \  __ \  \ \  __\   \ \ \  \ \___  \  \/_/\ \/
 \ \_\ \_\  \ \_____\  \ \_\  \/\_____\    \ \_\
  \/_/\/_/   \/_____/   \/_/   \/_____/     \/_/
                                                    ");
            while (true)
            {
                Console.WriteLine("Please enter a new member name");
                var newMemberName = Console.ReadLine();
                if (newMemberName == "")
                {
                    break;
                }
                while (true)
                {
                    Console.Write("What is their speciality? Hackers disable alarms, Muscle handles the guards, and Lockspec cracks the vault.");
                    var newMemberSpeciality = Console.ReadLine();
                    if (newMemberSpeciality == "Muscle")
                    {
                        Muscle newMuscle = new Muscle()
                        {
                        Name = newMemberName
                        };
                        Console.WriteLine("Please enter Skill Level (1-100)");
                        var newMemberSkillLevel = Console.ReadLine();
                        try
                        {
                            int newMemberSkillLevelNumber = int.Parse(newMemberSkillLevel);
                        }
                        catch
                        {
                            Console.WriteLine($"No Bueno, that's not a number.");
                        }
                        newMuscle.SkillLevel = int.Parse(newMemberSkillLevel);
                        Console.WriteLine("What is this member's percentage pay cut? (1-100)");
                        var newMemberPayPercentage = Console.ReadLine();
                        try
                        {
                            int newMemberPayPercentageNumber = int.Parse(newMemberPayPercentage);
                        }
                        catch
                        {
                            Console.WriteLine($"No Bueno, that's not a number.");
                        }
                        rolodex.Add(newMuscle);
                        break;
                    }
                    else if (newMemberSpeciality == "Hacker")
                    {
                        Hacker newHacker = new Hacker()
                        {
                        Name = newMemberName
                        };
                        Console.WriteLine("Please enter Skill Level (1-100)");
                        var newMemberSkillLevel = Console.ReadLine();
                        try
                        {
                            int newMemberSkillLevelNumber = int.Parse(newMemberSkillLevel);
                        }
                        catch
                        {
                            Console.WriteLine($"No Bueno, that's not a number.");
                        }
                        newHacker.SkillLevel = int.Parse(newMemberSkillLevel);
                        Console.WriteLine("What is this member's percentage pay cut? (1-100)");
                        var newMemberPayPercentage = Console.ReadLine();
                        try
                        {
                            int newMemberPayPercentageNumber = int.Parse(newMemberPayPercentage);
                        }
                        catch
                        {
                            Console.WriteLine($"No Bueno, that's not a number.");
                        }
                        rolodex.Add(newHacker);
                        break;
                    }
                    else if (newMemberSpeciality == "LockSpec")
                    {
                        LockSpec newLockSpec = new LockSpec()
                        {
                        Name = newMemberName
                        };
                        Console.WriteLine("Please enter Skill Level (1-100)");
                        var newMemberSkillLevel = Console.ReadLine();
                        try
                        {
                            int newMemberSkillLevelNumber = int.Parse(newMemberSkillLevel);
                        }
                        catch
                        {
                            Console.WriteLine($"No Bueno, that's not a number.");
                        }
                        newLockSpec.SkillLevel = int.Parse(newMemberSkillLevel);
                        Console.WriteLine("What is this member's percentage pay cut? (1-100)");
                        var newMemberPayPercentage = Console.ReadLine();
                        try
                        {
                            int newMemberPayPercentageNumber = int.Parse(newMemberPayPercentage);
                        }
                        catch
                        {
                            Console.WriteLine($"No Bueno, that's not a number.");
                        }
                        rolodex.Add(newLockSpec);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is a not a Valid speciality. Please try again.");
                    }
                    foreach (var member in rolodex)
                    {
                        Console.WriteLine(member.Name);
                    }
                }
            }
            Dictionary<string, int> bankScores = new Dictionary<string, int>();

            Random rand = new Random();
            var AlarmScore = rand.Next(0, 101);
            var VaultScore = rand.Next(0, 101);
            var SecurityGuardScore = rand.Next(0, 101);
            var CashOnHand = rand.Next(50000, 100000001);

            newBank.AlarmScore = AlarmScore;
            newBank.VaultScore = AlarmScore;
            newBank.SecurityGuardScore = SecurityGuardScore;
            newBank.CashOnHand = CashOnHand;

            bankScores.Add("AlarmScore", AlarmScore);
            bankScores.Add("VaultScore", VaultScore);
            bankScores.Add("SecurityGuardScore", SecurityGuardScore);
            // bankScores.Add("CashOnHand", CashOnHand);
            //this sets the ordered scores to a variable to be called a few lines down
            var orderedScores = bankScores.OrderBy(score => score.Value);

            var mostSecure = orderedScores.Last();
            var leastSecure = orderedScores.First();

            Console.WriteLine($"Most Secure: {mostSecure.Key}, {mostSecure.Value}");
            Console.WriteLine($"Least Secure: {leastSecure.Key}, {leastSecure.Value}");
            var Crew = new List<IRobber>();
            while (true)
            {
                foreach (var member in rolodex)
                    if (!Crew.Contains(member))
                    {
                        Console.WriteLine($"{rolodex.IndexOf(member)} {member.ToString()}");
                    }
                Console.WriteLine("Please choose a member by entering their index on the list.");
                var chosenMember = Console.ReadLine();
                try
                {
                    int chosenMemberNumber = int.Parse(chosenMember);
                }
                catch
                {
                    Console.WriteLine($"No Bueno, that's not a number.");
                }
                if (chosenMember == "")
                {
                    break;
                }
                var rolodexIndex = int.Parse(chosenMember);
                var rolodexMember = rolodex.ElementAt(rolodexIndex);
                {
                    if (rolodexMember.PercentageCut > TotalPayPercent)
                    {
                        Console.WriteLine("This person is too expensive");
                    }
                    else
                    {
                        TotalPayPercent -= rolodexMember.PercentageCut;
                        Crew.Add(rolodexMember);
                        Console.WriteLine($"Remaining Cut: {TotalPayPercent}");
                    }
                }

            }
            Console.WriteLine("ASSEMBLED CREW");
            Console.WriteLine("===========================");
            foreach (var person in Crew)
            {
                Console.WriteLine($"{Crew.IndexOf(person)} {person.ToString()}");
            }

            foreach (var crewMember in Crew)
            {
                crewMember.PerformSkill(newBank);
            }
            if (newBank.IsSecure == true)
            {
                Console.WriteLine("The heist was a bust! Get out of there!");
            }
            else
            {
                Console.WriteLine("Great Job, I'll pull the van around, throw the money in and let's boogie.");
                double totalMemberEarnings = 0;
                foreach (var member in Crew)
                {
                    var yourTake = (member.PercentageCut / 100) * newBank.CashOnHand;
                    totalMemberEarnings += yourTake;
                    Console.WriteLine($"{member.Name}: your cut is {yourTake.ToString("C")}");
                }
                Console.Write($"The MasterMind earned {(newBank.CashOnHand - totalMemberEarnings).ToString("C")}");
            }

        }
    }
}