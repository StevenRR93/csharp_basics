using System;
using System.Collections.Generic;
namespace basic_13
{
    class Program
    {
        public static void oneto255(){
            for (int i = 1; i <= 255; i++){
                Console.Write(i + " ");
            }
        }
        public static void odds(){
            for (int i = 1; i <= 255; i++){
                if (i % 2 != 0){
                    Console.Write(i + " ");
                }
            }
        }
        public static void printSum(){
            int sum = 0;
            for (int i = 1; i <= 255; i++){
                sum += i;
                Console.Write("New number: "+i+" Sum: "+sum + "  ");
            }
        }
        public static void iterate(int[] arr){
            for (int i = 0; i < arr.Length; i++){
                Console.Write(arr[i] + " ");
            }
        }
        public static void findMax(int[] arr){
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++){
                Console.Write(arr[i] + " ");
                if (max < arr[i]){
                    max = arr[i];
                }
                
            }
            Console.WriteLine("Max: " + max);
        }
        public static void getAvg(int[] arr){
            int avg = 0;
            for (int i = 0; i < arr.Length; i++){
                avg += arr[i];
            }
            avg /= arr.Length;
            Console.WriteLine("Avg: " + avg);
        }
        public static int[] arrwithodd(){
            List<int> numList = new List<int>();
            for (int i = 0; i < 255; i++){
                if (i % 2 != 0){
                    numList.Add(i);
                }  
            }
            int[] intArr = numList.ToArray();
            return intArr;
        }
        public static int greaterThanY(int[] arr, int y){
            int count = 0;
            for (int i = 0; i < arr.Length; i++){
                if (arr[i] > y){
                    Console.Write(arr[i] + " ");
                    count++;
                }
            } 
            return count;
        }
        public static int[] squareArr(int[] arr){
            for (int i = 0; i < arr.Length; i++){
                arr[i] = arr[i]*arr[i];
                Console.Write(arr[i] + " ");
            }
            return arr;
        }
        public static int[] removeNegatives(int[] arr){
            for (int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    arr[i] = 0;
                }
                Console.Write(arr[i] + " ");
            }
            return arr;
        }
        public static void minMaxAvg(int[] arr){
            int min = arr[0];
            int max = arr[0];
            int avg = 0;
            for (int i = 0; i < arr.Length; i++){
                if(max < arr[i]){
                    max = arr[i];
                }
                if(min > arr[i]){
                    min = arr[i];
                }
                avg += arr[i];
            }
            avg /= arr.Length;
            Console.WriteLine("Min: " +  min);
            Console.WriteLine("Max: " +  max);
            Console.WriteLine("Avg: " +  avg);
        }
        public static int[] shiftVal(int[] arr){
            for (int i = 0; i < arr.Length-1; i++){
                arr[i] = arr[i+1];
                Console.Write(arr[i] + " ");
            }
            if (arr.Length > 1){
                arr[arr.Length-1] = 0;
            }
            Console.Write(arr[arr.Length-1] + " ");
            return arr;
        }
        public static object[] numberToString(int[] arr){
            object[] newarr = new object[arr.Length];
            for (int i = 0; i < arr.Length; i++){
                if(arr[i] < 0){
                    newarr[i] = "Dojo";
                }
                else{
                    newarr[i] = arr[i];
                }
                Console.Write(newarr[i] + " ");
            }
            return newarr;
        }
        static void Main(string[] args)
        {
            oneto255();
            Console.WriteLine("");
            odds();
            Console.WriteLine("");
            printSum();
            Console.WriteLine("");
            int[] x = new int[] {1,3,5,7,9,13};
            iterate(x);
            Console.WriteLine("");
            int[] y = new int[] {-3,-5,-7,0,1,3,5,7,9,13};
            findMax(y);
            getAvg(y);
            Console.WriteLine("");
            arrwithodd();
            Console.Write("");
            int[] z = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
            greaterThanY(z, 5);
            Console.WriteLine("");
            squareArr(z);
            Console.WriteLine("");
            int[] n = new int[] {-1, -2, 3, 4, 5, -6, 7, -8, 9};
            removeNegatives(n);
            Console.WriteLine("");
            int[] a = new int[] {-1, -2, 3, 4, 5, -6, 7, -8, 9};
            minMaxAvg(a);
            int[] b = new int[] {-1, -2, 3, 4, 5, -6, 7, -8, 9};
            shiftVal(b);
            Console.WriteLine("");
            int[] c = new int[] {-1, -2, 3, 4, 5, -6, 7, -8, 9};
            numberToString(c);
            Console.WriteLine("");
        }
    }
}
