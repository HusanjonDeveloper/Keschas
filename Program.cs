using System;
// Teach Keschas
using Keschas.classes;
namespace Keschas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Security security = new Security();
                security.CheckPassword();

                Bird kescha = new Bird(name: "Kescha", age: 3);
                Pet kasee = new Pet(name: "Kasee", age: 5);

                kescha.TypeBrid = Enums.BridType.Dog;
                kasee.TypePet = Enums.PetType.Cat;


                Console.WriteLine("kescha was created:" + kescha.CreatedDeTe);
                Console.WriteLine("kasee was create:" + kasee.CreatedDeTe);

                Console.WriteLine("Kescha_ " + kescha.TypeBrid);
                Console.WriteLine("Kasee_ " + kasee.TypePet);

                Console.WriteLine("Enter your name: "); // ismingizni kiriting
                string userName = Console.ReadLine();

                System.Console.WriteLine("Keschas says:");
                kescha.Greet(userName);

                kasee.Greet(userName);
                System.Console.WriteLine("Kasee says:");

                Console.WriteLine("Enter your age"); // Yoshingizni kiriting
                string agesString = Console.ReadLine();

                kasee.Greet2(userName);

                Console.WriteLine("converting...");

                int userAge = Convert.ToInt32(agesString);

                kescha.CalculetAgeDifferenceWithNoReturn(userAge);
                kescha.PrintAgeDifference();
                kescha.CopeirAge(userAge);
                kescha.TellAboutFriends(userName, userAge);

                Console.ReadKey();

            }
            catch (FormatException formatException)
            {
                Console.WriteLine($"Error was thrown. Message:{formatException.Message}");
            }
            catch (Exception exception)
            {
                Console.WriteLine("Erorr was thron. Type is Not known");
            }
            
            Console.WriteLine("Progrom ended...");
            Console.WriteLine("please try again");

        }

    }
}