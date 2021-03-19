using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace lab6b
{
    class streamreader_program
    {
        static void Main(string[] args)
        {

            FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);

            Console.WriteLine("File opened");

            
            StreamReader sr = new StreamReader(f);
            Console.WriteLine("Reading data from the file");

            string line = sr.ReadLine();

            Console.WriteLine("The data from the file is : " + line);

           
            sr.Close();
            f.Close();

            Console.WriteLine("File Stream closed");

            Console.ReadLine();
        }
    }
}