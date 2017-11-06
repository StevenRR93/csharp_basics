using System;

namespace puzzles
{
    class Program
    {
        public static int[] RandomArray(){
            int min = 25;
            int max = 5;
            int sum = 0;
            int[] arr = new int[10];
            Random rand = new Random();
            for (int i = 0; i < 10; i++){
                arr[i] = rand.Next(5, 25);
                if ( max < arr[i]){
                    max = arr[i];
                }
                if (min > arr[i]){
                    min = arr[i];
                }
                sum += arr[i];
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine("\nMax: " + max);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Sum: " + sum);
            return arr;
        }
        public static string tossCoin(){
            Random rand = new Random();
            int coin = rand.Next(0,2);
            if (coin == 0){
                Console.WriteLine("Heads");
                return "Heads";
            }
            Console.WriteLine("Tails");
            return "Tails";
            
        }
        public static double TossMultipleCoins(int num){
            double ratio = 0;
            Random rand = new Random();
            double heads = 0, tails = 0;
            for (int i = 0; i < num; i++){
                int coin = rand.Next(0,2);
                if (coin == 0){
                    Console.WriteLine("Heads");
                    heads += 1.0;
                }
                else{
                    Console.WriteLine("Tails");
                    tails += 1.0;
                }
            }
            if (num > 0){
                 ratio = heads/num;
            }
            return ratio;
        }
        public static string[] names(){
            string[] newarr = new string[] {"Todd", "Tiffany", "Charlie", "Geneva", "Sydney"};
            Random rand = new Random();
            for (int i = 0; i < 5; i++){
                int rnd = rand.Next(i, 5);
                string temp = newarr[i];
                newarr[i] = newarr[rnd];
                newarr[rnd] = temp;
                Console.Write(newarr[i] + " ");
            }
            string[] lessthan = new string[4];
            int j = 0;
            for (int i = 0; i < 4; i++){
                if (newarr[j].Length > 5){
                    lessthan[i] = newarr[j];
                }
                j++;
            }
            Console.WriteLine("");
            return lessthan;
        }
        static void Main(string[] args)
        {
            RandomArray();
            RandomArray();
            tossCoin();
            tossCoin();
            Console.WriteLine("Heads ratio: " + TossMultipleCoins(10));
            Console.WriteLine("Heads ratio: " + TossMultipleCoins(50));
            names();
            names();
        }
    }
}
