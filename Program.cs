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
            string path =File.ReadAllText("thisStory.txt");



            //Writing to the file
            using (StreamWriter sw = new StreamWriter (path, true))
            {
                Console.WriteLine(path.Replace("and", "And"));
                //sw.WriteLine("DEF");
                sw.Close();
            }

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
            }
            else
            {
                Console.WriteLine("nope! try again...");
            }
            Console.Read();
        }
    }
}
