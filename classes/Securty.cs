namespace Keschas.classes
{
    public class Security
    {
        public void CheckPassword()
        {
            string Password = "";

            do
            {
                Console.WriteLine("Enter password");
                Password = Console.ReadLine();
                Console.Clear();

            } while (Password != "0");
        }
    }
}
