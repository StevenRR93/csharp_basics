using System;

namespace Wizard_ninja_samurai
{

    public class Human
    {
        public string name;

        //The { get; set; } format creates accessor methods for the field specified
        //This is done to allow flexibility
        public int health { get; set; }
        public int strength { get; set; }
        public int intelligence { get; set; }
        public int dexterity { get; set; }

        public Human(string person)
        {
            name = person;
            strength = 3;
            intelligence = 3;
            dexterity = 3;
            health = 100;
        }
        public Human(string person, int str, int intel, int dex, int hp)
        {
            name = person;
            strength = str;
            intelligence = intel;
            dexterity = dex;
            health = hp;
        }
        public void attack(object obj)
        {
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= strength * 5;
            }
        }
    }
    public class Wizard : Human{
        public Wizard(string n) : base(n){
            name = n;
            intelligence = 25;
            health = 50;
        }
        public void heal(){
            health += 10*intelligence;
        }
        public void fireball(object obj){
            Random rand = new Random();
            int fireball = rand.Next(20,50);
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= fireball;
            }
        }
    }
    public class Ninja : Human{
        public Ninja(string n) : base(n){
            name = n;
            dexterity = 175;
        }
        public void steal(object obj){
            Human enemy = obj as Human;
            if(enemy == null)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health -= 10;
                health += 10;
            }
        }
        public void get_away(){
            health -= 15;
        }
    }
    public class Samurai : Human{
        public Samurai(string n) : base(n){
            name = n;
            health = 200;
        }
        public void death_blow(object obj){
            Human enemy = obj as Human;
            if(enemy == null || enemy.health > 50)
            {
                Console.WriteLine("Failed Attack");
            }
            else
            {
                enemy.health = 0;
            }
        }
        public void mediatate(){
            health = 200;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Ninja newninja = new Ninja("Newninja");
            Wizard newwizard = new Wizard("Newwizard");
            Samurai newsamurai = new Samurai("Newsamurai");
            newwizard.fireball(newninja);
            Console.WriteLine("Wizard Health: " + newwizard.health);
            Console.WriteLine("Ninja Health: " + newninja.health);
            newninja.steal(newsamurai);
            Console.WriteLine("Samurai Health: " + newsamurai.health);
            Console.WriteLine("Ninja Health: " + newninja.health);
            newsamurai.death_blow(newwizard);
            Console.WriteLine("Samurai Health: " + newsamurai.health);
            Console.WriteLine("Wizard Health: " + newwizard.health);
        }
    }
}
