using System;
using System.Collections;
using System.Collections.Generic;
namespace collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //three basic arrays
            int[] numArray = {0,1,2,3,4,5,6,7,8,9};
            string[] nameArray = {"Tim", "Martin", "Nikki", "Sara"};
            bool[] boolArray = new bool[10];
            for (int i = 0; i < 9; i++){
                if (i % 2 == 0){
                    boolArray[i] = true;
                }
                else{
                    boolArray[i] = false;
                }
                Console.Write(boolArray[i]+ " ");
            }
            Console.WriteLine("");
            //multiplication table
            int[,] multArray = new int[10, 10];  
            for (int i = 1; i <= 10; i ++){
                for (int j = 1; j <= 10; j++){
                    multArray[i-1,j-1] = i*j;
                    Console.Write(multArray[i-1,j-1]+ " ");
                }
                Console.WriteLine("");
            }
            //Initializing an empty list of Motorcycle Manufacturers
            List<string> ice_cream = new List<string>();
            //Use the Add function in a similar fashion to push
            ice_cream.Add("Vanilla");
            ice_cream.Add("Chocolate");
            ice_cream.Add("Strawberry");
            ice_cream.Add("Neopolitan");
            ice_cream.Add("Caramel");
            Console.WriteLine("Ice cream list length: " + ice_cream.Count);
            foreach (string ic in ice_cream)
            {
                Console.WriteLine("-" + ic);
            }
            Console.WriteLine("Removing " + ice_cream[2]);
            ice_cream.RemoveAt(2);
            Console.WriteLine("Ice cream list length: " + ice_cream.Count);
            Dictionary<string,string> user_ice_cream = new Dictionary<string,string>();
            Random rand = new Random();
            for (int i = 0; i < nameArray.Length; i++){
                user_ice_cream.Add(nameArray[i], null);
            }
            foreach (var entry in user_ice_cream)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
            for (int i = 0; i < nameArray.Length; i++){
                int temp = rand.Next(0,3);
                user_ice_cream[nameArray[i]] = ice_cream[temp];
            }
            foreach (var entry in user_ice_cream)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }
        }
    }
}
