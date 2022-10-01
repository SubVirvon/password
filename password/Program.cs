using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;
            string message = "Секретное сообщение";
            int attemptsCount = 3;
            bool isLocked = true;

            Console.Write("Придумайте пороль: ");
            password = Console.ReadLine();
            Console.ReadKey();
            Console.Clear();

            for(int i = 0; i < attemptsCount; i++)
            {
                int attempt = attemptsCount - i;
                Console.Write("Осталось попыток: " + attempt + "\nВведите пароль: ");

                if(password == Console.ReadLine())
                {
                    isLocked = false;
                    Console.Clear();
                    break;
                }

                Console.Clear();
            }

            if(isLocked == false)
            {
                Console.WriteLine(message);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Вам не удалось войти");
                Console.ReadKey();
            }
        }
    }
}
