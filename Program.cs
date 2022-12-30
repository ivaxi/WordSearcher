
using ConsoleApp1.Functions;


Console.WriteLine("Processing...");

var fileName = args.Length > 0 ? args[0] : "Content/text.txt";

var exeption = FilesFunctions.CheckFileConditions(fileName);

if (exeption != null) throw exeption;

var fileContent = FilesFunctions.ReadFileContent(fileName);

var words = StringFunctions.GetWords(fileContent);

var wordLibrary = StringFunctions.CountWords(words);


foreach (var (key, value) in wordLibrary)
{
    Console.WriteLine($"{key} - {value}");
}

