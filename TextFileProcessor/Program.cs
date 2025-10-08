using System;

class Program
{
    static void Main(string[] args)
    {
        var rootPath = @"C:\ROOT";

        //var files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);

        //foreach(var file in files)
        //{
        //  Console.WriteLine(file);
        //  Console.WriteLine(Path.GetFileName(file)); // This doesn't show up the whole file path.

        //---| This gives the size of the file in bytes |----
        /*
          var info = new FileInfo(file);
          Console.WriteLine($"{Path.GetFileName(file)} : {info.Length} bytes");   
        }
        */

        //----| To copy the files in a backup folder |----
        /*
        var sourceFiles = Directory.GetFiles(rootPath);
        var destinationFolder = @"C:\ROOT\BackupFolder\";
        //Directory.CreateDirectory(destinationFolder); this creates the directory if the destination folder isn't created.

        foreach (var file in sourceFiles)
        {
            File.Copy(file, $"{destinationFolder}{Path.GetFileName(file)}", true);
        }
        */

        var root = @"C:\ROOT\ThisIsATextFile.txt";

        //File.WriteAllText(root, "Hi! Welcome to Nepal.");
        //File.AppendAllText(root, "Hi! Welcome to Nepal2.");

        //---|Counts the lines in a file|----

        var lineCount = File.ReadAllLines(root).Length;
        Console.WriteLine($"Total lines in the file is {lineCount}.");


        var textInFile = File.ReadAllText(root);

        //---| This counts the number of character inthe file|---
        /*
        var numberOfCharacter = 0;
        foreach(char c in textInFile)
        {
            numberOfCharacter++;
        }
        Console.WriteLine($"The total characters in the file is {numberOfCharacter}.");
        */

        //---| This counts the number of words in the file |---
        /*
        string[] wordsInFile = textInFile.Split(' ');
        Console.WriteLine($"The total number of words in the file is {wordsInFile.Count()}");
        */

        //---| Searches for specific text in files |---
        /*
        Console.Write("Enter the text you are searching for: ");
        var specificText = Console.ReadLine();
        string[] wordsInFile = textInFile.Split(' ');

        if (wordsInFile.Contains(specificText))
        {
            Console.WriteLine($"The text {specificText} exists in the file.");
            return;
        }
        Console.WriteLine($"The text {specificText} doesn't exist in the file.");
        */

        Console.ReadLine();
    }
}
