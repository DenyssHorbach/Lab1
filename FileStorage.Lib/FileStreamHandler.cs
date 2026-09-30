using System.IO;

namespace FileStorage.Lib
{
    public class FileStreamHandler : IFileStreamHandler
    {
        public void WriteText(string filePath, string text, bool append)
        {
            FileMode mode = append ? FileMode.Append : FileMode.Create;
            using var fs = new FileStream(filePath, mode, FileAccess.Write);
            using var writer = new StreamWriter(fs);
            writer.Write(text);
        }

        public string[] ReadLines(string filePath)
        {
            if (!File.Exists(filePath)) return new string[0];

            int linesCount = 0;
            using (var readerForCount = new StreamReader(filePath))
            {
                while (readerForCount.ReadLine() != null) linesCount++;
            }

            string[] result = new string[linesCount];
            using (var reader = new StreamReader(filePath))
            {
                for (int i = 0; i < linesCount; i++)
                {
                    result[i] = reader.ReadLine();
                }
            }
            return result;
        }
    }
}