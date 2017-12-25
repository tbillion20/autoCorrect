using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace autoCorrect
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaring the path to the file
            string path = "thisStory.txt";

            //reading from the file
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
                Console.WriteLine("its open!");
                Console.Read();
            }
            else
            {
                Console.WriteLine("nope! try again...");
            }
        }
    }
}
