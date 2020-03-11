using System;

namespace heist2
{
    public class LockSpec : IRobber
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill(Bank bank)
        {
            bank.VaultScore -= SkillLevel;
            Console.WriteLine($"{Name} reduced the Vault Score by {SkillLevel}.");
            if (bank.SecurityGuardScore <= 0)
            {
                Console.WriteLine($"{Name} has cracked the Vault!");
            }
        }
    }

}