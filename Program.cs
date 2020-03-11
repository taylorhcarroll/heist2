using System;
using System.Collections.Generic;

namespace heist2
{
    class Program
    {
        static void Main(string[] args)
        {
            var rolodex = new List<IRobber>();
            var robber1 = new Muscle()
            {
                Name = "Subway",
                SkillLevel = 50,
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
                SkillLevel = 35,
                PercentageCut = 20,
            };
            var robber4 = new Hacker()
            {
                Name = "Namita",
                SkillLevel = 62,
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
            while (true)
            {
                Console.WriteLine("Please enter a new member name");
                var newMemberName = Console.ReadLine();
                if (newMemberName == "")
                {
                    break;
                }
                // while (true)
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
                        newMuscle.SkillLevel = int.Parse(newMemberSkillLevel);
                        Console.WriteLine("What is this member's percentage pay cut? (1-100)");
                        var newMemberPayPercentage = Console.ReadLine();
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
                        newHacker.SkillLevel = int.Parse(newMemberSkillLevel);
                        Console.WriteLine("What is this member's percentage pay cut? (1-100)");
                        var newMemberPayPercentage = Console.ReadLine();
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
                        newLockSpec.SkillLevel = int.Parse(newMemberSkillLevel);
                        Console.WriteLine("What is this member's percentage pay cut? (1-100)");
                        var newMemberPayPercentage = Console.ReadLine();
                        rolodex.Add(newLockSpec);
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That is a not a Valid speciality. Please try again.");
                    }
                }
            }
        }
    }
}