using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson4._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Dictionary<string, string> dictionary = new Dictionary<string, string>();
                dictionary.Add("Monday", "Понедельник");
                dictionary.Add("Table", "Стол");
                dictionary.Add("Stone", "Камень");
                dictionary.Add("Ship", "Корабль");
                dictionary.Add("House", "Дом");
                dictionary.Add("Cat", "Кот");
                dictionary.Add("Woman", "Женщина");
                dictionary.Add("Cup", "Кружка");
                dictionary.Add("Cloud", "Облако");
                dictionary.Add("Flower", "Цветок");

                while (true)
                {
                    Console.WriteLine("Введите английское слово: ");

                    string word = Console.ReadLine();
                    if (dictionary.ContainsKey(word))
                    {
                        Console.WriteLine(dictionary[word]);
                    }
                    else
                        Console.WriteLine("Слово не было найдено");

                }
            }
        }
    }
}
