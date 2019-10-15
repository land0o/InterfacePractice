
namespace Interfaces
{
    public interface INameable
    {
        string Name { get; set; }
    }

    public interface IAge
    {
        int Age { get; }
        void IncrementAge();
    }
    public class Mammal
    {
        public double FurPercentage { get; set; }
    }

    public class Person : INameable, IAge
    {
        public Person(int age, string name)
        {
            Age = age;
            Name = name;
        }
        public string Name { get; set; }
        public int Age { get; private set; }
        public void IncrementAge()
        {
            Age++;
        }
        public override string ToString()
        {
            return $"{Name} is {Age} years old";
        }
    }
    public class Dog : Mammal, INameable, IAge
    {
        public Dog()
        {
            Age = 0;
        }
        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; private set; }
        public void IncrementAge()
        {
            if (Age > 20)
            {
                Age++;
                System.Console.WriteLine("Dog is old!");
            }
        }

    }
}