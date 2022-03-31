using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sobytie
{
    class Program
    {
        static void Main(string[] args)
        {
            Sob sob = new Sob();

            sob.OnKeyPressed += Sob_OnKeyPressed;
            Console.WriteLine("Для завершения нажмите C");
            Console.WriteLine("Введите символ");

            sob.Run();
        }

        static void Sob_OnKeyPressed(Object sender, char sobyt)
        {
            Console.WriteLine($"{sobyt}");
        }
    }

    class Sob
    {
        public event EventHandler<char>? OnKeyPressed;

        ConsoleKeyInfo key;

        public void Run()
        {
            while (Console.ReadKey().Key != ConsoleKey.C)
            {

                key = Console.ReadKey();
                char sobyt = key.KeyChar;

                OnKeyPressed?.Invoke(this, sobyt);
            }

        }
    }
}
