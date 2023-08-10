namespace FileStuff;

public static class FileStuff
{


   public static void ReadFiles(string filePath, List<string> teamList)
   {
      using StreamReader reader = new(filePath);
      while (!reader.EndOfStream)
      {
         var line = reader.ReadLine();
         teamList.Add(line);
      }

   }
}