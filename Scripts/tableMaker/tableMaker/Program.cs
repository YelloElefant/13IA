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

      using (StreamWriter sw = new StreamWriter(@"./output.html"))
      {
         sw.WriteLine("<tbody>");
         for (int i = 0; i < teams1.Count; i++)
         {
            sw.WriteLine("<tr>");


            sw.WriteLine($"<td> {time} </td>");
            sw.WriteLine("<td class=\"teamLeft\">" + teams1[i] + "</td>");
            sw.WriteLine("<td>POINTS</td>");
            sw.WriteLine(tableV);
            sw.WriteLine("<td>POINTS</td>");
            sw.WriteLine("<td class=\"teamRight\">" + teams2[i] + "</td>");
            sw.WriteLine("</tr>");
         }
         sw.WriteLine("</tbody>");
      }

   }



   public static string makeTable(List<string> inputs)
   {
      var output = @$"";



      for (var i = 0; i < inputs.Count; i++)
      {
         inputs[i] = "<td>" + inputs[i] + "</td>";
      }

      var count = inputs.Count;
      for (var i = 0; i < count / 3; i++)
      {
         output += "<tr>";
         output += inputs[0];
         output += inputs[1];
         output += inputs[2];

         inputs.RemoveRange(0, 3);
         output += "</tr>";

      }

      return output;


   }


}