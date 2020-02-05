using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter tjc = null; ;
            Console.WriteLine("Hello World!");
            try
            {
                tjc = new StreamWriter("C:/users/tjc/hello.txt");
                tjc.WriteLine("sdfghjkl;");
                tjc.WriteLine("rty");
                tjc.Close();

            }
            catch
            {
                Console.WriteLine("error");

            }

            StreamReader tj = null; 

            try
            {
                tj = new StreamReader("C:/users/tjc/hello.txt");
                Console.WriteLine(tj.ReadToEnd());
                tj.Close();

            }
            catch
            {

            }





        }
    }
}