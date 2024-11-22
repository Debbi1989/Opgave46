using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Opgave46
{
    internal class Opgave46
    {
        static void Main(string[] args)
        {

            //Opgave 46 Ballerup svømmehal - Priser


            //Enkeltbilletter

            //Voksne 42 kr

            //Pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse, dagpengemodtagere og studerende(dokumentation påkrævet) 23 kr

            //Børn(under 7 år i følgeskab med en voksen) Gratis

            //Børn(7 - 15 år) 15 kr

            //Skoleferiebillet Børn(7 - 15 år) sommer / efterår / vinter 10 kr

            //10 - turskort

            //Voksne 330 kr

            //Pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse, dagpengemodtagere og studerende(dokumentation påkrævet) 175 kr

            //Børn(7 - 15 år) 135 kr

            //Forslag: Brug switch-case - do -while løkke – for løkke - arrays.Brug og vis alt hvad du har lært.

            //Koden skal indeholde kommentarer.


            // øverst defineres variablerne der skal bruges. Jeg har lavet enkelte arrays som kun bruges få gange.

            string billettype = "billettype";
            string tur = "10-turskort";

            int voksenbillet = 42;
            int Voksentitur = 330;
            double voksenpris = 0;
            int antalvoksen = 0;
            int voksenantaltur = 0;
            double voksenturpris = 0;


            int børnebillet = 15;
            int skoleferiebillet = 10;
            string[] skoleferie = { "sommer / efterår / vinter" }; // Array samling af variabelindhold
            //string[] skoleferie = { "sommer", "efterår", "vinter" }; // Array samling af variabelindhold
            int TiturBørn = 135;
            int antalbørn = 0;
            double børnepris = 0;
            int skoleferieantal = 0;
            double skoleferiepris = 0;
            int børntiturantal = 0;
            double børntitur = 0;



            int Øvrigbillet = 23;
            int ØvrigeTiTur = 175;
            int antaløvrige = 0;
            double øvrigpris = 0;
            int antaløvrigetitur = 0;
            double øvrigtibilletter = 0;

            string enkeltbilletter = "enkeltbilletter";

         
            string[] ØvrigeTyper = { "Pensionister, efterlønsmodtagere, arbejdsledige, \n borgere på ledighedsydelse, dagpengemodtagere og studerende" }; // Array også her

            bool isRunning = true;
            double samletpris = 0;

            do // jeg har valgt at lave den som do while. do kører her loopet.
            {
                //Console.Clear(); 
                // jeg har valgt at udkommentere //Console.Clear(); da jeg skal kunne følge med i hvad der sker når programmet køres
                Console.WriteLine(" Velkommen til Ballerup Svømmehal der er to typer billetter - enkeltbillet og 10turskort");
                Console.WriteLine(" Vælg hvilken type billet du vil have til svømmehallen. Børn under 7år er gratis");
                Console.WriteLine("tast (1) for enkeltbilletter");
                Console.WriteLine($"tast (2) 10-tursbillet");
                Console.WriteLine("tast (3) for at gå ud af programmet");
                billettype = Console.ReadLine();
                // ovenfor er til brug af brugerinput, hvor indlæser den til brug til den første switch case

                // opgaven er en sammensætning af switch cases

                switch (billettype) // billettype bruges her. 
                    // switch fungere lidt ligesom if, else if og else hvor det i stedet for er sat op i cases og en default, som fungere som else
                    // break fungere som en stopklods der afslutter så næste case kan bruges.
                    // den tager udgangspunkt i tastevalg 1 enkeltbilletter
                {
                    case "1": 
                        Console.WriteLine(" Du har valgt enkeltbilletter vælg type");
                        Console.WriteLine(" (1) tast et for voksenbilletter - pris 42kr");
                        Console.WriteLine("tast (2) for børn over 7år med følge af voksen - pris 15kr");
                        Console.WriteLine($"tast (3) for {ØvrigeTyper[0]}"); 
                        // Array string[] ØvrigeTyper bruges kun her. Starter fra index 0. dvs. det første der står i samlingen
                        Console.WriteLine(" tast (4) for skoleferiebillet");
                        enkeltbilletter = Console.ReadLine();
                        // case 1 her giver udgangspunkt for valg af type ekneltbilletter, som fortsætter i en switch case nedenfor.
                        // Det kan bemærkes at der her endnu ikke er en break og casen fortsætter til dens break indrammer det hele længere nede

                        switch (enkeltbilletter) // enkeltbilletter der fra ovenstående bliver brugt til at videreføre casen
                        {
                            case "1": 
                                Console.WriteLine(" Prisen for voksenbillet er 42kr. indtast antal:"); // udregner voksen enkeltbillet
                                antalvoksen = Convert.ToInt32(Console.ReadLine());
                                voksenpris = antalvoksen * voksenbillet; 
                                // variablerne der her udregner prisen for antallet af pågældende billetter * deres pris.
                                break;
                                // De har hver især en break her fordi det er en swich case inde i en swich case.
                                // men den ønskes her at videreføre det enkeltvis og afslutte hver case så den kan gå til næste.
                                // casene her udregner de forskellige typer enkeltbilletter.


                            case "2":
                                Console.WriteLine(" Prisen for børnebillet er 15kr. vælg antal:"); 
                                antalbørn = Convert.ToInt32(Console.ReadLine());
                                børnepris = antalbørn * børnebillet;
                                break;
                            // Prisen for børne enkeltbillet - samme proces som case 1.


                            case "3":
                                Console.WriteLine(" prsien for Pensionister / studerende og øvrige er 23kr vælg antal:");
                                
                                antaløvrige = Convert.ToInt32(Console.ReadLine());
                                øvrigpris = antaløvrige * Øvrigbillet;
                                break;
                                // Prisen for øvrige pensionister, mv. enkeltbillet - samme proces som case 1.

                            case "4":
                                Console.WriteLine($"pris for skoleferie {skoleferie[0]}. Børn 7-15. vælg antal:"); // bruges array i skoleferie
                                skoleferieantal = Convert.ToInt32(Console.ReadLine());
                                skoleferiepris = skoleferieantal * skoleferiebillet;
                                break;
                            // Prisen for skoleferie enkeltbillet - samme proces som case 1.

                            default:
                                Console.WriteLine(" ugyldigt valg prøv igen");
                                break;
                                // default fungere som else og giver ugyldigt valg

                        }
                        break; // først her kommer breaket fra den første switch
                               // case som fortsatte med en switch case indeni med de forskellige enkelbillettyper 


                    case "2": // samme som den første switch case forstætter tastevalg 2 10-tursbilletter i en case 2
                        Console.WriteLine("vælg din type tourbilletter:");
                        Console.WriteLine("Tast (a) for Voksen 10-turskort pris 330kr:");
                        Console.WriteLine("tast (b) for børne 10 - turskort pris 135kr:");
                        Console.WriteLine("tast (c) for øvrige - pensionister og studerende pris:");
                        tur = Console.ReadLine(); 
                        // tur bliver udgangspunktet for at fortsætte case 2 nedenfor. tastevalgene her bliver a, b, c
                        // der er heller ikke brak endnu her

                        switch (tur) // fortsætter ovenstående i case 2 med billettyper af kategorien 10 - tur
                        {

                            case "a":
                                Console.WriteLine(" indtast antal voksen 10 - turskort:");
                                voksenantaltur = Convert.ToInt32(Console.ReadLine());
                                voksenturpris = voksenantaltur * Voksentitur;
                                break; // 10-turs billetter for voksne
                                // ligesom med enketltbilletter er samme udregning og definition af antal * billetpris = samlet pris for billettypen

                            case "b":
                                Console.WriteLine("indtast antal børn 10 - turskort:");
                                børntiturantal = Convert.ToInt32(Console.ReadLine());
                                børntitur = børntiturantal * TiturBørn;
                                break; // 10turs for børn


                            case "c":
                                Console.WriteLine(" indtast antal 10-turskort for øvrige - pensionister og studerende");
                                antaløvrigetitur = Convert.ToInt32(Console.ReadLine());
                                øvrigtibilletter = ØvrigeTiTur * antaløvrigetitur;
                                break; // billetudregning fo 10 tur pensionister, studerende, mm.


                            default:
                                Console.WriteLine("ugyldigt valg");
                                break; // ligesom i første del

                        }
                        break; // først her kommer breaket som indrammer case 2 som giver udgangspunkt for valget af 10-tursbilletter

                    case "3":
                        Console.WriteLine("afslut programmet");
                        isRunning = false; // isRunning er i defineret som bool true og her bruges den til at afslutte programmet som false.
                        break; 
                        // tastevalg 3 afslutter programmet har sin egen break og kræver ikke så meget, da der ikke er flere valgmuligheder.

                    default:
                        Console.WriteLine("ugyldigt valg");
                        break; // default i case 3 fungere ligesom i de andre
                }
                

            } while (isRunning); // udfører så længe betingelsen er sand

          samletpris = voksenpris + børnepris + øvrigpris + skoleferiepris + voksenturpris + børntitur + øvrigtibilletter;
            // samletpris sammenlægger de samlede billetpriser for hver af de forskellige billettyper både enkelt og 10-turs

            // nedenfor bruges if til at udskrive en oversigt/kvitering.
            // if bruges som betingelse hvor billetantallet skal være > 0 for at blive udskrevet af programmet.
            if (antalvoksen > 0)
                Console.WriteLine($" du har købt {antalvoksen} voksen enkeltturs billetter til en samlet pris {voksenpris}kr stk. pris {voksenbillet} kr");
            if (antalbørn > 0)
                Console.WriteLine($" du har købt {antalbørn} børne enkeltturs billetter til en samlet pris {børnepris}kr stk. pris {børnebillet} kr ");
            if (antaløvrige > 0)
                Console.WriteLine($" du har købt {antaløvrige} pensionist/studerende/medmere enkeltturs billetter til en samlet pris {øvrigpris}kr stk. pris {Øvrigbillet}kr");
            if (antaløvrige > 0)
                Console.WriteLine($" du har købt {skoleferieantal} skoleferie enkeltturs billetter til en samlet pris {skoleferiepris}kr stk. pris {skoleferiebillet}kr");

            if (voksenantaltur > 0)
                Console.WriteLine($" du har købt {voksenantaltur} voksen 10-turs billetter til en samlet pris {voksenturpris}kr stk. pris {Voksentitur}kr");

            if (børntiturantal > 0)
                Console.WriteLine($" du har købt {børntiturantal} børne 10-turs billetter til en samlet pris {børntitur}kr stk. pris {TiturBørn}kr");

            if (antaløvrigetitur > 0)
                Console.WriteLine($" du har købt {antaløvrigetitur} pensionist/studerende/med mere 10-turs billetter til en samlet pris {voksenturpris}kr stk. pris {Voksentitur}kr");

            Console.WriteLine($" Din samlede pris i alt er {samletpris}"); // udskriver den samlede pris for billetterne 


            Console.ReadKey();

        }
    }
}
