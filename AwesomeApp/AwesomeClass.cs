using System;
namespace AwesomeApp
{
    public class AwesomeClass
    {
        private string usr;
        private string pwd;
        private uint port;

        public AwesomeClass()
        {
            Console.WriteLine("AwesomeClass constructor");
            usr = "";
            pwd = "";
            port = 0;
        }

        public void SetAwesomeClass(string usr, string pwd, uint port)
        {
            Console.WriteLine($"SetAwesomeClass \n {this.usr}->{usr} \n {this.pwd}->{pwd} \n {this.port}->{port}");
            this.usr = usr;
            this.pwd = pwd;
            this.port = port;
        }
    }
}
