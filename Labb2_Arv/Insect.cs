namespace Labb2_Arv
{
    class Insect : Animal
    {
        protected int Legs { get; set; } = 6;
        public Insect(string name, string gender, int age)
                      : base(name, gender, age)
        {
            Wild = true;
        }
        protected string ShedSkin()
        {
            return $"{Name} is shedding its skin";
        }
        public override string DoMethods()
        {
            string output = $"\n\t{Name} has {Legs} legs";
            output = $"\n\t{Name} is a wild animal";
            return output += $"\n\t{MakeSound()}\n\t{Eat()}\n\t{ShedSkin()}";
        }
    }
    class Spider : Insect
    {
        public Spider(string name, string gender, int age)
                      : base(name, gender, age)
        {
            Legs = 8;
            Food = "flys";
            Race = "spider";
            Sound = "'purring'";
        }

    }
}
