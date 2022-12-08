namespace Keschas.classes
{
    public class Bird  : animals // animals - Perin class
    {        //Bird - Chain class
        public Bird(string name, int age)
           :base(name,age) // Chain - clasdagi narsani - Perin classga jonatish uchun (base) kalitidan foydalanamiz

        {
                      
        }
        public override void Greet(string userName)
        {
            Console.WriteLine($"Hello,{userName}");
        }

    }
}
