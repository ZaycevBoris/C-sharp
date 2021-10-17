using System;

namespace task4
{
    public class Parametr
    {
        public int num;
        public string str;
    public void Action()
    {
        Console.WriteLine($"num = {num} str = {str}");
    }
        public Parametr() { num = 32; str = "ddd"; }

        public Parametr(string n) { num = 18; str = n; }

    }

    class Program
    {
    static void Main(string[] args)
    {
        Parametr G = new Parametr();
        Parametr A = new Parametr("ppp");
            A.Action();
            G.Action();
     }
     }
}
