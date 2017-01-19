using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;

namespace ThrowException
{
    class Program
    {

        static int[] mojiBrojevi = { 1, 2, 3, 4, 5 };

        static void Main(string[] args)
        {

            foreach(int broj in mojiBrojevi)
            {
                try
                {
                    Console.WriteLine("Main() try block dosegnut");
                    Console.WriteLine($"Pozvaana funkcija ThrowException(\"{broj}\")");
                    ThrowException(broj);
                    Console.WriteLine($"Main() try block se nastavlja");
                }
                catch (IndexOutOfRangeException e) when(broj == 5)
                {
                    BackgroundColor = ConsoleColor.Red;
                    WriteLine($"Main() FILTRIRANI System.IndexOutOfRangeException catch block dosegnut. Poruka:\n\"{e.Message}\"");
                    ResetColor();
                }
                catch (IndexOutOfRangeException e)
                {
                    BackgroundColor = ConsoleColor.Magenta;
                    WriteLine($"Main() System.IndexOutOfRangeException catch block dosegnut. Poruka:\n\"{e.Message}\"");
                    ResetColor();
                }
                catch
                {
                    BackgroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Main() opci catch block deosegnut");
                    ResetColor();
                }
                finally
                {
                    Console.WriteLine("Main() finnaly block dosegnut");
                }
                Console.WriteLine();
            }
        }

        static void ThrowException(int broj)
        {
            Console.WriteLine($"ThrowExceptin(\"{broj}\") dosegnut");

            switch (broj)
            {
                case 1:
                    Console.WriteLine("Bez Exception-a");
                    break;
                case 2:
                    Console.WriteLine("Throwing System.Exception");
                    throw new System.Exception();
                case 3:
                    Console.WriteLine("Throwing System.IndexOutOfRangeException.");
                    mojiBrojevi[44] = 43;
                    break;
                case 4:
                    try
                    {
                        Console.WriteLine("ThrowException(\"4\") try block dosegnut");
                        Console.WriteLine("ThrowException(\"3\" pozvan");
                        ThrowException(3);
                    }
                    catch
                    {
                        Console.WriteLine("ThrowException(\"4\") opci catch block dosegnut");
                        throw;
                    }
                    finally
                    {
                        Console.WriteLine("ThrowException(\"4\") finally block dosegnut");
                    }
                    break;
                case 5:
                    try
                    {
                        Console.WriteLine("ThrowException(\"5\") try block dosegnut");
                        Console.WriteLine("ThrowException(\"3\" pozvan");
                        ThrowException(3);
                    }
                    catch
                    {
                        Console.WriteLine("ThrowException(\"5\") finally block dosegnut");
                        throw;
                    }
                    break;

            }
        }
    }
}
