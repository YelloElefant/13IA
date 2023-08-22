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


      using (StreamWriter sw = new StreamWriter(@"./output.html"))
      {
         var returned = FileStuff.FileStuff.ReadFiles(filePathTeams1);

         sw.WriteLine(makeTable(returned));

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