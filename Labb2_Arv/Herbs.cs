namespace Labb2_Arv
{
    abstract class Herbs : Plant
    {
        public Herbs(string name, string gender, int age)
                       : base(name, gender, age)
        {
        }
    }
    class Basil : Herbs
    {
        public Basil(string name, string gender, int age)
                      : base(name, gender, age)
        {
            Race = "herbs";
        }
    }
}
