using System.Reflection.PortableExecutable;

namespace Kaffemaschine
{
    internal class Program
    {
        static void Main(string[] args)
        {

            caffe();
            main();
                     
            
        }

        static void main()
        {
            while (true)
            {
                Console.WriteLine("Möchten Sie einen ETWAS trinken?(j/n)");
                string wahl = Console.ReadLine();
                if (wahl == "j")
                {
                    Console.Clear();
                    KaffeMaschine maschine = new KaffeMaschine();
                    kaffeTrinken(maschine);
                }
                else if (wahl == "n") break;
                else Console.WriteLine("Bitte j oder n");
            }

        } 

        static void kaffeTrinken(KaffeMaschine maschine)
        {
            
            
            while (true)
            {
                
                menu();
                    
                string wahl2 = Console.ReadLine();
                if (wahl2 == "7") break;
                
                else if (wahl2 == "1") maschine.makeKaffe();
                else if (wahl2 == "2") maschine.makeExpresso();
                else if (wahl2 == "3") maschine.makeCappucino();
                else if (wahl2 == "4") maschine.makeLatte();
                else if (wahl2 == "5") maschine.showAktuelleMenge();
                else if (wahl2 == "6") maschine.MachMaximalStand();

                else
                {
                    Console.Clear();
                    Console.WriteLine("\nSie haben eine falsche Taste gedrückt\n\n\n");
                }
               
            }
        }
        static void caffe()

        {
            Console.WriteLine($"\n\n{t(10)}   {t(10)}    {t(8)}    {t(8)}   {t(8)} ");
            Console.WriteLine($"{t(2)}           {t(2)}     {t(2)}    {t(2)}          {t(2)}         {t(2)} ");
            Console.WriteLine($"{t(2)}           {t(2)}     {t(2)}    {t(2)}          {t(2)}         {t(2)} ");
            Console.WriteLine($"{t(2)}           {t(10)}    {t(7)}     {t(7)}    {t(6)}");
            Console.WriteLine($"{t(2)}           {t(2)}     {t(2)}    {t(2)}          {t(2)}         {t(2)} ");
            Console.WriteLine($"{t(2)}           {t(2)}     {t(2)}    {t(2)}          {t(2)}         {t(2)} ");
            Console.WriteLine($"{t(2)}           {t(2)}     {t(2)}    {t(2)}          {t(2)}         {t(2)} ");
            Console.WriteLine($"{t(10)}   {t(2)}     {t(2)}    {t(2)}          {t(2)}         {t(8)} ");
            Console.WriteLine();
        }


        static string t(int x)
        {
            string c = "_";
            for (int i = 0; i < x; i++)
            {
                c += "?";
            }
            return c;
        }


        static void menu()
        {
            Console.WriteLine();
       
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("1 KAFFE");
            Console.WriteLine("2 ESPRESSO");
            Console.WriteLine("3 CAPUCCINO");
            Console.WriteLine("4 LATTE");
            Console.WriteLine("5 ALLE MENGEN");
            Console.WriteLine("6 MACH ALLE MAX");
            Console.WriteLine("7 EXIT ");
            Console.ResetColor();
        }
        
        
        

    }
}
