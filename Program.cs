namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Write a console application to create a text file and save your basic details like name, age, address ( use dummy data).
            //Read the details from same file and print on console.
            Console.WriteLine("Hello, World!");
            try
            {
                string filePath = "TestFile.txt";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    // Read and display lines from the file until the end of the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine("Error: " + e.Message);
            }
            
        }
    }
}
