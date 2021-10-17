using System;

namespace task3
{
    public interface animals
    {
        public void Sound();
    }
    class cat : animals
    {
        public void Sound()
        {
            Console.WriteLine("Мяу Мяу");
        }
    }
    class dog : animals
    {
        public void Sound()
    {
        Console.WriteLine("Гав гав");
    }
    }
    class Program
    {
        static void  Sounds(animals _animals)
        {
            _animals.Sound();
        }
        static void Main(string[] args)
        {
            cat cat = new cat();
            dog dog = new dog();
            Sounds(dog);
            Sounds(cat);
        }
    }
}


