namespace FileStuff;

public static class FileStuff
{


   public static List<List<string>> ReadFiles(string filePath, List<string> coaches, List<string> managers, List<string> acommidation)

   {
      using StreamReader reader = new(filePath);
      while (!reader.EndOfStream)
      {
         var line = reader.ReadLine();
         var values = line.Split('"');
         coaches.Add(values[0]);
         managers.Add(values[1]);
         acommidation.Add(values[2]);
      }

      return new List<List<string>> { coaches, managers, acommidation };

   }
}