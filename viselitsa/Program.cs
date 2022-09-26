using System;

namespace viselitsa
{
    class Program
    {
        static void Main(string[] args)
        {
            //Рандомное слово
            string[] slova = new string[10] { "тумбочка", "шкаф", "педикюр", "машина", "посуда", "война", "спецоперация", "повестка", "мобилизация", "z" };
            Random rnd = new Random();
            int value = rnd.Next(0, slova.Length) ;

            string slovo = slova[value];

            //Алгоритм программы
            string[] x = new string[slovo.Length];
            Console.Write("Ваше слово: ");
            for (int i = 0; i < slovo.Length; i++) {
                x[i] = "*";
                Console.Write(x[i]);
            }
            int popitki = slovo.Length;
            Console.WriteLine(" , у вас есть " + popitki + " попытки/(ок)");

            int h = 0;

            //Ввод
            Console.WriteLine("Введите букву:");
            for (int j = 0; j < popitki;) {

                int z = slovo.Length;

                if (popitki == 0)
                {
                    Console.WriteLine("Вы проиграли игру!");
                    break;
                } else if (h == z)
                {
                    Console.WriteLine("Вы выиграли, молодцы!");
                    break;
                }

                string b = Convert.ToString(slovo[h]);
                string r = Console.ReadLine();

                if (b == r)
                {
                    x[h] = b;
                    Console.Write("Ваше слово: ");
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        Console.Write(x[i]);
                    }
                    Console.WriteLine(" , у вас осталось " + popitki + " попытки/(ок)");
                    h++;
                }
                else {
                    Console.Write("Ваше слово: ");
                    for (int i = 0; i < slovo.Length; i++)
                    {
                        Console.Write(x[i]);
                    }
                    popitki--;
                    Console.WriteLine(" , у вас осталось " + popitki + " попытки/(ок)");

                
                } 
            }
        }
    }
}
