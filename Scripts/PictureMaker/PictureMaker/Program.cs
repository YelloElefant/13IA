using System.Security;

namespace PictureMaker;
class Program
{

   static void Main(string[] args)
   {
      var inputPath = args[0];
      //var outputPath = args[1];

      var files = GetFiles(inputPath);
      Console.WriteLine($"Found {files.Count} files");

      //console write all files
      for (int i = 0; i < files.Count; i++)
      {

         files[i] = files[i].Split('\\').Last();
         files[i] = "./Images/PicturesPage/" + files[i];
         Console.WriteLine(files[i]);
      }

      for (int i = 0; i < files.Count; i++)
      {
         files[i] = @$"
         <div id=""picturesContainer"">
            <div class=""picture"">
                <img src = ""{files[i]}"" alt=""picture"">
                <div class=""caption"">
                    <p></p>
                </div>
            </div>
        </div>
         
         ";
      }

      //write to file
      using (StreamWriter outputFile = new StreamWriter("./output.html"))
      {
         foreach (string line in files)
            outputFile.WriteLine(line);
      }



   }

   private static List<string> GetFiles(string inputPath)
   {
      var files = Directory.GetFiles(inputPath, "*.JPG");
      return files.ToList();
   }


}
