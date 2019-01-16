using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //StructVsClass();
            Inheritance();


        }

        private static void StructVsClass()
        {
            Console.WriteLine($"-----StructVsClass-----");
            EmptyClass eC1 = new EmptyClass(10,"10");
            EmptyStruct eS1 = new EmptyStruct(10, "10");
            //eC1.i = 10;
            //eC1.s = "10";
            //eS1.i = 10;
            //eS1.s = "10";

            EmptyClass eC2 = new EmptyClass();
            EmptyStruct eS2 = new EmptyStruct();

            eC2 = eC1;
            eS2 = eS1;

            eC1.i = 20;
            eC1.s = "20";
            eS1.i = 20;
            eS1.s = "20";

            Console.WriteLine($"eC1:i={eC1.i};s={eC1.s}");
            Console.WriteLine($"eC2:i={eC2.i};s={eC2.s}");
            Console.WriteLine($"eS1:i={eS1.i};s={eS1.s}");
            Console.WriteLine($"eS2:i={eS2.i};s={eS2.s}");
            Console.WriteLine($"-----------V-----------");
        }

        private static void Inheritance()
        {
            Console.WriteLine($"-----Inheritance-----");

            AwesomeClass aC = new AwesomeClass();
            EvenBetterClass eBC = new EvenBetterClass();

            AwesomeClass.StaticClass("AC");
            EvenBetterClass.StaticClass("EBC");

            Console.WriteLine("aC is Awesome: "+((aC is AwesomeClass)?"true":"false"));
            Console.WriteLine("aC is EvenBetter: " + ((aC is EvenBetterClass) ? "true" : "false"));
            Console.WriteLine("eBC is Awesome: " + ((eBC is AwesomeClass) ? "true" : "false"));
            Console.WriteLine("eBC is EvenBetter: " + ((eBC is EvenBetterClass) ? "true" : "false"));

            Console.WriteLine($"---------------------");

        }

        private static void trash()
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            int[] arr = { 1, 2, 3, 6 };
            AwesomeClass aC = new AwesomeClass();
            EvenBetterClass eBC = new EvenBetterClass();
            aC.SetAwesomeClass("torkness", "tajneHaslo", 433);
            aC.SetAwesomeClass("dawddragon", "strasznieTajneHaslo", 8080);
            aC.SetAwesomeClass("daniel.matysiewicz", "Haslo", 22);
            AwesomeClass.StaticClass("d");

            aC.Usr = "rabarbar";
            aC.readData();

            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            EvenBetterClass.StaticClassRefTest(arr);
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            EvenBetterClass.StaticClassRefTest(arr);
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            EvenBetterClass.StaticClassRefTest(arr);
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
            AwesomeClass.StaticClass("d");


            Program.TryCatch(1);
            Program.TryCatch(4);
            Program.TryCatch(0);


            Console.WriteLine("Hello again cruel World!");

            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }

        private static void TryCatch(int div)
        {
            Console.WriteLine(div);
            try
            {
                Console.WriteLine($"try: 100/{div}");
                Console.WriteLine($"try: {100/div}");
            }
            
            catch (DivideByZeroException e)
            {
                Console.WriteLine($"Catch DivByZero: {e.Message}");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Catch: {e.Message}");
            }
            finally
            {
                Console.WriteLine("Finally");
            }
            Console.WriteLine("\n\n\n");
        }
    }
}
