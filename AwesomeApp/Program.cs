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

            foreach(int a in arr)
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
