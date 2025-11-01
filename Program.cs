using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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
                Console.WriteLine("19 - Задание 19");
                Console.WriteLine("20 - Задание 20");
                Console.WriteLine("21 - Задание 21");
                Console.WriteLine("22 - Задание 22");
                Console.WriteLine("23 - Задание 23");
                Console.WriteLine("24 - Задание 24");
                Console.WriteLine("25 - Задание 25");
                Console.WriteLine("26 - Задание 26");
                Console.WriteLine("27 - Задание 27");
                Console.WriteLine("28 - Задание 28");
                Console.WriteLine("29 - Задание 29");
                Console.WriteLine("30 - Задание 30");
                Console.WriteLine("31 - Задание 31");
                Console.WriteLine("32 - Задание 32");
                Console.WriteLine("33 - Задание 33");
                Console.WriteLine("34 - Задание 34");
                Console.WriteLine("35 - Задание 35");
                Console.WriteLine("36 - Задание 36");
                Console.WriteLine("37 - Задание 37");
                Console.WriteLine("38 - Задание 38");
                Console.WriteLine("39 - Задание 39");
                Console.WriteLine("40 - Задание 40");
                Console.WriteLine("41 - Задание 41");
                Console.WriteLine("42 - Задание 42");
                Console.WriteLine("43 - Задание 43");
                Console.WriteLine("44 - Задание 44");
                Console.WriteLine("45 - Задание 45");
                Console.WriteLine("46 - Задание 46");
                Console.WriteLine("47 - Задание 47");
                Console.WriteLine("48 - Задание 48");
                Console.WriteLine("49 - Задание 49");
                Console.WriteLine("50 - Задание 50");
                Console.WriteLine("51 - Задание 51");
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
                        Console.WriteLine(word.Trim());
                    else
                    {
                        Console.WriteLine(word.TrimStart().TrimEnd());
                    }
                }
                else if (choice == "9")
                {
                    Console.WriteLine("Введите предложение");
                    string word = Console.ReadLine();
                    Console.WriteLine(word.Split(' '));
                    string[] words = word.Split(' ');
                    foreach (string item in words)
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
                else if (choice == "11")
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
                else if (choice == "19")
                {
                    Console.WriteLine("введите свое имя");
                    string name = Console.ReadLine();
                    Console.WriteLine($"Привет, {name}!");
                }
                else if (choice == "20")
                {
                    Console.WriteLine("Введите первое число");
                    string a = Console.ReadLine();
                    int a1 = int.Parse(a);
                    Console.WriteLine("Введите второе число");
                    string b = Console.ReadLine();
                    int b1 = int.Parse(b);
                    int c = a1 + b1;
                    Console.WriteLine(c);
                }
                else if (choice == "21")
                {
                    Console.WriteLine("Введи число, и я скажу четное оно или нет");
                    int a = int.Parse(Console.ReadLine());
                    if (a % 2 == 0)
                    {
                        Console.WriteLine("Число четное");
                    }
                    else
                    {
                        Console.WriteLine("Число нечетное");
                    }
                }
                else if (choice == "22")
                {
                    string name = "Михаил";
                    byte age = 18;
                    byte height = 176;
                    Console.WriteLine($"Меня зовут {name}, мне {age} лет, и мой рост {height}см");
                }
                else if (choice == "23")
                {
                    byte a = 50;
                    byte b = 55;
                    Console.WriteLine(a + b);
                    Console.WriteLine(a - b);
                    Console.WriteLine(a / b);
                    Console.WriteLine(a * b);
                }
                else if (choice == "24")
                {
                    Console.WriteLine("введите радиус");
                    int r = int.Parse(Console.ReadLine());
                    const double PI = 3.14;
                    double S = PI * r * r;
                    Console.WriteLine($"Площадь круга равна {S}");
                }
                else if (choice == "25")
                {
                    int temperature = 25;
                    Console.WriteLine((temperature + 5) / 2);
                }
                else if (choice == "26")
                {
                    Console.WriteLine("Введите количество долларов, чтобы перевести их в рубли");
                    double USD = double.Parse(Console.ReadLine());
                    const double USD_TO_RUB = 97.5;
                    double result = USD * USD_TO_RUB;
                    Console.WriteLine($"Ваш результат: {result}");
                }
                else if (choice == "27")
                {
                    int a = 25;
                    double b = 25.2;
                    char c = 'a';
                    string d = "aboba";
                    bool e = false;
                    bool f = true;
                    Console.WriteLine($"a = {a}, b = {b}, c = {c}, d = {d}, e = {e}, f = {f}");
                }
                else if (choice == "28")
                {
                    int a = 10;
                    int b = 3;
                    Console.WriteLine(a + b);
                    Console.WriteLine(a * b);
                    Console.WriteLine(a % b);
                    double c = (double)a / b;
                    Console.WriteLine(c);
                }
                else if (choice == "29")
                {
                    char letter = 'A';
                    int ASC = (int)letter;
                    Console.WriteLine(ASC);
                }
                else if (choice == "30")
                {
                    int a = 1;
                    int b = 0x1a;
                    int c = 0b1011;
                    Console.WriteLine(a + b + c);
                }
                else if (choice == "31")
                {
                    int a = 5;
                    double b = 2.5;
                    char c = 'A';
                    bool flag = true;
                    Console.WriteLine(a * b + c + (flag ? 10 : 0));
                }
                else if (choice == "32")
                {
                    int a = 5;
                    int b = 6;
                    Console.WriteLine(a & b);
                    Console.WriteLine(a | b);
                }
                else if (choice == "33")
                {
                    int a = 5;
                    int b = 6;
                    Console.WriteLine(a ^ b);
                }
                else if (choice == "34")
                {
                    int a = 5;
                    Console.WriteLine(~a);
                }
                else if (choice == "35")
                {
                    int a = 5;
                    Console.WriteLine(a << 2);
                    Console.WriteLine(a >> 2);
                }
                else if (choice == "36")
                {
                    Console.WriteLine("введите число");
                    int a = int.Parse(Console.ReadLine());
                    string b = Convert.ToString(a, 2);
                    Console.WriteLine(b);
                    int c = int.Parse(b);
                    Console.WriteLine(c << 3);
                    Console.WriteLine(~c);
                    Console.WriteLine(c ^ 15);
                }
                else if (choice == "37")
                {
                    int a = 10;
                    Console.WriteLine(a += 5);
                }
                else if (choice == "38")
                {
                    int b = 20;
                    b -= 4;
                    b *= 2;
                    b /= 3;
                    Console.WriteLine(b);
                }
                else if (choice == "39")
                {
                    int c = 17;
                    Console.WriteLine(c %= 5);
                }
                else if (choice == "40")
                {
                    int d = 5;
                    Console.WriteLine(d &= 3);
                    Console.WriteLine(d |= 2);
                    Console.WriteLine(d ^= 1);
                }
                else if (choice == "41")
                {
                    int e = 8;
                    Console.WriteLine(e <<= 2);
                    Console.WriteLine(e >>= 1);
                }
                else if (choice == "42")
                {
                    int a = 25;
                    double b = a;
                }
                else if (choice == "43")
                {
                    double num = 12.9;
                    int b = (int)num;
                }
                else if (choice == "44")
                {
                    Console.WriteLine("Введи число с плавающей точкой");
                    double a = Convert.ToDouble(Console.ReadLine());
                }
                else if (choice == "45")
                {
                    Console.WriteLine("Введи строку 123:");
                    string a = Console.ReadLine();

                    if (int.TryParse(a, out int b))
                    {
                        Console.WriteLine($"Вот ваше число, но в виде int: {b}");
                    }
                    else
                    {
                        Console.WriteLine("Ты ввел неправильное число");
                    }
                }
                else if (choice == "46")
                {
                    Console.WriteLine("Введи дробное число");
                    double a = double.Parse(Console.ReadLine());
                    int b = (int)a;
                    char c = (char)b;
                }
                else if (choice == "46")
                {
                    Console.WriteLine("Введие число, и я скажу больше ли оно нуля или нет");
                    int a = int.Parse(Console.ReadLine());
                    if (a > 0)
                    {
                        Console.WriteLine("Ваше число больше нуля");
                    }
                    else if (a < 0)
                    {
                        Console.WriteLine("Ваше число меньше нуля");
                    }
                    else
                    {
                        Console.WriteLine("Ваше число равно нулю");
                    }
                }
                else if (choice == "47")
                {
                    int a = 4;
                    string b = (a % 2 == 0) ? "Положительное" : "Отрицательное";
                    // ура, первая задача с тернарным оператором, оказывается это легче чем казалось
                }
                else if (choice == "48")
                {
                    Console.WriteLine("Введите первое число");
                    int a = int.Parse(Console.ReadLine());
                    Console.WriteLine("Введите второе число");
                    int b = int.Parse(Console.ReadLine());
                    if (a < b)
                    {
                        Console.WriteLine($"{a} меньше чем {b}");
                    }
                    else if (a > b)
                    {
                        Console.WriteLine($"{a} больше чем {b}");
                    }
                    else
                    {
                        Console.WriteLine("Числа равны");
                    }
                }
                else if (choice == "49")
                {
                    Console.WriteLine("Введите логин");
                    string a = Console.ReadLine();
                    Console.WriteLine("Введите пароль");
                    string b = Console.ReadLine();
                    if (a.Contains("admin") && b.Contains("1234"))
                    {
                        Console.WriteLine("Вход выполнен");
                    }
                    else
                    {
                        Console.WriteLine("Пароль неверный");
                    }
                }
                else if (choice == "50")
                {
                    Console.WriteLine("Введите температуру, и я скажу жарко или холодно");
                    int a = int.Parse(Console.ReadLine());
                    string b = (a >= 25) ? "Жарко" : "Холодно";
                }
                else if (choice == "51")
                {

                }
            }
        }
    }
}
