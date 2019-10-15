using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jill = new Person(28, "Jill");

            System.Console.WriteLine(Jill);
            AgeThat(Jill);
            System.Console.WriteLine("--aged a year--");
            System.Console.WriteLine(Jill);

            static void AgeThat(IAge ageable)
            {
                ageable.IncrementAge();
            }
        }
    }
}
