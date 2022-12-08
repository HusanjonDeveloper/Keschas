namespace Keschas.classes
{
    public class Pet : animals
    {
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
            System.Console.WriteLine("Abstracted Meted implemented");
        }
    }
}