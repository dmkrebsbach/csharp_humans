using System;

namespace humans
{
    
    public class Human
    {
        // Fields for Human
        public string Name {get;set;}
        public int Strength {get;set;} = 3;
        public int Intelligence {get;set;} = 1;
        public int Dexterity {get;set;} = 5;
        private int health {get;set;} = 100;

        public int Health  
        {
            get { return health;}  // add a public "getter" property to access health
        }

        public Human(string name)  // Add a constructor that takes a value to set Name, and set the remaining fields to default values
        {
            Name = name;
        }

        public Human(string name, int strength, int intelligence, int dexterity, int health)  // Add a constructor to assign custom values to all fields
        {
            Name = name;
            Strength = strength;
            Intelligence = intelligence;
            Dexterity = dexterity;
            this.health = health;
        }

        
        public void Attack(Object victim) // Build Attack method
        {
            var Victim = (Human) victim;
            Victim.health -= 2 * Strength;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"ATTACK! {Victim.Name} loses {2 * Strength} pts from their Health!");
            Console.WriteLine("Current Victim Stats: " + Victim.ToString() );
            Console.ForegroundColor = ConsoleColor.White;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Strength: {Strength}, Intelligence: {Intelligence}, Dexterity: {Dexterity}, Health: {Health}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Human("Damian");
            var player2 = new Human("Lee", 10, 50, 5, 20);
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            player2.Attack(player1);
        }
    }
}
