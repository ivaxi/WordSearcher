namespace ConsoleApp1.Functions;

public static class FilesFunctions
{

    public static Exception CheckFileConditions(string fileName)
    {
        
        Exception exception = null;
        
        exception = CheckForFileName(fileName);
        if (exception != null) return exception;
        exception = CheckForFileExistence(fileName);
        return exception;

    }

    public static Exception? CheckForFileName(string fileName)
    {
        return string.IsNullOrEmpty(fileName) ? new ArgumentNullException("fileName", "File name is empty!") : null;
    }
    public static Exception? CheckForFileExistence(string fileName)
    {
        return !File.Exists(fileName) ? new FileNotFoundException($@"File not exists! {fileName}") : null;
    }

    public static string ReadFileContent(string filePath)
    {
        return File.ReadAllText(filePath);
    }

}