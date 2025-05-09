using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
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
            //int kim = 10, lars = 5, fisk = 666;
            //Console.WriteLine(5 + kim + fisk - 400 + lars);
            //Console.ReadKey();
            #endregion

            //Boolske variable
            #region Opgave1
            //int var1 = 10, var2 = 5;
            //bool VariableTal = var1 > var2;
            //Console.WriteLine(VariableTal);
            //Console.ReadKey();
            //Console.Clear();
            //var2 = var2 + 6;
            //VariableTal = var1 > var2;
            //Console.WriteLine(VariableTal);
            //Console.ReadKey();
            #endregion

            //If-else statements
            #region Opgave1
            //int tal1 = 42, tal2 = 64, resultat = tal1 + tal2;
            //if (resultat > 100) Console.WriteLine($"Tallet {resultat} er større end 100");
            //else if (resultat < 100) Console.WriteLine($"Tallet {resultat} er mindre end 100");
            //else Console.WriteLine($"Tallet {resultat} er 100");
            //Console.ReadKey();
            #endregion

            #region Opgave2
            //Console.Write("Indtast din alder: ");
            //int alder = Convert.ToInt32(Console.ReadLine());
            //if (alder > 57) Console.WriteLine("Du er for gammel");
            //else Console.WriteLine("Du er ikke for gammel");
            //Console.ReadKey();
            #endregion

            #region Opgave3
            //Console.Write("Indtast din alder: ");
            //int alder = Convert.ToInt32(Console.ReadLine());
            //if (alder > 60) Console.WriteLine("Du er for gammel");
            //else if (alder < 61 && alder > 49) Console.WriteLine("Du er hverken for gammel eller for ung");
            //else Console.WriteLine("Du er for ung");
            //Console.ReadKey();
            #endregion

            #region Opgave4
            //String Navn = "NavnPåBrugeren", Brugernavn = "Bruger1", Password = "Passw0rd";
            //Console.Write("Indtast dit brugernavn: ");
            //String IndtastetBrugerNavn = Console.ReadLine();
            //Console.Write("Indtast dit password: ");
            //String IndtastetPassword = Console.ReadLine();
            //Console.Clear();
            //if (Brugernavn == IndtastetBrugerNavn && Password == IndtastetPassword) Console.WriteLine($"Velkommen {Navn}");
            //else Console.WriteLine("Brugernavn eller password forkert");
            //Console.ReadLine();
            #endregion

            #region Opgave5
            //String Navn = "NavnPåBrugeren", Brugernavn = "Bruger1", Password = "Passw0rd";
            //Console.Write("Indtast dit brugernavn: ");
            //String IndtastetBrugerNavn = Console.ReadLine();
            //if (Brugernavn == IndtastetBrugerNavn)
            //{
            //    Console.Write("Indtast dit password: ");
            //    String IndtastetPassword = Console.ReadLine();
            //    Console.Clear();
            //    if (Password == IndtastetPassword) Console.WriteLine($"Velkommen {Navn}");
            //    else Console.WriteLine("Password forkert");

            //}
            //else Console.WriteLine("Brugernavn forkert");
            //Console.ReadLine();
            #endregion

            #region Opgave6
            //Console.Write("Hvor mange kilometer køre du om dagen: ");
            //double Kilometer = Convert.ToDouble(Console.ReadLine());
            //if (Kilometer <= 24.0) Console.WriteLine("Du får ikke noget fradrag");
            //else if (Kilometer >= 24.1 && Kilometer <= 120.0) Console.WriteLine($"Du får 1.93 kr i fradrag pr kilometer efter de 24, du får derfor {(Kilometer - 24) * 1.93} Kr. i fradrag");
            //else if (Kilometer >= 120.1) Console.WriteLine($"Du får {(96 * 1.93) + ((Kilometer - 120) * 0.97)} kr. i fradrag");
            //else Console.WriteLine("Indput ikke forstået");
            //Console.ReadKey();
            #endregion

            #region Opgave7
            //Console.Title = "Festen";
            //string farve = "";
            //bool Program1 = true;
            //while (Program1)
            //{
            //    Console.Write("Hvilken farve ønsker du konsollen?\nDu kan vælge mellem\nRød\nGrøn\nBlå\nGul\n\nIndput: ");
            //    farve = Console.ReadLine().ToUpper(); 
            //    Console.Clear();
            //    if (farve == "RØD" || farve == "GRØN" || farve == "BLÅ" || farve == "GUL") Program1 = false;
            //    else { Console.WriteLine("Farve ikke forstået, prøv igen."); Console.ReadKey(); };
            //    Console.Clear();
            //}
            //if (farve == "RØD") Console.BackgroundColor = ConsoleColor.Red;
            //else if (farve == "GRØN") Console.BackgroundColor = ConsoleColor.Green;
            //else if (farve == "BLÅ") Console.BackgroundColor = ConsoleColor.Blue;
            //else if (farve == "GUL") Console.BackgroundColor = ConsoleColor.Yellow;
            //else Console.WriteLine("Hvordan kom du her hen?");
            //Console.Clear();

            //Console.Write("Hvad er din alder: ");
            //int alder = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //if (alder < 18) Console.WriteLine("Velkommen til sodavandsbaren.");
            //else Console.WriteLine("Velkommen til cocktailbaren");
            //Thread.Sleep(10000);
            #endregion

            //Swich Case
            #region Opgave1
            //Console.Write("Indtast en værdi mellem 1-6: ");
            //int værdi = Convert.ToInt16(Console.ReadLine());
            //switch (værdi)
            //{
            //    case 1:
            //        Console.WriteLine("Du har tastet " + værdi);
            //        Console.ReadKey();
            //        break;

            //    case 2:
            //        Console.WriteLine("Du har tastet " + værdi);
            //        break;

            //    case 3:
            //        Console.WriteLine("Du har tastet " + værdi);
            //        break;

            //    case 4:
            //        Console.Clear();
            //        Console.ForegroundColor = ConsoleColor.White;
            //        Console.SetCursorPosition(50, 15);
            //        Console.WriteLine("TILYKKE DU HAR VUNDET");
            //        Console.ReadKey();
            //        break;

            //    case 5:
            //        Console.WriteLine("Du har tastet " + værdi);
            //        Console.ReadKey();
            //        break;

            //    case 6:
            //        Console.WriteLine("Du har tastet " + værdi);
            //        Console.ReadKey();
            //        break;

            //    default:
            //        Console.WriteLine("Du har tastet forkert. Tallet skal være mellem 1 og 6");
            //        Thread.Sleep(10000);
            //        break;
            //}

            #endregion

            #region Opgave2
            //string[] drinks = {"Isbjørn", "Champagnebrus", "Tequila Sunrise", "Mojito", "Brandbil", "Filur"};
            //double[] drinksPris = { 25.95, 29.95, 34.95, 39.95, 25.95, 25.95 };
            //int indput;
            //Console.WriteLine("Vælg en drink ved at indtaste tallet udfor drinken"); 
            //for (int i = 0; i < drinks.Length; i++)
            //{
            //    Console.SetCursorPosition(0, (i + 2));
            //    Console.WriteLine($"{i+1}: {drinks[i]}");
            //    Console.SetCursorPosition(20, (i + 2));
            //    Console.WriteLine($"{drinksPris[i]} Kr.");
            //}
            //Console.Write("Indput:");
            //if (int.TryParse(Console.ReadLine(), out int virker)) indput = virker;
            //else indput = 0;
            //switch (indput)
            //{
            //    case 1:
            //        Console.WriteLine($"Du har valgt {drinks[indput-1]} til {drinksPris[indput-1]} Kr.");
            //        Console.ReadKey();
            //        break;
            //    case 2:
            //        Console.WriteLine($"Du har valgt {drinks[indput - 1]} til {drinksPris[indput - 1]} Kr.");
            //        Console.ReadKey();
            //        break;
            //    case 3:
            //        Console.WriteLine($"Du har valgt {drinks[indput - 1]} til {drinksPris[indput - 1]} Kr.");
            //        Console.ReadKey();
            //        break;
            //    case 4:
            //        Console.WriteLine($"Du har valgt {drinks[indput - 1]} til {drinksPris[indput - 1]} Kr.");
            //        Console.ReadKey();
            //        break;
            //    case 5:
            //        Console.WriteLine($"Du har valgt {drinks[indput - 1]} til {drinksPris[indput - 1]} Kr.");
            //        Console.ReadKey();
            //        break;
            //    case 6:
            //        Console.WriteLine($"Du har valgt {drinks[indput - 1]} til {drinksPris[indput - 1]} Kr.");
            //        Console.ReadKey();
            //        break;
            //    default:
            //        Console.WriteLine("Indput ikke tilkoblet noget.");
            //        Console.ReadKey();
            //        break;
            //}      

            #endregion

            //Loops
            #region Opgave1
            //int loop = 1;
            //Console.WriteLine("While løkke");
            //while (loop <= 10)
            //{ Console.WriteLine(loop);
            //    loop++;
            //}
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("For løkke");
            //for (int i = 1; i <= 10; i++) Console.WriteLine(i);
            //Console.ReadKey();
            #endregion

            #region Opgave2
            //int loop = 100;
            //Console.WriteLine("While løkke");
            //while (loop >= 1)
            //{
            //    Console.Write(loop + " ");
            //    loop--;
            //}
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("For løkke");
            //for (int i = 100; i >= 1; i--) Console.Write(i + " ");
            //Console.ReadKey();
            #endregion

            #region Opgave3
            //for (int i = 0; i <= 10; i++)
            //{ Console.WriteLine(i * 5); }
            //Console.ReadKey();

            #endregion

            #region Opgave4
            //int loop = 20;
            //Console.WriteLine("While løkke");
            //while (loop >= 0)
            //{
            //    Console.Write(loop + " ");
            //    loop--;
            //}
            //Console.ReadKey();
            //Console.Clear();
            //Console.WriteLine("For løkke");
            //for (int i = 20; i >= 0; i--) Console.Write(i + " ");
            //Console.ReadKey();
            #endregion

            #region Opgave5
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} * {7}");
            //    Console.SetCursorPosition(15, (i));
            //    Console.WriteLine($"= {i * 7}");
            //}
            //Console.ReadKey();
            #endregion

            #region Opgave6
            //Console.Write("Hvilken tabel vil du udskrive: ");
            //int tabel = Convert.ToInt32(Console.ReadLine());
            //for (int i = 0; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} * {tabel}");
            //    Console.SetCursorPosition(15, (i));
            //    Console.WriteLine($"= {i * tabel}");
            //}
            //Console.ReadKey();
            #endregion

            #region Opgave7
            //for (int h = 4; h < 9; h++)
            //{
            //    for (int b = 20; b < 31; b++)
            //    {
            //        if (b == 20 || b == 30 || h == 4 || h == 8)
            //        { Console.Write("*"); }
            //        else { Console.Write(" "); }
            //    }
            //    Console.WriteLine();
            //}
            //Console.ReadKey();
            #endregion

            #region Opgave8
            //string navn = "Matthias";
            //for (int h = 4; h < 9; h++)
            //{

            //    for (int b = 20; b < 31; b++)
            //    {
            //        Console.SetCursorPosition(b, h);
            //        if (b == 20 || b == 30 || h == 4 || h == 8)
            //        { Console.Write("*"); }
            //        else { Console.Write(" "); }
            //    }
            //    Console.WriteLine();
            //}
            //Console.SetCursorPosition(((20 + 30) / 2 - (navn.Length / 2)), (8 + 4) / 2);
            //Console.Write(navn);
            //Console.ReadKey();
            #endregion

            #region Opgave9
            //Console.Write("Indtast dit navn: ");
            //string navn = Console.ReadLine();
            //Console.Write("Hvor bred skal din kasse være: ");
            //int bredde = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Hvor høj skal din kasse være: ");
            //int højde = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //for (int h = 4; h < højde+5; h++)
            //{

            //    for (int b = 20; b < 21+bredde; b++)
            //    {
            //        Console.SetCursorPosition(b, h);
            //        if (b == 20 || b == bredde+20 || h == 4 || h == højde+4)
            //        { Console.Write("*"); }
            //        else { Console.Write(" "); }
            //    }
            //    Console.WriteLine();
            //}
            //Console.SetCursorPosition(((20 + bredde+20) / 2 - (navn.Length / 2)), (højde + 4+4) / 2);
            //Console.Write(navn);
            //Console.ReadKey();
            #endregion

            //Udvidet kontrolstrukturer
            #region Opgave1
            //for (int i = 3; i < 100; i = i + 3)
            //{
            //    Console.WriteLine(i);
            //    if (i == 21)
            //    {
            //        Console.WriteLine("loopen er nu stoppet");
            //        break;
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region Opgave2
            //for (int i = 4; i < 100; i = i + 4)
            //{
            //    Console.WriteLine(i);
            //    if (i == 16)
            //    {
            //        Console.WriteLine("loopen er nu stoppet");
            //        break;
            //    }
            //}
            //Console.ReadKey();
            #endregion

            #region Opgave3
            //Console.Write("Dette program kan udregne dit befordringsfradrag\nReglner er:\n  * Første 23 km ingen fradrag\n  * 25-100 km får man 1 kr 54 øre pr km\n  * over 100 km får man 77 øre pr km\nHvor mange KM kørte du sidste måned: ");
            //int KM = Convert.ToInt32(Console.ReadLine());
            //Console.Clear();
            //if (KM <= 24) Console.WriteLine("Du er ikke berettigedet til noget kørselsfradrag");
            //else if (KM >= 25 && KM <= 100) Console.WriteLine($"Du har kørt mellem 24 og 100 km. Du er berittiget til {(KM - 24) * 1.54} kr i fradrag");
            //else if (KM >= 101) Console.WriteLine($"Du har kørt over 100 km. Du er berittiget til {(76 * 1.54) + ((KM - 100) * 0.77)} kr i fradrag");
            //else Console.WriteLine("How did we get here?");
            //Console.ReadKey();
            #endregion

            #region Opgave4
            //Console.WriteLine("Dette program kan fortælle dig hvilken slag skat du skal betale og hvor meget du skal betale i skat");
            //Console.Write("Hvor meget tjente du sidste år: ");
            //double indkomst = Convert.ToDouble(Console.ReadLine()), ASkat = 0.00, BSkat = 0.00, CSkat = 0.00;
            //Console.Clear();
            //if (indkomst <= 42000.00) Console.WriteLine($"Du skal ikke betale noget i skat.");
            //else if (indkomst > 42000.00 && indkomst < 280000.00) Console.WriteLine($"Du skal betale 30% bundkast på alt over dine 42000 kr i fradrag");
            //else if (indkomst >= 280000.00 && indkomst < 390000.00) Console.WriteLine($"Du skal betale 30% bundkast på alt over dine 42000 kr i fradrag, derudover skal du betale mellemskat på 36% på alt tjenkt over 280000 Kr");
            //else if (indkomst >= 390000.00) Console.WriteLine("Du skal betale 30% bundkast på alt over dine 42000 kr i fradrag, derudover skal du betale mellemskat på 36% på alt tjenkt over 280000 Kr og så betale topskat på alt tjent over 390000 kr.");
            //else Console.WriteLine("Igen, hvordan kom du her hen");
            //Console.ReadKey();
            //Console.Clear();

            //if (indkomst > 42000.00 && indkomst < 280000.00)  Console.WriteLine($"Du har betalt {ASkat = (indkomst - 42000.00)*0.70} kr. i bundskat");
            //else Console.WriteLine($"Du har betalt {ASkat = (280000.00 - 42000.00) * 0.70} kr. i bundskat");
            //if (indkomst >= 280000.00 && indkomst < 390000.00)  Console.WriteLine($"Du har betalt {BSkat = (indkomst - 280000.00)* 0.64} kr. i mellemskat");
            //else if (indkomst >= 390000.00) Console.WriteLine($"Du har betalt { BSkat = (390000.00 - 280000.00) * 0.64} kr. i mellemskat");
            //if (indkomst >= 390000.00)  Console.WriteLine($"Du har betalt {CSkat = (indkomst - 390000.00)*0.49} kr. i topskat"); 
            //Console.WriteLine($"Efter skat har du {(((indkomst - ASkat) - BSkat) -CSkat)} Kr. tilbage");
            //Console.ReadKey();

            #endregion

            #region Opgave5
            //Console.Write("Hvor meget står der på din konto: ");
            //double IndståendeBeløb = Convert.ToDouble(Console.ReadLine());
            //if (IndståendeBeløb < 25000.00) Console.WriteLine($"Du får {Math.Round(IndståendeBeløb * 0.25 / 100,2)} kr i rente");
            //else if (IndståendeBeløb >= 25000.00 && IndståendeBeløb < 150000.00) Console.WriteLine($"Du får {Math.Round(IndståendeBeløb * 1.25 / 100.00, 2)} kr i rente");
            //else Console.WriteLine($"du får {Math.Round((150000.00 * 1.25 / 100.00) + (IndståendeBeløb - 150000.00) * 0.5 / 100,2)} kr i rente");
            //Console.ReadKey();
            #endregion
        }
    }
}
