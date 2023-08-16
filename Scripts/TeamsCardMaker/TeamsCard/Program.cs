using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection.Metadata;
using System.Text.Encodings.Web;

namespace TeamsCard;

class TeamsCardHtml
{
   static void Main(string[] args)
   {
      var teamData = ReadFiles(args[0]);






      string html = @$"
      <div class=""card"">

            <div class=""cardHeaderContainer"">
               <div class=""cardHeaderImg"">
                  <img src = ""./Images/sponserPlaceHolder.png"" alt=""Team1"">

               </div>

               <div class=""cardHeaderTitle"">
                  <h2>{teamData[0]}</h2>
               </div>

               <div class=""cardContentBlurb"">
                  <p>{teamData[1]}</p>
               </div>

            </div>


            <div class=""cardContent"" style=""display: none;"">
               <div class=""cardContentContainer"">

                  <div class=""cardContentColours"">
                     <table class=""smallFirstData"">
                        <thead>
                           <tr>
                              <th>Team Colours</th>
                           </tr>
                        </thead>
                        <tbody>
                           <tr>
                              <td>Jersey</td>
                              <td>{teamData[2]}</td>
                           </tr>
                           <tr>
                              <td>Shorts</td>
                              <td>{teamData[3]}</td>
                           </tr>
                           <tr>
                              <td>Socks</td>
                              <td>{teamData[4]}</td>
                           </tr>
                           <tr>
                              <td>Alternate</td>
                              <td>{teamData[5]}</td>
                           </tr>
                        </tbody>
                     </table>
                  </div>

                  <div class=""cardContentTeamMembers"">
                     <table>
                        <thead>
                           <tr>
                              <th>Team</th>
                           </tr>
                        </thead>
                        <tbody>
                           {makeTable(teamData.GetRange(6, 24))}

                        </tbody>

                     </table>
                  </div>

                  <div class=""cardContentTeamManagement"">
                     <table class=""smallFirstData infoTable"">
                        <thead>
                           <tr>
                              <th>Team Management</th>
                           </tr>
                        </thead>
                        <tbody>
                           {makeTable(teamData.GetRange(30, 2))}
                           <tr>
                              <td>Accomidation</td>
                              <td>Adress</td>
                              <td>Place Name</td>
                           </tr>
                        </tbody>
                     </table>
                  </div>

                  <div class=""cardContentSponsors"">
                     <div class=""sponsortitle"">Sponsors</div>
                     <div class=""sponsorsLogos"">
                        <img src = ""./Images/sponserPlaceHolder.png"" alt=""sponsorPlaceHolder"">
                        <img src = ""./Images/sponserPlaceHolder.png"" alt=""sponsorPlaceHolder"">
                        <img src = ""./Images/sponserPlaceHolder.png"" alt=""sponsorPlaceHolder"">
                        <img src = ""./Images/sponserPlaceHolder.png"" alt=""sponsorPlaceHolder"">
                        <img src = ""./Images/sponserPlaceHolder.png"" alt=""sponsorPlaceHolder"">
                     </div>
                  </div>

               </div>
            </div>
            <div class=""downArrow"" onclick=""openCard(this)"">
               <span class=""astIcon iconArrow"">
                  <svg class=""astArrowSvg"" xmlns=""http://www.w3.org/2000/svg"" xmlns:xlink=""http://www.w3.org/1999/xlink""
                     version=""1.1"" x=""0px"" y=""0px"" width=""26px"" height=""16.043px"" viewBox=""57 35.171 26 16.043""
                     enable-background=""new 57 35.171 26 16.043"" xml:space=""preserve"">
                     <path d=""M57.5,38.193l12.5,12.5l12.5-12.5l-2.5-2.5l-10,10l-10-10L57.5,38.193z""></path>
                  </svg>
               </span>
            </div>
         </div>
   
   
   
   ";

      using StreamWriter writer = new("./output.html");
      writer.WriteLine(html);


   }





   public static List<string> ReadFiles(string filePath)
   {
      var output = new List<string>();
      using StreamReader reader = new(filePath);

      var line = reader.ReadLine();
      output.Add(line);

      Console.WriteLine(line);
      return output[0].Split(',').ToList();
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





