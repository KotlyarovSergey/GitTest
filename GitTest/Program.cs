using System;
using static System.Console;


namespace GitTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // ------------ Таблица -----------------
            wrLine();
            // шапка
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "column 1", "column 2", "column 3", "column 4");
            wrLine();

            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "byte", sizeof(byte), byte.MinValue.ToString(), byte.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "sbyte", sizeof(sbyte), sbyte.MinValue.ToString(), sbyte.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "short", sizeof(short), short.MinValue.ToString(), short.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "ushort", sizeof(ushort), ushort.MinValue.ToString(), ushort.MaxValue.ToString());

            WriteLine();
        }

        private static void wrLine()
        {
            for (int i = 0; i < Console.WindowWidth-1; i++)
            {
                Write("-");
            }
            Write("\n");
        }
    }
}
