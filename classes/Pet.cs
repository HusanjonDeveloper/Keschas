using Keschas.Enums;

namespace Keschas.classes
{
    public class Pet : animals
    {
        public PetType TypePet { get; set; }

        public Pet(string name, int age)
          : base(name, age)
        {

        }

        public override void Greet(string userName)
        {
            Console.WriteLine($"Meow, {userName}");
        }

        public override void Greet2(string userName)
        {
            Console.WriteLine("Abstracted Meted implemented");
        }
    }
}
