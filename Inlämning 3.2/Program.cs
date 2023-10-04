using System;
namespace Inlämning_3.__2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Har du gått ut gymnasiet j för ja och n för nej");
            string svar = Console.ReadLine();
            switch(svar) 
            {
                case "j":
                    Console.WriteLine("Hur gammal är du? ");
                    int ålder = int.Parse(Console.ReadLine());
                    if(ålder < 22)
                    {
                        Console.WriteLine("Vi vill gärna anställa dig");
                    }
                    else
                    {
                        Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
                    }
                    break;
                case "n":
                    Console.WriteLine("Vi letar tyvärr efter annan personal just nu");
                    break;
                default:
                    Console.WriteLine("Du skrev något fel");
                    break;
            }
            Console.ReadKey();
        }   
    }
}
