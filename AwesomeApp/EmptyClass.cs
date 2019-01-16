using System;
namespace AwesomeApp
{
    public class EmptyClass
    {



        public int i;
        public string s;

        public EmptyClass()
        {

        }

        public EmptyClass(int i, string s)
        {
            Console.WriteLine("EmptyClass const");
            this.i = i;
            this.s = s;
        }
    }
}
