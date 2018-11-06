
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarWithKnife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ключевое слово: ");
            string keyWord = Console.ReadLine().ToLower();
            Console.Write("Ключ: ");
            int key = Convert.ToInt32(Console.ReadLine());

            Caesar.createNewAlpha(keyWord, key);
            Console.WriteLine();
            Console.WriteLine("Шифрованный алфавит: " + Caesar.getNewAlpha());
            Console.WriteLine();

            string open = "", close = "";
            Console.Write("Открытое сообщение: ");
            open = Console.ReadLine().ToLower();
            close = Caesar.encrypt(open);
            Console.WriteLine();
            Console.WriteLine("Шифрованное сообщение: " + close);
            open = Caesar.decrypt(close);
            Console.WriteLine();
            Console.WriteLine("Расшифрованное сообщение: " + open);

            Console.ReadKey();
        }
    }
}