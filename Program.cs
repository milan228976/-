using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using static System.Net.Mime.MediaTypeNames;

namespace String_Metods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Выберите задание:");
                Console.WriteLine("1 - Задание 1");
                Console.WriteLine("2 - Задание 2");
                Console.WriteLine("3 - Задание 3");
                Console.WriteLine("4 - Задание 4");
                Console.WriteLine("5 - Задание 5");
                Console.WriteLine("6 - Задание 6");
                Console.WriteLine("7 - Задание 7");
                Console.WriteLine("8 - Задание 8");
                Console.WriteLine("9 - Задание 9");
                Console.WriteLine("10 - Задание 10");
                Console.WriteLine("11 - Задание 11");
                Console.WriteLine("12 - Задание 12");
                Console.WriteLine("13 - Задание 13");
                Console.WriteLine("14 - Задание 14");
                Console.WriteLine("15 - Задание 15");
                Console.WriteLine("16 - Задание 16");
                Console.WriteLine("17 - Задание 17");
                Console.WriteLine("18 - Задание 18");
                Console.WriteLine("0 - Выход");

                string choice = Console.ReadLine();
                
                if (choice == "1")
                {
                    Console.WriteLine("Введите первое слово");
                    string word = Console.ReadLine();
                    Console.WriteLine(word.Length);
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Введите строку");
                    string word = Console.ReadLine();
                    Console.WriteLine("В каком регистре хотите вывести строку?");
                    Console.WriteLine("1 - верхний");
                    Console.WriteLine("2 - нижний");
                    string aro = Console.ReadLine();
                        if (aro == "1")
                    {
                        Console.WriteLine(word.ToUpper());
                    }
                    else
                    {
                        Console.WriteLine(word.ToLower());
                    }
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Введите строку, 5 первых символов которой выведится в консоль");
                    string word = Console.ReadLine();
                    if (word.Length > 5)
                    {
                        Console.WriteLine(word.Substring(0, 5));
                    }
                    else
                    {
                        Console.WriteLine(word);
                    }
                }
                else if (choice == "4")
                {
                    Console.WriteLine("Введите пару слов, я заполню их пробелами");
                    string word = Console.ReadLine();
                    Console.WriteLine(word.Replace(" ", "_"));
                }
                else if (choice == "5")
                {
                    Console.WriteLine("Введите предложние которое содержит C#");
                    string word = Console.ReadLine();
                    if (word.Contains("C#"))
                    {
                        Console.WriteLine("Содержит");
                    }
                    else
                    {
                        Console.WriteLine("Не содержит");
                    }
                }
                else if (choice == "6")
                {
                    Console.WriteLine("Введите слово, а я найду в нем букву А");
                    string word = Console.ReadLine();
                    if (word.Contains("А"))
                    {
                        Console.WriteLine(word.IndexOf("А"));
                        Console.WriteLine(word.LastIndexOf("А"));
                    }
                    else
                    {
                        Console.WriteLine("В этом слове нет буквы А");
                    }
                }
                else if (choice == "7")
                {
                    Console.WriteLine("Введите ссылку которая начинается на /https а заканчивается на .com");
                        string word = Console.ReadLine();
                    if (word.StartsWith("/https") && word.EndsWith(".com")) 
                    {
                        Console.WriteLine("Ваша ссылка правильная");
                    }
                    else
                    {
                        Console.WriteLine("Ваша ссылка неправильная");
                    }
                }
                else if (choice == "8")
                {
                    Console.WriteLine("Введите строку с пробелами и я их удалю");
                    string word = Console.ReadLine();

                    Console.WriteLine("Выберите вариант обработки вашего текста");
                    Console.WriteLine("1 - через Trim");
                    Console.WriteLine("2 - через TrimStart и TrimEnd");

                    string word2 = Console.ReadLine();
                    if (word2 == "1")
                        Console.WriteLine(word.Trim( ));
                    else
                    {
                        Console.WriteLine(word.TrimStart().TrimEnd( ));
                    }
                }
                else if (choice == "9")
                {
                    Console.WriteLine("Введите предложение");
                        string word = Console.ReadLine();
                    Console.WriteLine(word.Split(' '));
                    string[] words = word.Split(' ');
                    foreach (string item in words )
                    {
                        Console.WriteLine(item);
                    }

                }
                else if (choice == "10")
                {
                    string[] word = { "Я", "учу", "C#" };
                    string result = String.Join(" ", word);
                    Console.WriteLine(result);
                }
                else if(choice == "11")
                {
                    Console.WriteLine("Введите строку, позицию символа и текст который хотите вставить поочередно");
                    string word = Console.ReadLine();
                    Console.WriteLine("Теперь введи позицию символа");
                    string a = Console.ReadLine();
                    int position = int.Parse(a);
                    Console.WriteLine("А теперь введи текст который хочешь вставить");
                    string text = Console.ReadLine();
                    Console.WriteLine(word.Insert(position, text));
                }
                else if (choice == "12")
                {
                    Console.WriteLine("Введите строку, номер символа и кол-во символов которые нужно удалить поочередно");
                    string word = Console.ReadLine();
                    Console.WriteLine("Теперь введи номер символа");
                    string a = Console.ReadLine();
                    int b = int.Parse(a);
                    Console.WriteLine("А теперь количество символов");
                    string c = Console.ReadLine();
                    int d = int.Parse(c);
                    Console.WriteLine(word.Remove(b, d));
                }
                else if (choice == "13")
                {
                    Console.WriteLine("Введите первую строку");
                    string word = Console.ReadLine();
                    Console.WriteLine("Введите вторую строку");
                        string word2 = Console.ReadLine();
                    Console.WriteLine(string.Compare(word, word2));
                }
                else if (choice == "14")
                {
                    Console.WriteLine("Введите первую строку");
                    string word = Console.ReadLine();
                    Console.WriteLine("Введите вторую строку");
                    string word2 = Console.ReadLine();
                    if (string.Equals(word, word2))
                    {
                        Console.WriteLine("True");
                    }
                    else
                    {
                        Console.WriteLine("False");
                    }
                }
                else if (choice == "15")
                {
                    string[] word = { "Я", "люблю", "маму" };
                    string[] word2 = { "Я", "люблю", "папу" };
                    string[] word3 = { "Я", "люблю", "бабушку" };
                    Console.WriteLine(string.Concat(word, word2, word3));
                }
                else if (choice == "16")
                {
                    Console.WriteLine("Введите слово");
                    string word = Console.ReadLine();
                    Console.WriteLine(word.PadLeft(5).PadRight(5));
                }
                else if (choice == "17")
                {
                    Console.WriteLine("Введите символы , . ! ?");
                    string word = Console.ReadLine();
                    word = word.Replace(',', ';');
                    word = word.Replace('.', ';');
                    word = word.Replace('!', ';');
                    word = word.Replace('?', ';');
                    Console.WriteLine(word);

                }
                else if (choice == "18")
                {
                    Console.WriteLine("Введи имя");
                    string name = Console.ReadLine();
                    Console.WriteLine("Введи возраст");
                    string age = Console.ReadLine();
                    int age1 = int.Parse(age);
                    Console.WriteLine($"Привет, {name}. Ого, тебе уже {age1}");
                }
                else if (choice == "0")
                {
                    exit = true;
                    break;
                }
            }
        }
    }
}
