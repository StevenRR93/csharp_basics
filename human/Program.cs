using System;

namespace human
{
    public class Human{
        public string name;
        public int strength = 3;
        public int intelligence = 3;
        public int dexterity = 3;
        public int health = 100;
        //Notice the Constructor function doesn't need
        //a return type or the static keyword
        public Human(string n)
        {
            name = n;
        }
        public Human(string n, int s, int i, int d, int h )
        {
            name = n;
            strength = s;
            intelligence = i;
            dexterity = d;
            health = h;
        }
        public void attack(Human target){
            if (target.health > 0){
                target.health -= 5*strength;
                Console.WriteLine(name + " attacked " + target.name+ " for " + 5*strength+ " damage");
            }
            
        }
        public void attackAny(object target){
            if (target is Human) {
                Human t = (Human)target;
                Console.WriteLine(name + " attacked " + t.name+ " for " + 5*strength+ " damage");
            }
            else{
                Console.WriteLine("You cannot attack that.");
            }
        }
        public void showstats(){
            Console.WriteLine("Name "+ name);
            Console.WriteLine("Strength "+ strength);
            Console.WriteLine("Intelligence "+ intelligence);
            Console.WriteLine("Dexterity "+ dexterity);
            Console.WriteLine("health "+ health);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Human guy = new Human("Guy", 5, 5, 5, 150);
            Human dude = new Human("Dude");
            guy.attack(dude);
            guy.showstats();
            dude.showstats();
        }
    }
}
