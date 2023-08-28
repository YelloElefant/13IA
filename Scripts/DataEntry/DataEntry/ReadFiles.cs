using System.IO;


//read csv file method and return a string array

namespace DataEntry
{
   class ReadFiles
   {
      public static string[] ReadCSV(string path)
      {
         string[] lines = File.ReadAllLines(path);
         return lines;
      }
   }
}