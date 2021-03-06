using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alessia.Lionetto.Tombola
{
    internal class Manager
    {
        internal static int[] sceltaNumeri()
        {
            Console.WriteLine("inserisci 5 numeri compresi tra 1 e 90");
            int[] numeriScelti = new int[5];

            for (int i = 0; i < numeriScelti.Length; i++)
            {
                int num;


                while (!(int.TryParse(Console.ReadLine(), out num) && num >= 1 && num <= 90))
                {
                    Console.WriteLine("Devi inserire un numero intero tra 1 e 90!!!");
                }

                int found = Array.IndexOf(numeriScelti, num);
                if (found == -1)
                {
                    numeriScelti[i] = num;
                }
                else
                {
                    Console.WriteLine("questo numero è già presente");
                    i--;
                }

                

            }


            return numeriScelti;

        }
        internal static void Print(string message, int[] array)
        {
            Console.WriteLine(message);
            foreach (int item in array)
                Console.WriteLine(item);
        }
        internal static string sceltaDifficoltà()
        {
            string scelta;
            Console.WriteLine("scegli la difficoltà: " +
                "\n facile" +
                "\n medio" +
                "\n difficile");
            scelta = Console.ReadLine();
            return scelta;
        }

        internal static int[] estrazioneNumeri()
        {
            int[] estrazioneNumeri = new int[70];
            Random r = new Random();
            for (int i = 0; i < estrazioneNumeri.Length; i++)
            {
                int num = r.Next(1, 91);
                int found = Array.IndexOf(estrazioneNumeri, num);
                if (found == -1)
                {
                    estrazioneNumeri[i] = num;
                }
                else
                {
                    i--;
                }
            }
            return estrazioneNumeri;
            //    if (scelta == "facile")
            //    {
            //        int[] facile = new int[70];
            //        for (int i = 0; i < facile.Length; i++)
            //        {

            //            int numEstratto = r.Next(1, 91);
            //            int found = Array.IndexOf(facile, numEstratto);
            //            if (found ==-1)
            //            {
            //                facile[i] = numEstratto;
            //            }
            //        }

            //    }else if(scelta == "medio")
            //    {
            //        int[] medio = new int[40];
            //        for (int i = 0; i < medio.Length; i++)
            //        {

            //            int numEstratto = r.Next(1, 91);
            //            int found = Array.IndexOf(medio, numEstratto);
            //            if (found == -1)
            //            {
            //                medio[i] = numEstratto;
            //            }
            //        }
            //    }else if (scelta == "difficile")
            //    {
            //        int[] difficile = new int[20];
            //        for (int i = 0; i < difficile.Length; i++)
            //        {

            //            int numEstratto = r.Next(1, 91);
            //            int found = Array.IndexOf(difficile, numEstratto);
            //            if (found == -1)
            //            {
            //                difficile[i] = numEstratto;

            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine("la scelta non è corretta");
            //    }


        }

        internal static void CheckWin(int[] sceltaNumeri, int[] numeriEstratti)
        {
            int[] numeriVincenti = new int[5];
            int count = 0;
            Console.WriteLine("i numeri vincenti sono:");
            for (int i = 0;i<numeriEstratti.Length;i++)
            {

                int found = Array.IndexOf(sceltaNumeri, numeriEstratti[i]);
               
                if (found != -1)
                {
                    numeriVincenti[count] = numeriEstratti[i];
                    Console.WriteLine(numeriVincenti[count]);
                    count++;


                }
                
                
            }
            
            
            if (count==2)
            {
                Console.WriteLine("AMBO");

            }
            else if (count== 3)
            {
                Console.WriteLine("terna");
            }
            else if (count == 4)
            {
                Console.WriteLine("quaterna");
            }
            else if (count == 5)
            {
                Console.WriteLine("cinquina");
            }
            else
            {
                Console.WriteLine("hai perso");
            }
        }



    }
    
}