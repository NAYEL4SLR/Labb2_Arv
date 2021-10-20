namespace Labb2_Arv
{
    abstract class Bird : Animal
    {
        protected bool Feathers { get; set; } = false;
        protected Bird(string name, string gender, int age)
                    : base(name, gender, age)
        {

        }
        protected string BuildNest()
        {
            return $"{Name} is building a nest";
        }

    }
    abstract class FlyingBird : Bird
    {
        protected FlyingBird(string name, string gender, int age)
                          : base(name, gender, age)
        {

        }
        protected string Fly()
        {
            return $"{Name} is flying";
        }
        public override string DoMethods()
        {
            string output = string.Empty;
            if (Feathers)
            {
                output = $"\n\t{Name} has feathers";
            }
            return output += $"\n\t{MakeSound()}\n\t{Eat()}\n\t" +
                             $"{BuildNest()}\n\t{Fly()}";
        }
    }
    class Eagle : FlyingBird
    {
        public Eagle(string name, string gender, int age)
                     : base(name, gender, age)
        {
            Food = "mice";
            Race = "eagle";
            Sound = "'screech'";
            Feathers = true;
        }
    }
    abstract class UnflyingBird : Bird
    {
        protected UnflyingBird(string name, string gender, int age)
                            : base(name, gender, age)
        {

        }
        protected string Walk()
        {
            return $"{Name} is walking";
        }
        public override string DoMethods()
        {
            string output = string.Empty;
            if (Feathers)
            {
                output = $"\n\t{Name} has feathers";
            }
            return output += $"\n\t{MakeSound()}\n\t{Eat()}\n\t" +
                             $"{BuildNest()}\n\t{Walk()}";
        }
    }
    class Chicken : UnflyingBird
    {
        public Chicken(string name, string gender, int age)
                     : base(name, gender, age)
        {
            Food = "corn";
            Race = "'chicken'";
            Sound = "'cha - caw, bah - gawk'";
            Feathers = true;
        }
    }

}
