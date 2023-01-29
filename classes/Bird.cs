using Keschas.Enums;
namespace Keschas.classes
{
    public class Bird : animals
    {
        public BridType TypeBrid { get; set; }
        public Bird(string name, int age)
           : base(name, age) // Chain - clasdagi narsani - Perin classga jonatish uchun (base) kalitidan foydalanamiz
        {

        }
        public override void Greet(string userName)
        {
            Console.WriteLine($"Hello,{userName}");
        }
        public override void Greet2(string userName)
        {
            System.Console.WriteLine();
        }
    }
}