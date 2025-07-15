namespace Assignment_2._3._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //. Write a console application to create a text file and save your basic details like name, age, address ( use dummy data).
            //Read the details from same file and print on console.
            Console.Write("Enter your Name:");
            string name = Console.ReadLine();
            Console.Write("Enter your Age:");
            string age = Console.ReadLine();
            Console.Write("Enter your Address:");
            string address = Console.ReadLine();
            Console.Write("Enter your Phone Number:");
            string phoneNumber = Console.ReadLine();

            try
            {
                string docPath = @"C:\Users\markg\source\repos\Assignment 2.3.1";
                string filePath = Path.Combine(docPath, "TestFile.txt");
                Directory.CreateDirectory(docPath);
                using (StreamWriter sw = new StreamWriter(filePath))
                {
                    sw.WriteLine("Name: " + name);
                    sw.WriteLine("Age: " + age);
                    sw.WriteLine("Address: " + address);
                    sw.WriteLine("Number: " + phoneNumber);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("The file could not be written");
                Console.WriteLine("Error: " + e.Message);
            }

            try
            {
                
                string docPath = @"C:\Users\markg\source\repos\Assignment 2.3.1";
                string filePath = Path.Combine(docPath, "TestFile.txt");

                
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
