using System;
namespace heist2
{
    public class Muscle : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.SecurityGuardScore -= SkillLevel;
            Console.WriteLine($"{Name} reduced the Bank Security Guard Score by {SkillLevel}.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has taken out the guards!");
            }
        }
    }

}