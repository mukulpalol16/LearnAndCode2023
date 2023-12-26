namespace RectangleAreaApplication
{
    public class FileWriter
    {
        public static void WriteToFile(string fileName, string content)
        {
            try
            {
                File.WriteAllText(fileName, content);
            }
            catch (IOException exception)
            {
                Console.WriteLine("Error writing to file: " + exception.Message);
            }
        }
    }
}
