using System.IO;
 using System;

namespace ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
    //    {
        // using(var fs = new FileStream("Values.txt", FileMode.Open, FileAccess.Read))
        // using (var sr = new System.IO.StreamReader(fs)){
        // //Read file via sr.Read(), sr.ReadLine, ...
    // }
            StreamReader Results = new StreamReader("Values.txt");
            string line = "";

            while (line != null)
            {
                line = Results.ReadLine;
                if (line != null)
                
                    Console.WriteLine(line);
                
            }
            Results.Close();
            Console.ReadLine;
        }
    }
}
