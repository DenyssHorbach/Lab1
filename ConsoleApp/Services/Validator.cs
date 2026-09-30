using System.Text.RegularExpressions;

namespace ConsoleApp.Services
{
    public static class Validator
    {
        public static bool ValidateName(string name) => Regex.IsMatch(name, @"^[A-Za-zА-Яа-яІіЇїЄєҐґ']+$");
        public static bool ValidateStudentId(string id) => Regex.IsMatch(id, @"^[A-Z]{2}\d{8}$");
        public static bool ValidatePassport(string pass) => Regex.IsMatch(pass, @"^(?:[A-Z]{2}\d{6}|\d{9})$");
    }
}