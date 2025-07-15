namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Write a console application to create a text file and save your basic details like name, age, address ( use dummy data).
            //Read the details from same file and print on console.
            
            string name = "";
            string age = "";
            string address = "";
            string phoneNumber = "";

            try
            {
                string filePath = "C:\\Users\\markg\\source\\repos\\Assignment 2.3.1\\TestFile.txt";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    string line;
                    // Read and display lines from the file until the end of the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Console.WriteLine("Name: " + line);
                        name = line;
                        line = sr.ReadLine();
                        age = line;
                        line = sr.ReadLine();
                        address = line;
                        line = sr.ReadLine();
                        phoneNumber = line;

                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be read");
                Console.WriteLine("Error: " + e.Message);
            }
            
            Console.WriteLine($"name: {name} ");
            Console.WriteLine($"age: {age} ");
            Console.WriteLine($"address: {address} ");
            Console.WriteLine($"phoneNumber: {phoneNumber} ");

        }
    }
}
