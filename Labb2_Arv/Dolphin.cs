namespace Labb2_Arv
{
    class Dolphin : Mammal
    {
        public Dolphin(string name, string gender, int age)
                       : base(name, gender, age)
        {
            Food = "fishes";
            Race = "dolphin";
            Sound = "'blaaaaare'";
             
        }
        string Swim()
        {
            return $"{Name} is swimming";
        }
        public override string DoMethods()
        {
            string output = $"\n\t{Name} is {blood}";
            return output += $"\n\t{MakeSound()}\n\t{Eat()}\n\t{Swim()}";
        }
    }
}
