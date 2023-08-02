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
            sw.WriteLine("<tr>");

            sw.WriteLine($"<td> {i + 1} </td>");
            sw.WriteLine("<td> pool </td>");

            sw.WriteLine("<td class=\"teamLeft\">" + teams1[i] + "</td>");
            sw.WriteLine(tableV);
            sw.WriteLine("<td class=\"teamRight\">" + teams2[i] + "</td>");
            sw.WriteLine($"<td> {time} </td>");
            sw.WriteLine("<td> VENUE </td>");
            sw.WriteLine("</tr>");
         }
         sw.WriteLine("</tbody>");
      }

   }



}