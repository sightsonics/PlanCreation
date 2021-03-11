using System;
using System.IO;
using System.Text;

namespace TextWriter3
{
    class Program
    {
        static void Main(string[] args)
        {
            int weldNumber;
            // File name  
            string fileName = @"C:\SightSonics\ScanPlanCreation.ScanPlan.txt";
            FileStream stream = null;
            try
            {
                // Create a FileStream with mode CreateNew  
                stream = new FileStream(fileName, FileMode.OpenOrCreate);
                // Create a StreamWriter from FileStream  
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.WriteLine("*--------------------*");
                    writer.WriteLine("INSPECTION PLAN");
                    writer.WriteLine("*---------------------*");
                    writer.WriteLine("MODEL: 	2LL Dan Coupon Scan");
                    writer.WriteLine("LOCATION: 	2LL Dan Coupon Scan");
                    writer.WriteLine("PLAN: 	2LL Dan Coupon Scan");
                    writer.WriteLine("WELD NUMBER: 	542");
                    writer.WriteLine("\r");

                    do 
                        weldNumber += 1
                    writer.WriteLine("WELD 1");
                    writer.WriteLine("WELD ID: 	T6-001");
                    writer.WriteLine(@"SETUP PATH: 	C:\Program Files (x86)\SpotSight\Support Files\Setup Files\2x2 28db 8.usc");
                    writer.WriteLine("QUALITY LINE: 	1	4.00	0	0.00	0.00	0	0	8.00	8.00	3.200000");
                    writer.WriteLine("NUMBER OF SHEETS: 	3");
                    writer.WriteLine("SHEET 1: 	0.65	STEEL");
                    writer.WriteLine("SHEET 2: 	1.80	STEELL");
                    writer.WriteLine("SHEET 3: 	2.00	STEEL");
                    writer.WriteLine("GATE 1: 	1.23	0.38");
                    writer.WriteLine("GATE 2: 	1.62	0.20");
                    writer.WriteLine("JPEG PATH: ");
                    writer.WriteLine("ALIGNMENT FACTOR: 	0.000");
                    weldNumber <= 542;
                }
            }
            finally
            {
                if (stream != null)
                    stream.Dispose();
            }
            // Read a file  
            string readText = File.ReadAllText(fileName);
            Console.WriteLine(readText);
            Console.ReadKey();
        }
    }
}
