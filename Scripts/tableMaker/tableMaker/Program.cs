using System;
using System.IO;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TableMaker;

public class TableMaker
{
   public static string filePathTeams1;
   public static string filePathTeams2;
   const string tableV = "<td class=\"tableV\">v</td>";

   public static List<string> teams1 = new List<string>();

   public static List<string> teams2 = new List<string>();

   static void Main(string[] args)
   {
      filePathTeams1 = args[0];
      filePathTeams2 = args[1];
      string time = args[2];

      ReadFiles(filePathTeams1, teams1);
      ReadFiles(filePathTeams2, teams2);

      using(StreamWriter sw = new StreamWriter(@"./output.txt")) 
      {
         sw.WriteLine("<tbody>");
         for (int i = 0; i < teams1.Count; i++)
         {
            sw.WriteLine("<tr>");

            sw.WriteLine($"<td> {time} </td>");

            sw.WriteLine("<td class=\"teamLeft\">" + teams1[i] + "</td>");
            sw.WriteLine("<td> points </td>");
            sw.WriteLine(tableV);
            sw.WriteLine("<td> points </td>");
            sw.WriteLine("<td class=\"teamRight\">" + teams2[i] + "</td>");
            sw.WriteLine("</tr>");
         }
         sw.WriteLine("</tbody>");
      }

   }

   public static void ReadFiles(string filePath, List<string> teamList) 
   { 
      using(StreamReader reader = new StreamReader(filePath)) 
      {
         while (!reader.EndOfStream)
         {
            var line = reader.ReadLine();
            teamList.Add(line);
         }
      }
   
   }

}