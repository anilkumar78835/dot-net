using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opps
{
    public class Lab1 
    {
        public int id;
        public String name;
        public float salary;
        public void insert(int i, String  n, float s)
        {
            id = i;
            name = n;
            salary = s;

        }
        public void display()
        {
            Console.WriteLine(id + " " + name + " " + salary);
        }
    }
    class TestEmployee 
    {
        public static void Main (String[] args)
        {
            Lab1 e1 = new Lab1();
            Lab1 e2 = new Lab1();
            e1.insert(101, "sonia", 20000);
            e2.insert(102, "janu", 30000);
            e1.display();
            e2.display();
            Console.ReadKey();
        }
    }
}

        