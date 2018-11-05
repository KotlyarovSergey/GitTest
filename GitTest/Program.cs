using System;
using static System.Console;


namespace GitTest
{
    class Program
    {
        private const int someConst = 12, otherConst = 25;
        private static int val1, val2, val3;

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // ------------ Таблица -----------------
            wrLine();
            // шапка
            WriteLine("{0,-10} {1,-3} {2,25} {3,28}", "column 1", "column 2", "column 3", "column 4");
            wrLine();

            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "byte", sizeof(byte), byte.MinValue.ToString(), byte.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "sbyte", sizeof(sbyte), sbyte.MinValue.ToString(), sbyte.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "short", sizeof(short), short.MinValue.ToString(), short.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "ushort", sizeof(ushort), ushort.MinValue.ToString(), ushort.MaxValue.ToString());

            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "int", sizeof(int), int.MinValue.ToString(), int.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "uint", sizeof(uint), uint.MinValue.ToString(), uint.MaxValue.ToString());

            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "long", sizeof(long), long.MinValue.ToString(), long.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "ulong", sizeof(ulong), ulong.MinValue.ToString(), ulong.MaxValue.ToString());

            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "double", sizeof(double), double.MinValue.ToString(), double.MaxValue.ToString());
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "decimal", sizeof(decimal), decimal.MinValue.ToString(), decimal.MaxValue.ToString());
            
            WriteLine("{0,-10} {1,-3} {2,28} {3,28}", "float", sizeof(decimal), float.MinValue.ToString(), float.MaxValue.ToString());
            WriteLine();

            int a = someConst * otherConst;
            WriteLine(a.ToString());

            val1 = someConst + 3;
            val2 = val1 * otherConst;
            val3 = val1 + val2;
            WriteLine("val1 = {val1:C}  val2 = {val2}  val3 = {val3}");
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
