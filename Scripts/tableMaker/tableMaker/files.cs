namespace FileStuff;

public static class FileStuff
{


   public static List<string> ReadFiles(string filePath)
   {

      using StreamReader reader = new(filePath);

      string line = reader.ReadLine();

      var output = line.Split(',').ToList();
      return output;

   }
}