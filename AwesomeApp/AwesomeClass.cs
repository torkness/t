using System;
namespace AwesomeApp
{
    public class AwesomeClass
    {
        private string usr;
        private string pwd;
        private uint port;

        public string Usr
        {
            get
            {
               return this.usr;
            }
            set
            {
                this.usr = value;
            }
        }

        static int baseCnt = 0;

        public AwesomeClass()
        {
            Console.WriteLine("AwesomeClass constructor");
            //System.Diagnostics.Debug.Print($"AwesomeClass constructor {baseCnt}");
            usr = "";
            pwd = "";
            port = 0;
            baseCnt++;
        }
        public AwesomeClass(string usr, string pwd)
        {
            Console.WriteLine("AwesomeClass custom constructor");
            //System.Diagnostics.Debug.Print($"AwesomeClass constructor {baseCnt}");
            this.usr = usr;
            this.pwd = pwd;
            port = 0;
            baseCnt++;
        }
        ~AwesomeClass()
        {
            
            baseCnt--;
            Console.WriteLine($"AwesomeClass destructor {baseCnt}");
            System.Diagnostics.Debug.Print($"AwesomeClass destructor {baseCnt}");
        }

        public void SetAwesomeClass(string usr, string pwd, uint port)
        {
            Console.WriteLine($"SetAwesomeClass \n {this.usr}->{usr} \n {this.pwd}->{pwd} \n {this.port}->{port}");
            this.usr = usr;
            this.pwd = pwd;
            this.port = port;
        }

        public void readData()
        {
            Console.WriteLine($"readData_AwesomeClass \n {this.usr} \n {this.pwd} \n {this.port}");

        }

        public static void StaticClass(string r)
        {
            Console.WriteLine($"AwesomeClass {r} {baseCnt}");
        }

            
    }
}
