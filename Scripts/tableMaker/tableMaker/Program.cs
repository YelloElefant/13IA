using FileStuff;

namespace TableMaker;

public class TableMaker
{
   public static string filePathTeams1;
   public static string filePathTeams2;
   const string tableV = "<td class=\"tableV\">v</td>";

   public static List<string> coaches = new List<string>();

   public static List<string> managers = new List<string>();
   public static List<string> acommidation = new List<string>();

   static void Main(string[] args)
   {
      filePathTeams1 = args[0];
      //filePathTeams2 = args[1];
      //string time = args[2];
      var file = new StreamReader(filePathTeams1).ReadToEnd(); // big string
      var lines = file.Split(new char[] { '\n' });           // big array
      var count = lines.Count();                               // big number
      var l = 1;


      using (StreamWriter sw = new StreamWriter(@"./output.html"))
      {
         var returned = FileStuff.FileStuff.ReadFiles(filePathTeams1, coaches, managers, acommidation);
         for (int i = 0; i < count; i++)
         {
            sw.WriteLine("<tr class=\"tablePoints\">");

            sw.WriteLine($"<td> {teams1[i]} </td>");

            for (int l = 0; l < 13; l++) { sw.WriteLine("<td>0</td>"); }

            sw.WriteLine("</tr>");
         }
      }

   }



}