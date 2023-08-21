namespace FileStuff;

public static class FileStuff
{


   public static List<List<string>> ReadFiles(string filePath, List<string> coaches, List<string> managers, List<string> acommidation)

   {
      using StreamReader reader = new(filePath);
      while (!reader.EndOfStream)
      {
         var line = reader.ReadLine();
         var values = line.Split(';');
         coaches = values[0].Split(',').ToList();
         managers = values[1].Split(',').ToList();
         acommidation = values[2].Split(',').ToList();
      }

      return new List<List<string>> { coaches, managers, acommidation };

   }
}