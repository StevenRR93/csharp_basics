using System;
using DbConnection; 
namespace simple_CRUD
{
    class Program
    {
        public static void Read(){
            DbConnector.Query("select name, id from users");
        }
        static void Main(string[] args)
        {
            string InputLine = "";
            while (InputLine != "quit"){
                Read();
                Console.WriteLine("Please enter a query to begin otherwise type 'quit' to end.");
                InputLine = Console.ReadLine();
                switch (InputLine)
                {
                    case "1":
                        Console.WriteLine("Case 1");
                        break;
                    case "2":
                        Console.WriteLine("Case 2");
                        break;
                    case "3":
                    default:
                        Console.WriteLine("Default case");
                        break;
                }
            }

        }
    }
}
