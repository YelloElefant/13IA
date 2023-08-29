
namespace DataEntry;


class DataEntry
{
   static void Main(string[] args)
   {
      string filePath = args[0];
      string[] lines = ReadFiles.ReadCSV(filePath);
      List<Team> teams = new List<Team>();
      List<List<string>> game = new List<List<string>>();
      //team1, score1,bp, win points, team2, score2, bp, win points

      for (int i = 0; i < lines.Length; i++)
      {
         var splitLine = lines[i].Split(',');

         game.Add(new List<string>());
         //team1
         game[i].Add(splitLine[1]);
         game[i].Add(splitLine[2]);
         game[i].Add(splitLine[6]);
         game[i].Add(splitLine[7]);

         //team2
         game[i].Add(splitLine[8]);
         game[i].Add(splitLine[9]);
         game[i].Add(splitLine[13]);
         game[i].Add(splitLine[14]);

         int[] wdl1 = new int[3];
         int[] wdl2 = new int[3];

         if (int.Parse(splitLine[2]) > int.Parse(splitLine[9]))
         {
            wdl1[0] = 1;
            wdl2[2] = 1;
         }
         else if (int.Parse(splitLine[2]) < int.Parse(splitLine[9]))
         {
            wdl1[2] = 1;
            wdl2[0] = 1;
         }
         else
         {
            wdl1[1] = 1;
            wdl2[1] = 1;
         }




         teams.Add(new Team(splitLine[1], splitLine[2], splitLine[6], splitLine[7], wdl1, splitLine[9]));



         teams.Add(new Team(splitLine[8], splitLine[9], splitLine[13], splitLine[14], wdl2, splitLine[2]));



      }

      //reading old points

      string oldPointsPath = args[1];
      var oldStuffLines = ReadFiles.ReadHTML(oldPointsPath);

      for (int i = 0; i < oldStuffLines.Count; i++)
      {
         for (int j = 0; j < teams.Count; j++)
         {
            if (teams[j].Name.Trim().ToLower() == oldStuffLines[i][0].Trim().ToLower())
            {
               teams[j].OldPF = int.Parse(oldStuffLines[i][4]);
               teams[j].OldPA = int.Parse(oldStuffLines[i][5]);
               teams[j].OldBonusPoints = int.Parse(oldStuffLines[i][6]);
               teams[j].OldPoints = int.Parse(oldStuffLines[i][7]);
               teams[j].oldWDL = new int[3];
               teams[j].oldWDL[0] = int.Parse(oldStuffLines[i][1]);
               teams[j].oldWDL[1] = int.Parse(oldStuffLines[i][2]);
               teams[j].oldWDL[2] = int.Parse(oldStuffLines[i][3]);

            }
         }
      }



      //calculating new points

      for (int i = 0; i < teams.Count; i++)
      {
         teams[i].Points = teams[i].OldPoints + teams[i].Points;
         teams[i].PF = teams[i].OldPF + teams[i].PF;
         teams[i].PA = teams[i].OldPA + teams[i].PA;
         teams[i].BonusPoints = teams[i].OldBonusPoints + teams[i].BonusPoints;
         for (int j = 0; j < 3; j++) { teams[i].WDL[j] += teams[i].oldWDL[j]; }
      }

      //making html file
      using StreamWriter file = new("./output.html");
      foreach (var team in teams)
      {
         file.WriteLine(@"<tr class=""tablePoints"">");
         file.WriteLine(@"<td>" + team.Name + "</td>");
         foreach (var item in team.WDL)
         {
            file.WriteLine(@"<td>" + item + "</td>");
         }
         file.WriteLine(@"<td>" + team.PF + "</td>");
         file.WriteLine(@"<td>" + team.PA + "</td>");
         file.WriteLine(@"<td>" + team.BonusPoints + "</td>");
         file.WriteLine(@"<td>" + team.Points + "</td>");
         file.WriteLine("</tr>");
      }


      Console.WriteLine(teams);



   }
}