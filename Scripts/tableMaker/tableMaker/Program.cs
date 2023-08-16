using FileStuff;

namespace TableMaker;

public class TableMaker
{
   public static string filePathTeams1;
   public static string filePathTeams2;
   const string tableV = "<td class=\"tableV\">v</td>";

   public static List<string> teams1 = new List<string>();

   public static List<string> teams2 = new List<string>();

   static void Main(string[] args)
   {
      filePathTeams1 = args[0];
      filePathTeams2 = args[1];
      string time = args[2];

      FileStuff.FileStuff.ReadFiles(filePathTeams1, teams1);
      FileStuff.FileStuff.ReadFiles(filePathTeams2, teams2);

      using (StreamWriter sw = new StreamWriter(@"./output.txt"))
      {
         sw.WriteLine("<tbody>");
         for (int i = 0; i < teams1.Count; i++)
         {
            sw.WriteLine("<tr class=\"tablePoints\">");

            sw.WriteLine($"<td> {teams1[i]} </td>");

            for (int l = 0; l < 13; l++) { sw.WriteLine("<td>0</td>"); }

            sw.WriteLine("</tr>");
         }
         sw.WriteLine("</tbody>");
      }

   }



}