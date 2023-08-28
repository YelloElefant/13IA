//class with team name, new score, old score

namespace DataEntry
{
   class Team
   {
      public string TeamName { get; set; }
      public int NewScore { get; set; }

      public int WinPoints { get; set; }
      public int BonusPoints { get; set; }

      public int OldScore { get; set; }

      public int[] WDL { get; set; }

      public Team(string teamName, string newScore, string bonusPoints, string winPoints, int[] wdl)
      {
         TeamName = teamName;
         NewScore = int.Parse(newScore);
         WinPoints = int.Parse(winPoints);
         BonusPoints = int.Parse(bonusPoints);
         WDL = wdl;
      }


   }
}