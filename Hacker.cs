using System;

namespace heist2
{
    public class Hacker : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.AlarmScore -= SkillLevel;
            Console.WriteLine($"{Name} reduced the Alarm Score by {SkillLevel}.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has taken out the alarms!");
            }
            else
            {
                Console.WriteLine($"{Name} failed to take out the alarms.");
            }
        }
        public override string ToString()
        {
            return $"{Name} is a Hacker and has a skill level of {SkillLevel} and wants {PercentageCut}% cut.";
        }
    }

}