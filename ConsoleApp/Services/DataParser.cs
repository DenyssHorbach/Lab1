using ConsoleApp.Domain;

namespace ConsoleApp.Services
{
    public class DataParser
    {
        public Student[] ParseStudents(string[] lines)
        {
            int count = 0;
            for (int i = 0; i < lines.Length; i++)
                if (lines[i].StartsWith("Student ")) count++;

            Student[] students = new Student[count];
            int idx = 0;

            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i].StartsWith("Student "))
                {
                    string fname = GetValue(lines[i + 2]);
                    string lname = GetValue(lines[i + 3]);
                    double height = double.Parse(GetValue(lines[i + 4]));
                    double weight = double.Parse(GetValue(lines[i + 5]));
                    string stId = GetValue(lines[i + 6]);
                    string pass = GetValue(lines[i + 7]);

                    students[idx++] = new Student(fname, lname, height, weight, stId, pass);
                }
            }
            return students;
        }

        private string GetValue(string line)
        {
            int start = line.IndexOf(':', line.IndexOf('"') + 1) + 1;
            int firstQuote = line.IndexOf('"', start) + 1;
            int lastQuote = line.LastIndexOf('"');
            return line.Substring(firstQuote, lastQuote - firstQuote);
        }
    }
}