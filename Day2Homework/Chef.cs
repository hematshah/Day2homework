using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2Homework
{
    class Chef
    {

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

        private String AnimalFlesh;

    }
    class MeatType : Meat
    {
        private string Redmeat;
        private string Poultry;
        private string Pork;
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
        public bool eaten;
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
