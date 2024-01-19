using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaschine
{
    internal class KaffeMaschine
    {
        private int wasserStand;
        private int bohnenMenge;
        private int milchStand;

        static int maxWasserStand =1500;
        static int maxBohnenMenge =500 ;
        static int maxMilschStand = 1500;

        public int WasserStand { get => wasserStand; }
        public int BohnenMenge { get => bohnenMenge; }
        public int MilcStand { get => milchStand; }

        public KaffeMaschine() { }
        
        public void makeKaffe()
        {
            //für eine Tasse Koffein werden durchschnittlich 8 Gramm Kaffee und 200 ml Wasser verbraucht
            if (wasserStand==0&&bohnenMenge==0)
            {
                Console.Clear();
                ConsoleWriteColor("\nZuerst sollen Sie Wasser und Bohnen geben\n\n\n", "rot");
                
            }
            else if (wasserStand > 200 )
            {
                if (bohnenMenge > 8)
                {
                    wasserStand -= 200;
                    bohnenMenge -= 8;
                    Console.Clear();
                    makePunkt("KAFFE");
                    Console.Clear();
                    ConsoleWriteColor("\n :) Ihr KAFFE ist fertig. Guten Appetit...\n\n\n", "");
                }
                else
                {
                    Console.Clear();
                    ConsoleWriteColor("\nZu wenig Kaffeemenge\n\n\n", "rot");
                    
                }                

            }
            else
            {
                Console.Clear();
                ConsoleWriteColor("\nZu wenig Wasser\n\n\n", "rot");
                
            }
        }
        public void makeCappucino()
        {
            if (milchStand == 0 && bohnenMenge == 0)
            {
                Console.Clear();
                ConsoleWriteColor("\nZuerst sollen Sie Milc und Bohnen geben\n\n\n", "rot");

            }
            else if (milchStand > 180)
            {
                if (bohnenMenge > 25)
                {
                    milchStand -= 180;
                    bohnenMenge -= 25;
                    Console.Clear();
                    makePunkt("CAPPUCCINO"); 
                    Console.Clear();
                    ConsoleWriteColor("\n :) Ihr CAPPUCCINO ist fertig. Guten Appetit...\n\n\n", "");
                }
                else
                {
                    Console.Clear();
                    ConsoleWriteColor("\nZu wenig Kaffeemenge\n\n\n", "rot");
               
                }

            }
            else
            {
                Console.Clear();
                ConsoleWriteColor("\nZu wenig Milc\n\n\n", "rot");
             
            }
        }
        public void makeExpresso()
        {
            if (wasserStand == 0 && bohnenMenge == 0)
            {
                Console.Clear();
                ConsoleWriteColor("\n :) Zuerst sollen Sie Wasser und Bohnen geben\n\n\n", "rot");

            }
            else if (wasserStand > 200)
            {
                if (bohnenMenge > 25)
                {
                    wasserStand -= 200;
                    bohnenMenge -= 25;
                    Console.Clear();
                    makePunkt("ESPRESSO");
                    Console.Clear();
                    ConsoleWriteColor("\nIhr ESPRESSO ist fertig. Guten Appetit...\n\n\n", "");
                }
                else
                {
                    Console.Clear();
                    ConsoleWriteColor("\nZu wenig Kaffeemenge\n\n\n", "rot");
                   
                }

            }
            else
            {
                Console.Clear();
                ConsoleWriteColor("\nZu wenig Wasser\n\n\n", "rot");
                
            }
        }
        public void makeLatte()
        {
            if (milchStand == 0 && bohnenMenge == 0)
            {
                Console.Clear();
                ConsoleWriteColor("\nZuerst sollen Sie Milc und Bohnen geben\n\n\n", "rot");

            }
            else if (milchStand > 250)
            {
                if (bohnenMenge > 25)
                {
                    milchStand-= 250;
                    bohnenMenge -= 25;
                    Console.Clear();
                    makePunkt("LATTE");
                    Console.Clear();
                    ConsoleWriteColor("\n :) Ihr LATTE ist fertig. Guten Appetit...\n\n\n", "");
                }
                else
                {
                    Console.Clear();
                    ConsoleWriteColor("\nZu wenig Kaffeemenge\n\n\n", "rot");
                    
                }

            }
            else
            {
                Console.Clear();
                ConsoleWriteColor("\nZu wenig Milc\n\n\n", "rot");
               
            }
        }
        public void MachMaximalStand()
        {
            
            wasserStand = maxWasserStand;
            bohnenMenge = maxBohnenMenge;
            milchStand = maxMilschStand;
            Console.Clear();
            ConsoleWriteColor("\nMaximaler Wasser Milch  und Kaffeestand\n\n\n", "gelb");
            
            
            
        }
        public void showAktuelleMenge()
        {
            Console.Clear ();
            
            Console.WriteLine("\nAktulle menge");
            vorhandeMengen();

        }
        public void vorhandeMengen()
        {
            string farbe;
            if (wasserStand < 2000 && bohnenMenge < 8) farbe = "rot"; else farbe = "gelb";

            ConsoleWriteColor($"Wasserstand ist\t: {wasserStand} ml\nMilchstand ist\t: {milchStand} gr\nBohnenstand ist\t: {bohnenMenge} gr.",farbe);
        }
        private void ConsoleWriteColor(string text, string farbe)
        {
           if (farbe.ToLower() == "rot")
            {
              
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(text);
                Console.ResetColor();
            }else if (farbe.ToLower() == "grün")
            {
           
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(text);
                Console.ResetColor();
            }else if (farbe.ToLower() == "blaue")
            {
              
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(text);
                Console.ResetColor();
            }
            else if (farbe.ToLower() == "gelb")
            {
               
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(text);
                Console.ResetColor();
             }
            else
            {
               
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(text);
                Console.ResetColor();
            }
           
        }
        private void makePunkt(string gatrenke)
        {
            Console.WriteLine($"\nIhr {gatrenke} wird  vorbereitet.");
            for (int i=0;i<3;i++)
            {
                Console.Write(". ");
                Thread.Sleep(500);
            }
        }
      
    }
}
