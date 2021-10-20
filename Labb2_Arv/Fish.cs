namespace Labb2_Arv
{
    abstract class Fish : Animal
    {
        protected string Environment { get; set; } = "water";
        protected Fish(string name, string gender, int age)
                    : base(name, gender, age)
        {

        }
        protected string Swim()
        {
            return $"{Name} is swimming";
        }
    }
    class Salmon : Fish
    {
        public Salmon(string name, string gender, int age)
                    : base(name, gender, age)
        {
            Environment = "salt and freshwater";
            Food = "squid";
            Race = "salmon";
            Sound = "'growls'";
            Wild = true;

        }
        public override string DoMethods()
        {
            string output = $"\n\t{Name} lives in {Environment}";
            if (Wild)
            {
                output = $"\n\t{Name} is a wild animal";
            }
            return output += $"\n\t{MakeSound()}\n\t{Eat()}\n\t{Swim()}";
        }
    }
    class Goldfish : Fish
    {
        public Goldfish(string name, string gender, int age)
                    : base(name, gender, age)
        {
            Environment = "freshwater";
            Food = "insects";
            Race = "goldfish";
            Sound = "'purrs'";
            Wild = false;
        }
        public override string DoMethods()
        {
            string output = $"\n\t{Name} lives in {Environment}";
            return output += $"\n\t{MakeSound()}\n\t{Eat()}\n\t{Swim()}";
        }
    }
}
