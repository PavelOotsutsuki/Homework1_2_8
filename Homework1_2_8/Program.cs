using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1_2_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "password123";
            string secretMessage = "Во поле берёзка стояла";
            int inputTry = 3;
            bool isSuccessPasswordInput = false;

            while (inputTry>0 && isSuccessPasswordInput==false)
            {
                Console.Write("Введите пароль: ");
                string inputPassword=Console.ReadLine();

                if (password == inputPassword)
                {
                    isSuccessPasswordInput = true;
                    Console.WriteLine("Секретное сообщение: " + secretMessage);
                }
                else
                {
                    inputTry--;
                    Console.WriteLine("Неверный пароль. У Вас осталось " + inputTry + " попыток.");
                }
            }
        }
    }
}