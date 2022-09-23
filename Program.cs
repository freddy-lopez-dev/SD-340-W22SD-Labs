using System.IO;
using System.Text;

string directory = @"C:\Users\Slickrick\Documents";

StringBuilder sb = new StringBuilder();

try
{
    //Set the current directory.
    Directory.SetCurrentDirectory(directory);
    string[] files = Directory.GetFiles(directory,"theMachineStops.txt");
    using (StreamReader sr = File.OpenText(files[0]))
    {
        sb.Append(sr.ReadToEnd());
    }

    sb.Replace(".", "STOP");

    string fileName = "TelegramCopy.txt";

    using (StreamWriter sw = File.CreateText(System.IO.Path.Combine(directory, fileName)))
    {
        sw.Write(sb.ToString());
    }


}
catch (DirectoryNotFoundException e)
{
    Console.WriteLine("The specified directory does not exist. {0}", e);
}

Console.WriteLine(Directory.GetCurrentDirectory());

