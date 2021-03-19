
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
 
namespace lab6
{
    class streamwrite_program
    {
        static void Main(string[] args)
        {

            FileStream f = new FileStream("d:\\b.txt", FileMode.OpenOrCreate);

            Console.WriteLine("File opened");

            
            StreamWriter s = new StreamWriter(f);

            Console.WriteLine("Writing data to file");

            s.WriteLine("Writing data into file using stream writer");

            
            s.Close();
            f.Close();

            Console.WriteLine("File Stream closed");

            Console.ReadLine();
        }
    }
}
