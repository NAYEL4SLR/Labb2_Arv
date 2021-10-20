namespace Labb2_Arv
{
    class Human : Mammal
    {
        private string moves { set; get; } = "goes on two feet";
        public Human(string name, string gender, int age)
                       : base(name, gender, age)
        {
            Food = "pizza";
            Race = "human";
            Sound = "'Hi! how are you?'";
            Wild = false;
        }
        protected string Learn()
        {
            return $"{Name} is learning about life";
        }
        public override string DoMethods()
        {
            string output = $"\n\t{Name} {moves}";
            return output += $"\n\t{MakeSound()}\n\t{Eat()}\n\t{Learn()}";
        }
        public override string ToString()
        {
            return $"\n\t{Name} is a {Age} years old {Gender}";
        }

    }

}
