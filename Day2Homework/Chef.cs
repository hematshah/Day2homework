using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Homework
{
     class Chef : Cooking
    {
        int num;
        private int _howManyChefs = 3;
        public Chef()
        {
        }

        public int HowManyChefs
        {
            get => _howManyChefs;
            set
            {
                if (num < _howManyChefs)
                {
                    _howManyChefs = num;
                } 
                else if(num >_howManyChefs) 
                {
                    num = _howManyChefs;
                }

            }
        }

    }
    class Cooking : Cookware
    {
        public string Dishes;
        private string CookingUtensils;
        public string InductionHob;
    }
    class Cookware
    {
        private int NumberOfCookwareTypes;
        public string CastIron;
        public string FryingPan;
        public string Wok;
    }



    class Meat
    {
        private double animalFlesh;
        private double fats;
        private  double leanMeats;

        public Meat()
        {
        }

        public Meat(double x, double y) 
        {
            fats = x;
            leanMeats = y;
        }
        public double GetanimalFlesh() 
        {
            return animalFlesh;
        }
        public void SetanimalFlesh(double fat, double leanMeat) 
        {
            animalFlesh =   (fat / leanMeat) * 100;
        }

        public double MeatRatio() {

            double meatRatio = (fats / leanMeats) * 100;
            return meatRatio;

        }

        public virtual void PrintMeatText()
        {

            Console.WriteLine("This is you butcher speaking --> we have different meat to fat ratios. ");
          
        }

         }
    class MeatType : Meat
    {
        private string Redmeat;
        private string Poultry;
        private string Pork;

        public override void PrintMeatText() 
        {
            Console.WriteLine("We have diffrent types of meat available for veriety of meat dishes. ");
        }
    }
    class MeatVariations : MeatType
    {
        public string chicken;
        public string cow;
        public string scheep;
        public string goat;
        public string eggs;
        public string fish;


    }
    class MeatDish : MeatVariations
    {
        private string Curry;
        private bool eaten;

        public override void PrintMeatText()
        {
            Console.WriteLine(" Our signature dish is curry !"); 
        }
    }






    class Vegetables
    {
        private string Brocoli;
        public string SunFlowerSeed;
        private string Lettuce;
        private string Tomatoes;
        public string olives;
        public string potatoes;

    }
    class FryingVegDish : Oil
    {
        private string chips;

        public bool eaten;
    }
    class Oil : Vegetables
    {
        private string Vegetable;
        private string SunFlower;
        private string Olive;
        public int TypeOfoils;
    }
}
