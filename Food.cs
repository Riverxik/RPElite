using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPElite
{
    class Food : Item
    {
        private int foodValue;
        private int waterValue;
        private int sleepValue;

        public Food(string name, string desc, int price, int foodValue, int waterValue, int sleepValue) : base(name, desc, price)
        {
            this.foodValue = foodValue;
            this.waterValue = waterValue;
            this.sleepValue = sleepValue;
        }

        public int GetFoodValue() { return this.foodValue; }
        public int GetWaterValue() { return this.waterValue; }
        public int GetSleepValue() { return this.sleepValue; }

        public string[] ToStringArray()
        {
            return new string[] { this.name, this.desc, this.price.ToString()};
        }
    }
}
