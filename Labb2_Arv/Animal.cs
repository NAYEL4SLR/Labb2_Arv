namespace Labb2_Arv
{

    abstract class Animal
    {
        protected string Name { get; set; } = "Animal";
        protected string Gender { get; set; } = "Unknown";
        protected string Sound { get; set; } = "Undefined";
        protected string Food { get; set; } = "Food";
        protected string Race { get; set; } = "Animal";
        protected bool Wild { get; set; } = true;
        protected int Age { get; set; } = 0;
        protected Animal(string name, string gender, int age)
        {
            Name = name;
            Gender = gender;
            Age = age;
        }
        protected string MakeSound()
        {
            return $"{Name} says: {Sound}";
        }
        protected string Eat()
        {
            return $"{Name} is having {Food}";
        }
        public virtual string DoMethods()
        {
            return $"\n\t'{MakeSound()}'\n\t{Eat()}";
        }
        public override string ToString()
        {
            return $"\n\t{Name} is a {Age} years old {Gender} {Race}";
        }
    }
    abstract class Mammal : Animal
    {
        protected string blood { set; get; } = "warm blooded";
        protected Mammal(string name, string gender, int age)
                       : base(name, gender, age)
        {
        }
    }
    abstract class Reptile : Animal
    {
        protected Reptile(string name, string gender, int age)
                       : base(name, gender, age)
        {
        }
        protected string Crawl()
        {
            return $"{Name} is crawling";
        }
    }
    abstract class Plant : Animal
    {
        protected bool Eatable { get; set; }
        public Plant(string name, string gender, int age)
                       : base(name, gender, age)
        {
            Gender = "none";
            Food = "water";
            Sound = "nothing";
        }
        string Grow()
        {
            return $"{Name} likes to keep growing";
        }
        public override string DoMethods()
        {
            return $"\n\t{MakeSound()}\n\t{Eat()}\n\t{Grow()}";
        }
    }

}
