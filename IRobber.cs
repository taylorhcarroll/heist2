namespace heist2
{
    interface IRobber
    {
        string Name { get; set; }
        int SkillLevel { get; set; }
        double PercentageCut { get; set; }
        void PerformSkill(Bank bank);
    }
}