using FileStorage.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IFileStreamHandler fileHandler = new FileStreamHandler();
            ConsoleMenu menu = new ConsoleMenu(fileHandler);

            menu.Run();
        }
    }
}