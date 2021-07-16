using System;

namespace Task_Three
{
    class Program
    {
        static void Main(string[] args)
        {
            //Перший варіант.
            string Stroka_One = null;
            int i = Stroka_One.Length;

            //Другий варіант
            string Stroka_Two = null;
            Stroka_Two = Stroka_Two.ToUpper();

            //Помилка NullReferenceException іиникає в результаті того що ми намагались отримати доступ до члену, який нічого не має
            //Тобто змінна була не неініціалізована, або була неініціалізована , а зараз не неініціалізована.
        }
    }
}
