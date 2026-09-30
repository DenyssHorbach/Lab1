namespace FileStorage.Lib
{
    public interface IFileStreamHandler
    {
        void WriteText(string filePath, string text, bool append);
        string[] ReadLines(string filePath);
    }
}