using System;
using FileStorage.Lib;
using ConsoleApp.Domain;
using ConsoleApp.Services;

namespace ConsoleApp
{
    public class ConsoleMenu
    {
        private readonly IFileStreamHandler _fileHandler;
        private readonly DataParser _parser = new DataParser();
        private const string FilePath = "database.txt";

        public ConsoleMenu(IFileStreamHandler fileHandler)
        {
            _fileHandler = fileHandler;
        }

        public void Run()
        {
            SeedData();

            Console.WriteLine("Student list with ideal weight");
            string[] lines = _fileHandler.ReadLines(FilePath);
            Student[] students = _parser.ParseStudents(lines);

            int matchCount = 0;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].HasIdealWeight())
                {
                    matchCount++;
                    Console.WriteLine($"[+] {students[i].FirstName} {students[i].LastName} | Ріст: {students[i].Height} см, Вага: {students[i].Weight} кг | Квиток: {students[i].StudentId}");
                }
            }
            Console.WriteLine($"\nFound: {matchCount}");
        }

        private void SeedData()
        {
            Student s1 = new Student("Zenyk", "Kuz'min", 180, 70, "KB12345678", "AA123456");
            Student s2 = new Student("Petro", "Poroshenko", 175, 65, "KB87654321", "BB654321");
            Student s3 = new Student("Pes", "Patron", 190, 95, "KB11223344", "CC112233");

            string data = s1.Serialize() + s2.Serialize() + s3.Serialize();
            _fileHandler.WriteText(FilePath, data, append: false);
        }
    }
}