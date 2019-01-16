using System;
namespace AwesomeApp
{
    public struct EmptyStruct
    {
        public int i;
        public string s;

        public EmptyStruct(int i, string s)
        {
            Console.WriteLine("EmptyStruct const");
            this.i = i;
            this.s = s;
        }
    }
}
