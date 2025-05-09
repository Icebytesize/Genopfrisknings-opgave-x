using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genopfrisknings_opgave_x
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable
            #region Opgave1
            //    //Opgave 1
            //    int tal1 = 5, tal2 = 3;
            //    Console.WriteLine(tal1 + "\n" + tal2);
            //    Console.ReadKey();
            #endregion

            #region Opgave2
            //int tal1 = 5, tal2 = 3;
            //Console.WriteLine($"tal1 er {tal1} \ntal2 er {tal2}");
            //Console.ReadKey();
            #endregion

            #region Opgave3
            //string navn = "Søren";
            //int alder = 16;
            //double penge = 1234.34;

            //Console.WriteLine($"Jeg hedder {navn}, er {alder} år gammel og tjente {penge} kr. på at lappe cykler");
            //Console.ReadKey();
            #endregion

            #region Opgave4
            //double kage = 23.56, øl = 34.67, pølse = 65.34;
            //Console.WriteLine($"Kage {kage}\nØl {øl}\nPølse {pølse}\n\nI alt {kage + øl + pølse}");
            //Console.ReadKey();
            #endregion

            #region Opgave5
            //Console.Write("Indtast dig navn: ");
            //string navn = Console.ReadLine();
            //Console.Clear();
            //Console.Write("indtast din alder: ");
            //int alder = Convert.ToInt16(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"Jeg hedder {navn} og er {alder} år gammel");
            //Console.ReadKey();

            #endregion

            #region opgave6
            //Console.Write("Indtast radius af din cirkel: ");
            //double r = Convert.ToDouble(Console.ReadLine());
            //Console.Clear();
            //Console.WriteLine($"Arealet af cirklen er {Math.PI * Math.Pow(r,2)}");
            //Console.ReadKey();
            #endregion

            //Strings
            #region Opgave1
            //int tal = 1;
            //string ord = "ord";
            //double decimaltal = 1.23;
            //Console.Write($"{tal}\n{ord}\n{decimaltal}");
            //Console.ReadKey();
            #endregion

            #region Opgave2
            //int tal = 1;
            //string ord = "ord";
            //double decimaltal = 1.23;
            //Console.Write($"{tal}\n{ord}\n{decimaltal}");
            //Console.ReadLine();
            //Console.Write($"ændre {ord} til noget andet: ");
            //ord = Console.ReadLine();
            //Console.Clear();
            //Console.Write($"{tal}\n{ord}\n{decimaltal}");
            //Console.ReadKey();
            #endregion

            #region opgave3
            //string datotest = "I dag har vi den 24. December.";
            //Console.WriteLine(datotest);
            //Console.ReadKey();
            #endregion

            #region Opgave4
            //double penge = 200.50;
            //string hvem = "Jeg har", hvor = "kr. i banken";
            //Console.WriteLine($"{hvem} {penge} {hvor}");
            //Console.ReadKey();
            #endregion

            //Aritmetiske udtryk
            #region Opgave1
            //double tal1 = 2+1*2, tal2 = (2+1)*2, tal3 = 5.0/2, tal4=8%3, tal5=1-5;
            //Console.WriteLine($"{tal1}\n{tal2}\n{tal3}\n{tal4}\n{tal5}");
            //Console.ReadKey();
            #endregion

            //Variable i udtryk
            #region Opgave1
            //int tal1 = 10, tal2 = 25, tal3 = 40;
            //int resultat = tal1 + tal2 * tal3;
            //Console.WriteLine(resultat);
            //Console.ReadKey();
            #endregion

            #region Opgave2
            int kim = 10, lars = 5, fisk = 666;
            Console.WriteLine(5 + kim + fisk - 400 + lars);
            Console.ReadKey();
            #endregion
        }
    }
}
