using System;
using SmithLibrary.Tools;
using SmithLibrary.Extensions;


namespace SmithTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string temp = "test";

            Console.WriteLine("IsNumeric? : " + temp.IsNumeric());
            Console.WriteLine("IsDateTime? : " + temp.IsDateTime());
        }
    }
}
