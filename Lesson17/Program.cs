using System;

namespace Lesson17
{
    class Program
    {
        public delegate void Print(string text);
        public delegate void PrintAny();
        static void Main(string[] args)
        {
            //PrintMessage("Hello from PrintMessage");

            //Print print = PrintMessage;  //or var print = new Print(PrintMessage);

            //print.Invoke("Hello from print delegate"); // or print("Hello from print delegate");

            //PrintAny printAny = PrintMoney;
            //printAny();

            //PrintAny print = PrintMessage1;
            //print += PrintMessage2;
            //print += PrintMessage3;
            //print.Invoke();

            //print -= PrintMessage2;
            //print.Invoke();

            PrintGiventTextToUpper("hello", PrintMessage);
        }

        static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        static void PrintMessage1()
        {
            Console.WriteLine("Print message 1");
        }

        static void PrintMessage2()
        {
            Console.WriteLine("Print message 2");
        }

        static void PrintMessage3()
        {
            Console.WriteLine("Print message 3");
        }

        static void PrintMoney()
        {
            Console.WriteLine($"{120:C}");
        }

        static void PrintGiventTextToUpper(string text, Print print)
        {
            print.Invoke(text.ToUpper());
        }
    }
}
