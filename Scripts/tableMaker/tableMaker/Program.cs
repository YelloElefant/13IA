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



      using (StreamWriter sw = new StreamWriter(@"./output.txt"))
      {
         for (int i = 0; i < count; i++)
         {
            var returned = FileStuff.FileStuff.ReadFiles(filePathTeams1, coaches, managers, acommidation);
            coaches = returned[0];
            managers = returned[1];
            acommidation = returned[2];
            foreach (var coach in coaches)
            {
               sw.WriteLine("<tr>");
               sw.WriteLine($"<td>Coach</td>");
               sw.WriteLine($"<td>{coach}</td>");
               sw.WriteLine("</tr>");
            }
            foreach (var manager in managers)
            {
               sw.WriteLine("<tr>");
               sw.WriteLine($"<td>Manager</td>");
               sw.WriteLine($"<td>{manager}</td>");
               sw.WriteLine("</tr>");
            }
            foreach (var acommidation in acommidation)
            {
               sw.WriteLine("<tr>");
               sw.WriteLine($"<td>Acommidation</td>");
               sw.WriteLine($"<td>{acommidation}</td>");
               sw.WriteLine("</tr>");
            }

         }
      }

   }



}