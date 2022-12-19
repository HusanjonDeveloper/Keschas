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
                animals kasee = new Pet(name: "Kasee", age: 5);

                Console.WriteLine("kescha was created:" + kescha.CreatedDeTe);
                Console.WriteLine("kasee was create:" + kasee.CreatedDeTe);

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

                Console.WriteLine($"Successfully convertiSng! {userAge}");
                kescha.CalculetAgeDifferenceWithNoReturn(userAge);
                int AgeDifference = userAge - kescha.Age;
                //Console.WriteLine($"the difference between your and Kescha's age is: {kescha.AgeDifference} "); // sizning  va keschaning orasidagi farq
                kescha.PrintAgeDifference();
                //  teach-if
                kescha.CopeirAge(userAge);
                //Metods

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

        }

    }
}