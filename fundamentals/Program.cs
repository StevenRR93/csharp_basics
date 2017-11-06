using System;

namespace fundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 255; i++){
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            for (int i = 1; i <= 100; i++){
                if ((i % 3 == 0 || i % 5 == 0) & i % 15 != 0){
                    Console.Write(i + " ");
                }     
            }
            Console.WriteLine("");
            for (int i = 1; i <= 100; i++){
                if ( i % 15 == 0){
                    Console.Write("FIZZBUZZ ");
                }
                else if (i % 3 == 0 ) {
                    Console.Write("FIZZ ");
                }
                else if (i % 5 == 0){
                    Console.Write("BUZZ ");
                }
                else{
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("");
            int fbc = 0;
            int fc = 0;
            int bc = 0;
            for (int i = 1; i <= 100; i++){
                if (fbc == 15 ) {
                    bc = 0;
                    fbc = 0;
                    fc = 0;
                    Console.Write("FIZZBUZZ ");
                }
                else if (bc == 5){
                    bc = 0;
                    fc++;
                    fbc++;
                    Console.Write("BUZZ ");
                }
                else if (fc == 3){
                    fc = 0;
                    fbc++;
                    bc++;
                    Console.Write("FIZZ");
                }
                else{
                    fbc++;
                    fc++;
                    bc++;
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine("");
            Random rand = new Random();
            for(int val = 0; val < 10; val++){
                //Prints the next random value between 2 and 8
                int newval = rand.Next(1,1000);
                if (newval % 15 == 0){
                    Console.Write("FIZZBUZZ ");
                }
                else if (newval % 3 == 0 ) {
                    Console.Write("FIZZ ");
                }
                else if (newval % 5 == 0){
                    Console.Write("BUZZ ");
                }
                else{
                    Console.Write(newval + " ");
                }
            }
        }
    }
}
