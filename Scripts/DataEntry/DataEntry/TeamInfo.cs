//class with team name, new score, old score

namespace DataEntry
{
   class Team
   {
      public string Name { get; set; }
      public int PF { get; set; }
      public int BonusPoints { get; set; }
      public int WinPoints { get; set; }
      public int PA { get; set; }
      public int[] WDL { get; set; }


      public int Points { get; set; }
      public int OldPoints { get; set; }
      public int OldBonusPoints { get; set; }
      public int OldPF { get; set; }
      public int OldPA { get; set; }
      public int[] oldWDL = new int[3] { 0, 0, 0 };
      public Team(string teamName, string Score, string bonusPoints, string winPoints, int[] wdl, string pa)
      {
         Name = teamName;
         PF = int.Parse(Score);
         WinPoints = int.Parse(winPoints);
         BonusPoints = int.Parse(bonusPoints);
         WDL = wdl;
         PA = int.Parse(pa);
         Points = WinPoints + BonusPoints;
      }


   }
}