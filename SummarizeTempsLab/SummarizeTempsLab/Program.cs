using System;
using System.IO;

namespace SummarizeTempsLab
{
    class Program
    {
        static void Main(string[] args)
        {
            // temperature data is in temps.txt
            //Write out promt to console
            string filename;
            Console.WriteLine("Enter a filename");
            filename = Console.ReadLine();

            if (File.Exists(filename))
            {
                Console.WriteLine("file exists");
                Console.WriteLine("Enter threshold");
                String input;
                int threshold;
                input = Console.ReadLine();
                threshold = int.Parse(input);

                int sumTemps = 0;
                int numAbove = 0;
                int numBelow = 0;
                int tempCount = 0;
                using (StreamReader sr = File.OpenText(filename))
                {
                    String Line = sr.ReadLine();
                    int temp;
                    //While the line is not null
                    while (Line != null)
                    {
                        temp = int.Parse(Line);
                        sumTemps += temp;
                        tempCount += 1;
                        if (temp >= threshold)
                        {
                            numAbove += 1;
                        }
                        else
                        {
                            numBelow += 1;
                        }
                        Line = sr.ReadLine();
                    }
                    Console.WriteLine("Temperature above = " + numAbove);
                    Console.WriteLine("Temperature below = " + numBelow);
                    int average = sumTemps / tempCount;
                    Console.WriteLine("Average temp =" + average);
                }
            }
           
            else
            {
                    Console.WriteLine("file does not exist");
            }



            

        }
            
    }
}
