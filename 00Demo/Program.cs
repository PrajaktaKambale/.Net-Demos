using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _00Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Add();

            Console.WriteLine(result);
            Console.ReadLine();
        }
            //First Program
            static int Add() {
                Console.WriteLine("Please enter first value");
                string s1 = Console.ReadLine();
                Console.WriteLine("Please enter second value");
                string s2 = Console.ReadLine();
                // int x = 100;
                //int y = 200;
                int x = Convert.ToInt32(s1);
                int y = Convert.ToInt32(s2);
                int result = x + y;
            return result;
            }
            
        }
    }

