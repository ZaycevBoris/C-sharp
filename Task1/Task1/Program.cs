using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string a = null;
                a.ToUpper();
            }
            catch
            {
                Console.WriteLine("Исключение");
            }
        }

    }
}