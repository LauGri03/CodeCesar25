using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecodeTable
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ListElement> liste = new List<ListElement>();

            liste.Add(new ListElement(0, 'a'));
            liste.Add(new ListElement(1, 'b'));
            liste.Add(new ListElement(2, 'c'));
            liste.Add(new ListElement(3, 'd'));
            liste.Add(new ListElement(4, 'e'));
            liste.Add(new ListElement(5, 'f'));
            liste.Add(new ListElement(6, 'g'));
            liste.Add(new ListElement(7, 'h'));
            liste.Add(new ListElement(8, 'i'));
            liste.Add(new ListElement(9, 'j'));
            liste.Add(new ListElement(10, 'k'));
            liste.Add(new ListElement(11, 'l'));
            liste.Add(new ListElement(12, 'm'));
            liste.Add(new ListElement(13, 'n'));
            liste.Add(new ListElement(14, 'o'));
            liste.Add(new ListElement(15, 'p'));
            liste.Add(new ListElement(16, 'q'));
            liste.Add(new ListElement(17, 'r'));
            liste.Add(new ListElement(18, 's'));
            liste.Add(new ListElement(19, 't'));
            liste.Add(new ListElement(20, 'u'));
            liste.Add(new ListElement(21, 'v'));
            liste.Add(new ListElement(22, 'w'));
            liste.Add(new ListElement(23, 'x'));
            liste.Add(new ListElement(24, 'y'));
            liste.Add(new ListElement(25, 'z'));

            Functions func = new Functions();
            string enter = Console.ReadLine();
            string[] screen = func.Calculate(liste, enter.ToCharArray());

            for(int i = 0; i <= 24; i++)
            {
                Console.WriteLine("Decallage de " + (i + 1) + ":");
                Console.WriteLine(screen[i].ToUpper());
                Console.WriteLine();
            }

            Console.ReadLine();
            
        }

        

    }
}
