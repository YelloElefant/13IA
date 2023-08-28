
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

         teams.Add(new Team(splitLine[1], splitLine[2], splitLine[6], splitLine[7], wdl1));



         teams.Add(new Team(splitLine[8], splitLine[9], splitLine[13], splitLine[14], wdl2));



      }



      Console.WriteLine(teams);



   }
}