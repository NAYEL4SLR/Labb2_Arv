namespace Labb2_Arv
{
    class Crocodile : Reptile
    {
        string blood { set; get; } = "cold blooded";
        public Crocodile(string name, string gender, int age)
                         : base(name, gender, age)
        {
            Food = "ducks";
            Race = "crocodile";
            Sound = "'growl'";
        }
        public override string DoMethods()
        {
            string output = $"\n\t{Name} is {blood}";
            return output += $"\n\t{MakeSound()}\n\t{Eat()}\n\t{Crawl()}";
        }
    }
}
