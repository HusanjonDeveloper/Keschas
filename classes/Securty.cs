namespace Keschas.classes
{
    class Securty
    {
        public void ChekPassword()
        {
            string Password ="";

            do 
            {
                System.Console.WriteLine("Enter password");
                Password = Console.ReadLine();
                Console.Clear();
            }while(Password !="0");
        }
    }
}