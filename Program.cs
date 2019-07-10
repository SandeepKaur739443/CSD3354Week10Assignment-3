using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var tp = new TextProcessing();
        }
    }
}
class TextProcessing
{
    public void Run()
    {
        using (StreamReader file = new StreamReader("U:/Users/739443/babynames/TextFile1.txt"))
        {
            int counter = 0;
            string ln;

            while ((ln = file.ReadLine()) != null)
            {
                Console.WriteLine(ln);
                counter++;
            }
            file.Close();
            Console.WriteLine($"File has {counter} lines.");
        }
    }
}
