using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Today_at_the_zoo_project
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initiations
            Zebra myZebra = new Zebra();
            myZebra.AnimalName = "Zebra";
            myZebra.AnimalType = "Mammal";
            myZebra.AnimalColor = "White & Black";
            myZebra.ColorPattern = "Stripes";
            myZebra.LegCount = 4;
            myZebra.HasTails = true;
            myZebra.HasBoots = true;
            myZebra.IsHealthy = false;
            myZebra.HasTwoHearts = false;

            Hippo myHippo = new Hippo();
            myHippo.AnimalName = "Hippopotamus";
            myHippo.AnimalType = "Mammal";
            myHippo.AnimalColor = "Brown";
            myHippo.ColorPattern = "Solid";
            myHippo.LegCount = 4;
            myHippo.HasTails = true;
            myHippo.LivesInWater = true;
            myHippo.IsHealthy = true;
            myHippo.AttacksHumans = true;

            Tiger mytiger = new Tiger();
            mytiger.AnimalName = "Sabre Tooth Tiger";
            mytiger.AnimalType = "Mammal";
            mytiger.AnimalColor = "Brown & Black";
            mytiger.ColorPattern = "Polka Dot";
            mytiger.LegCount = 4;
            mytiger.HasTails = true;
            mytiger.IsAgressive = true;
            mytiger.IsHealthy = true;
            mytiger.Diet = "Cannivore";

            Snake mySnake = new Snake();
            mySnake.AnimalName = "Black Mamba";
            mySnake.AnimalType = "Reptile";
            mySnake.AnimalColor = "Black";
            mySnake.ColorPattern = "Scaly string Patterns";
            mySnake.LegCount = 0;
            mySnake.HasTails = false;
            mySnake.IsFast = true;
            mySnake.IsHealthy = true;
            mySnake.IsPoisenous = true;

            Turtle myTurtle = new Turtle();
            myTurtle.AnimalName = "Carribean Turtle";
            myTurtle.AnimalType = "Mammal";
            myTurtle.AnimalColor = "Grey";
            myTurtle.ColorPattern = "Scaly Block Patterns";
            myTurtle.LegCount = 4;
            myTurtle.HasTails = false;
            myTurtle.IsTricky = true;
            myTurtle.IsHealthy = false;
            myTurtle.IsRare = true;

            Scorpions myScorpions = new Scorpions();
            myScorpions.AnimalName = "Egyptian Scorion";
            myScorpions.AnimalType = "Arachnid";
            myScorpions.AnimalColor = "Yellow & brown";
            myScorpions.ColorPattern = "Glossy & Scaly";
            myScorpions.LegCount = 8;
            myScorpions.HasTails = true;
            myScorpions.HasStealth = true;
            myScorpions.IsHealthy = true;
            myScorpions.HasStinger = true;

            Spiders mySpiders = new Spiders();
            mySpiders.AnimalName = "Black Widow Spider";
            mySpiders.AnimalType = "Arachnid";
            mySpiders.AnimalColor = "Black";
            mySpiders.ColorPattern = "Solid";
            mySpiders.LegCount = 8;
            mySpiders.HasTails = false;
            mySpiders.HasBigHead = false;
            mySpiders.IsHealthy = true;
            mySpiders.IsCrazy = true;

            Crocodile myCrocodile = new Crocodile();
            myCrocodile.AnimalName = "African Crocodile";
            myCrocodile.AnimalType = "Reptile";
            myCrocodile.AnimalColor = "Dark Brown";
            myCrocodile.ColorPattern = "Scaly, Solid & Rugged";
            myCrocodile.LegCount = 4;
            myCrocodile.HasTails = true;
            myCrocodile.IsRugged = true;
            myCrocodile.IsHealthy = true;
            myCrocodile.IsStrong = true;

            Ticks myTicks = new Ticks();
            myTicks.AnimalName = "Tick";
            myTicks.AnimalType = "Arachnid";
            myTicks.AnimalColor = "Dark Brown";
            myTicks.ColorPattern = "Solid";
            myTicks.LegCount = 8;
            myTicks.HasTails = false;
            myTicks.SucksBlood = true;
            myTicks.IsHealthy = true;
            myTicks.LiveInDogs = false;

            #endregion
            Console.Title = ("A Day At The Zoo Project V1");
            Console.WriteLine("I Went To The Zoo Today, It Was Fun And Informative.\n");
            Console.WriteLine("A few things about these animals.\n");

            #region Zebra WriteLine
            Console.WriteLine("The Zebra\n");
            Console.WriteLine("Name:" + myZebra.AnimalName);
            Console.WriteLine("Type:" + myZebra.AnimalType);
            Console.WriteLine("Color:" + myZebra.AnimalColor);
            Console.WriteLine("Pattern:" + myZebra.ColorPattern);
            Console.WriteLine("# of legs:" + myZebra.LegCount);
            Console.WriteLine("Has a Tail:" + myZebra.HasTails);
            Console.WriteLine("It has boots:" + myZebra.HasBoots);
            Console.WriteLine("It's Healthy:" + myZebra.IsHealthy);
            Console.WriteLine("It has two hearts:" + myZebra.HasTwoHearts);
            Console.WriteLine("\n");
            #endregion

            #region Hippo WriteLine
            Console.WriteLine("The Hippopotamus\n");
            Console.WriteLine("Name:" + myHippo.AnimalName);
            Console.WriteLine("Type:" + myHippo.AnimalType);
            Console.WriteLine("Color:" + myHippo.AnimalColor);
            Console.WriteLine("Pattern:" + myHippo.ColorPattern);
            Console.WriteLine("# of legs:" + myHippo.LegCount);
            Console.WriteLine("Has a Tail:" + myHippo.HasTails);
            Console.WriteLine("Lives in Water:" + myHippo.LivesInWater);
            Console.WriteLine("It's Healthy:" + myHippo.IsHealthy);
            Console.WriteLine("It attacks humans:" + myHippo.AttacksHumans);
            Console.WriteLine("\n");
            #endregion

            #region Tiger WriteLine
            Console.WriteLine(" The Tiger\n");
            Console.WriteLine("Name:" + mytiger.AnimalName);
            Console.WriteLine("Type:" + mytiger.AnimalType);
            Console.WriteLine("Color:" + mytiger.AnimalColor);
            Console.WriteLine("Pattern:" + mytiger.ColorPattern);
            Console.WriteLine("# of legs:" + mytiger.LegCount);
            Console.WriteLine("Has a Tail:" + mytiger.HasTails);
            Console.WriteLine("It's Agressive:" + mytiger.IsAgressive);
            Console.WriteLine("It's Healthy:" + mytiger.IsHealthy);
            Console.WriteLine("Diet:" + mytiger.Diet);
            Console.WriteLine("\n");
            #endregion

            #region Snake WriteLine
            Console.WriteLine("The Snake\n");
            Console.WriteLine("Name:" + mySnake.AnimalName);
            Console.WriteLine("Type:" + mySnake.AnimalType);
            Console.WriteLine("Color:" + mySnake.AnimalColor);
            Console.WriteLine("Pattern:" + mySnake.ColorPattern);
            Console.WriteLine("# of legs:" + mySnake.LegCount);
            Console.WriteLine("Has a Tail:" + mySnake.HasTails);
            Console.WriteLine("It's fast:" + mySnake.IsFast);
            Console.WriteLine("It's Healthy:" + mySnake.IsHealthy);
            Console.WriteLine("It's Poisenous:" + mySnake.IsPoisenous);
            Console.WriteLine("\n");
            #endregion

            #region Turtle WriteLine
            Console.WriteLine("The Turtle\n");
            Console.WriteLine("Name:" + myTurtle.AnimalName);
            Console.WriteLine("Type:" + myTurtle.AnimalType);
            Console.WriteLine("Color:" + myTurtle.AnimalColor);
            Console.WriteLine("Pattern:" + myTurtle.ColorPattern);
            Console.WriteLine("# of legs:" + myTurtle.LegCount);
            Console.WriteLine("Has a Tail:" + myTurtle.HasTails);
            Console.WriteLine("It's Tricky:" + myTurtle.IsTricky);
            Console.WriteLine("It's Healthy:" + myTurtle.IsHealthy);
            Console.WriteLine("It's Rare:" + myTurtle.IsRare);
            Console.WriteLine("\n");
            #endregion

            #region Scorpion WriteLine
            Console.WriteLine("The Scorpion\n");
            Console.WriteLine("Name:" + myScorpions.AnimalName);
            Console.WriteLine("Type:" + myScorpions.AnimalType);
            Console.WriteLine("Color:" + myScorpions.AnimalColor);
            Console.WriteLine("Pattern:" + myScorpions.ColorPattern);
            Console.WriteLine("# of legs:" + myScorpions.LegCount);
            Console.WriteLine("Has a Tail:" + myScorpions.HasTails);
            Console.WriteLine("It's Sneaky:" + myScorpions.HasStealth);
            Console.WriteLine("It's Healthy:" + myScorpions.IsHealthy);
            Console.WriteLine("It has a stinger:" + myScorpions.HasStinger);
            Console.WriteLine("\n");
            #endregion

            #region Spider WriteLine
            Console.WriteLine("The Spider\n");
            Console.WriteLine("Name:" + mySpiders.AnimalName);
            Console.WriteLine("Type:" + mySpiders.AnimalType);
            Console.WriteLine("Color:" + mySpiders.AnimalColor);
            Console.WriteLine("Pattern:" + mySpiders.ColorPattern);
            Console.WriteLine("# of legs:" + mySpiders.LegCount);
            Console.WriteLine("Has a Tail:" + mySpiders.HasTails);
            Console.WriteLine("It has big head:" + mySpiders.HasBigHead);
            Console.WriteLine("It's Healthy:" + mySpiders.IsHealthy);
            Console.WriteLine("It's crazy:" + mySpiders.IsCrazy);
            Console.WriteLine("\n");
            #endregion

            #region Crocodile WriteLine
            Console.WriteLine("The Crocodile\n");
            Console.WriteLine("Name:" + myCrocodile.AnimalName);
            Console.WriteLine("Type:" + myCrocodile.AnimalType);
            Console.WriteLine("Color:" + myCrocodile.AnimalColor);
            Console.WriteLine("Pattern:" + myCrocodile.ColorPattern);
            Console.WriteLine("# of legs:" + myCrocodile.LegCount);
            Console.WriteLine("Has a Tail:" + myCrocodile.HasTails);
            Console.WriteLine("It's rugged:" + myCrocodile.IsRugged);
            Console.WriteLine("It's Healthy:" + myCrocodile.IsHealthy);
            Console.WriteLine("It's very strong:" + myCrocodile.IsStrong);
            Console.WriteLine("\n");
            #endregion

            #region Tick WriteLine
            Console.WriteLine("The Tick\n");
            Console.WriteLine("Name:" + myTicks.AnimalName);
            Console.WriteLine("Type:" + myTicks.AnimalType);
            Console.WriteLine("Color:" + myTicks.AnimalColor);
            Console.WriteLine("Pattern:" + myTicks.ColorPattern);
            Console.WriteLine("# of legs:" + myTicks.LegCount);
            Console.WriteLine("Has a Tail:" + myTicks.HasTails);
            Console.WriteLine("It sucks blood:" + myTicks.SucksBlood);
            Console.WriteLine("It's Healthy:" + myTicks.IsHealthy);
            Console.WriteLine("It lives in dogs:" + myTicks.LiveInDogs);
            Console.WriteLine("\n");
            #endregion


            Console.ReadLine();
             


        }
    }
}
