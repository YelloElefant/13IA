using System;
using System.Collections.Generic;
using System.IO;



namespace TeamsCard;

class TeamsCardHtml
{
   static void Main(string[] args)
   {

   }





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
