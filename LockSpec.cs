using System;

namespace heist2
{
    public class LockSpec : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} reduced the Vault Score by {SkillLevel}.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has cracked the Vault!");
            }
            else
            {
                Console.WriteLine($"{Name} failed to pick the lock on the Vault.");
            }
        }
        public override string ToString()
        {
            return $"{Name} is a Lock Specialist and has a skill level of {SkillLevel} and wants {PercentageCut}% cut.";
        }
    }

}