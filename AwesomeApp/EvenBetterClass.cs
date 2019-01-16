using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeApp
{
    public class EvenBetterClass:AwesomeClass
    {
        static int baseCnt = 0;
        public string Sex;
        public string Usr;
        public EvenBetterClass()
        {
            
            baseCnt++;
            Console.WriteLine("EvenBetterClass constructor");
            System.Diagnostics.Debug.Print($"EvenBetterClass constructor {baseCnt}");
        }

        ~EvenBetterClass()
        {
            baseCnt++;
            Console.WriteLine("EvenBetterClass constructor");
            System.Diagnostics.Debug.Print($"EvenBetterClass constructor {baseCnt}");
        }

        void SetEvenBetterClass(string usr, string pwd, uint port, string sex)
        {
            this.SetAwesomeClass(usr, pwd, port);
            this.Sex = sex;
            
        }

        public static void StaticClassRefTest(int[] d)
        {
            for(int i = 0; i < d.Length; i++)
            {
                Console.WriteLine($"EvenBetterClass StaticClass {d[i]}");
                d[i]++;
            }
        }


    }
}
