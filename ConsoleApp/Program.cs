using FileStorage.Lib;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Створюємо екземпляр файлового обробника та передаємо його у меню (IoC)
            IFileStreamHandler fileHandler = new FileStreamHandler();
            ConsoleMenu menu = new ConsoleMenu(fileHandler);

            menu.Run();
        }
    }
}