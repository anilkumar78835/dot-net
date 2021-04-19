using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_delegates
{
        public delegate void EventHandler(string a);

        public class Operation
        {
            public event EventHandler xyz;

            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);
                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }

        class Lab3
    {
            public static void CatchEvent(string s)
            {
                Console.WriteLine("Method Calling");
            }

            static void Main(string[] args)
            {
                Operation o = new Operation();

                o.Action("Event Calling");
                o.xyz += new EventHandler(CatchEvent);

                Console.ReadLine();
            }
        }
    }
