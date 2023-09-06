using System;

namespace lab1ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Scrieti un program care interschimba valoarea a doua variabile intregi.*/
            int numar1 = 12;
            int numar2 = 15;
            int placeholder = 0;

            placeholder = numar1;
            numar1 = numar2;
            numar2 = placeholder;
            Console.WriteLine("primul numar: " + numar1 + "\n" + "al doilea numar:" + numar2);
       






        }
    }
}
