
namespace Keschas.classes
{
    public abstract class animals : IAnimal, IPet
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int AgeDifference { get; set; }

        public DateTimeOffset CreatedDeTe { get; set; }

        public animals()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
            CreatedDeTe = DateTimeOffset.Now;
        }

        public animals(string name, int age)
        {
            Name = name;
            Age = age;
            CreatedDeTe = DateTimeOffset.Now;
        }

        public animals(string name,
        int userAge,
        int animalAge)
        {
            Name = name;
            Age = animalAge;

            CalculetAgeDifferenceWithNoReturn(userAge, animalAge);

            CreatedDeTe = DateTimeOffset.Now;
        }

        public abstract void Greet2(string userName);

        public void PrintAgeDifference()
        {
            Console.WriteLine($"the difference between your and {Name}'s age is: {AgeDifference} ");
        }

        public void CopeirAge(int userAge)
        {
            if (userAge > Age)
            {
                Console.WriteLine("you are older!");
            }
            else if (userAge == Age)
            {
                Console.WriteLine("you are equal!");
            }
            else
            {
                Console.WriteLine("you are younger!");
            }
        }
        public void TellAboutFriends(string userName, int userAge)
        {
            Console.WriteLine("Let me tell you about my friends.");
            string[] friendsName = new String[3];
            friendsName[0] = "Kascha";
            friendsName[1] = "kasee";
            friendsName[2] = userName;
            int[] friendsAge = { 3, 5, userAge };
            string[] adrs = { "Andjon", "Fargona", "Namangan" };

            for (int i = 0; i < friendsName.Length; i++)
            {
                Console.WriteLine($"{friendsName[i]} is {friendsAge[i]}");
            }
            //index yordamida  unga qiymat berish mumkin
            friendsAge[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{friendsName[2]} is {friendsAge[2]} yeqr old!");

        }
        public void CalculetAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }
        public int CalculetAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }
        public virtual void Greet(string userName)
        {
            if (userName == "")
            {
                userName = "Unknown Person";
            }
            Console.WriteLine($"Hello,{userName}");
        }
        private void CalculetAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}

