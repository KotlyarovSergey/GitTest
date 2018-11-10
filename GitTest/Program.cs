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
            goto M3;
            // ------------ Таблица -----------------
            table();
            WriteLine();

        // ----------- Константы ----------------
        M1:
            constType();
            WriteLine();

        // ------------ Строки форматы -----------
        M2:
            stringFormats();
            WriteLine();

            Console.Beep();

        M3:
            cursorMethods();
        }

        private static void wrLine()
        {
            for (int i = 0; i < Console.WindowWidth - 1; i++)
            {
                Write("-");
            }
            Write("\n");
        }

        private static void table()
        {
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
        }

        private static void constType()
        {
            int a = someConst * otherConst;
            WriteLine(a.ToString());

            val1 = someConst + 3;
            val2 = val1 * otherConst;
            val3 = val1 + val2;
            WriteLine($"val1 = {val1}  val2 = {val2}  val3 = {val3}");

            int @int = 10;
            val3 = @int * 10;
            WriteLine($"@int = {@int}     val3 = {val3}");
        }

        private static void stringFormats()
        {
            // Get user input.
            System.Console.WriteLine("Enter a number");
            string input = System.Console.ReadLine();

            // Convert the input string to an int.
            int j;
            System.Int32.TryParse(input, out j);

            // Write a different string each iteration.
            string s;
            for (int i = 0; i < 10; i++)
            {
                // A simple format string with no alignment formatting.
                s = System.String.Format("{0} times {1} = {2}", i, j, (i * j));
                System.Console.WriteLine(s);
            }

            //Keep the console window open in debug mode.
            System.Console.ReadKey();

            string s2 = String.Format("{0} блабла  {1} - {2}. Конец", 12, true, 12.34);
            WriteLine(s2);

            string s3 = "1234567890";
            // так нельзя:
            //s3[1] = s3[1];
            //s3[2] = '3';

            char[] s3_arr = { '1', '2', '3', '4', '5' };
            s3 = new string(s3_arr);
            WriteLine(s3);

            s3_arr[1] = '7';
            s3 = new string(s3_arr);
            WriteLine(s3);

        }

        private static void cursorMethods()
        {
            int csz;
            bool exit = false;
            String input = string.Empty;
            do
            {
                Clear();
                csz = CursorSize;
                WriteLine($"Cursor size: {csz}");
                Write("Input new size of cursor (to exit input 0): ");
                input = ReadLine();
                if (System.Int32.TryParse(input, out csz))
                {
                    if (csz == 0)
                        exit = true;
                    else
                    {
                        if (csz > 100)
                            csz = 100;
                        CursorSize = csz;
                    }
                }
            }
            while (!exit);

            WriteLine($"Cursor.Left: {CursorLeft}");
            CursorLeft = 10;
            Write("10");
            CursorLeft = 5;
            Write("05");
            CursorLeft = 10;
            Write("xx");
            CursorTop = 5;
            Write("Row 5");
            Clear();
            for (int i = 1; i < 11; i++)
            {
                Write("*");
                ++CursorTop;
            }

            WriteLine();
        }
    }
}
