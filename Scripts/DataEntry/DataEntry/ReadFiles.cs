using System.IO;
using System.Collections.Generic;
using System;

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

      //read html method that reads each table row and returns a string array of the lines 
      public static List<List<string>> ReadHTML(string path)
      {
         string[] lines = File.ReadAllLines(path);
         List<List<string>> outputList = new List<List<string>>();


         for (int i = 0; i < lines.Length; i += 10)
         {

            List<string> output = new()
            {
                lines[i + 1].Trim().Substring(4, lines[i + 1].Length - 12),
                lines[i + 2].Trim().Substring(4, lines[i + 2].Length - 12),
                lines[i + 3].Trim().Substring(4, lines[i + 3].Length - 12),
                lines[i + 4].Trim().Substring(4, lines[i + 4].Length - 12),
                lines[i + 5].Trim().Substring(4, lines[i + 5].Length - 12),
                lines[i + 6].Trim().Substring(4, lines[i + 6].Length - 12),
                lines[i + 7].Trim().Substring(4, lines[i + 7].Length - 12),
                lines[i + 8].Trim().Substring(4, lines[i + 8].Length - 12)
            };


            outputList.Add(output);

         }



         return outputList;
      }


   }
}