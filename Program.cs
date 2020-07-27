using System;
using System.Collections.Generic;

namespace Lab_5._1_RPG
{
    class GameCharacter
    {
        
       public string name { get; set; }
       public int strength { get; set; }
       public int intelligence { get; set; }

        public GameCharacter (string theName, int theStrength, int Intel)
        {
            name = theName;
            strength = theStrength;
            intelligence = Intel;
        }
        public virtual void play()
        {
            Console.WriteLine($"{name}, Strength: {strength}, Intelligence: {intelligence}.");
            Console.WriteLine();
        }

        

    }
    class Warrior : GameCharacter
    {
        public string WeaponType { get; set; }

        public Warrior (string theName, int theStrength, int Intel, string theWeaponType) : base(theName, theStrength, Intel)
        {
            WeaponType = theWeaponType;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine($"Warrior {name} uses a {WeaponType} to crush their foes!");
            Console.WriteLine();
        }
    }
    class MagicUser : GameCharacter
    {
        public int magicalEnergy { get; set; }
        
        public MagicUser(string theName, int theStrength, int Intel, int theMagicalEnergy ) : base(theName, theStrength, Intel)
        {
            magicalEnergy = theMagicalEnergy;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine($"{name} has a Mana Pool of {magicalEnergy} to help them cast more Lightning Bolts!");
            Console.WriteLine();
        }
    }
    class Wizard : MagicUser 
    {
        public int spellNumber { get; set; }
        
        public Wizard(string theName, int theStrength, int Intel, int theMagicalEnergy, int theSpellNumber) : base(theName, theStrength, Intel, theMagicalEnergy)
        {
            spellNumber = theSpellNumber;
        }
        public override void play()
        {
            base.play();
            Console.WriteLine($"{name} can cast {spellNumber} different spells.");
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to RPG's R Us!");
            Console.WriteLine();

            List<GameCharacter> characterList = new List<GameCharacter>();

            characterList.Add(new Warrior("Conan", 25, 3, "(Atlantean Sword)Bastard Sword"));
            characterList.Add(new Warrior("He-Man", 36, 18, "(Power Sword)Longsword"));
            characterList.Add(new Warrior("Xena", 23, 10, "Chakram"));
            characterList.Add(new Wizard("Merlin", 10, 30, 800, 9001));
            characterList.Add(new Wizard("Wicked Witch of the West", 4, 8, 30, 3));

            foreach(GameCharacter Character in characterList  )
            {
                Character.play();
            }
        }

    }

}
