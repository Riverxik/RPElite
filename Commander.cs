using System.Collections.Generic;

namespace RPElite
{
    class Commander
    {
        // Constants.
        private const int MIN_FOOD = 0;
        private const int MAX_FOOD = 100;
        private const int MIN_WATER = 0;
        private const int MAX_WATER = 100;
        private const int MIN_SLEEP = 0;
        private const int MAX_SLEEP = 100;
        private const int FOOD_STEP = 3;
        private const int WATER_STEP = 5;
        private const int SLEEP_STEP = 1;

        private readonly Inventory inventory;

        private int food = MAX_FOOD;
        private int water = MAX_WATER;
        private int sleep = MAX_SLEEP;
        private int money = 100;

        public Commander()
        {
            // For future use.
            inventory = new Inventory();
            InitializeInventory();
        }

        private void InitializeInventory()
        {
            foreach (Food food in FoodFactory.GetAllFood())
            {
                inventory.Add(food, 0);
            }
        }

        public void DecreaseStats()
        {
            if (this.food - FOOD_STEP > MIN_FOOD) this.food -= FOOD_STEP; else this.food = MIN_FOOD;
            if (this.water - WATER_STEP > MIN_WATER) this.water -= WATER_STEP; else this.water = MIN_WATER;
            if (this.sleep - SLEEP_STEP > MIN_SLEEP) this.sleep -= SLEEP_STEP; else this.sleep = MIN_SLEEP;
        }

        public int GetFood() { return this.food; }
        public int GetWater() { return this.water; }
        public int GetSleep() { return this.sleep; }
        public int GetMoney() { return this.money; }
        public Inventory GetInventory() { return this.inventory; }

        public void AddFood(int amount)
        {
            if (this.food + amount < MAX_FOOD) this.food += amount; else this.food = MAX_FOOD;
        }

        public void AddWater(int amount)
        {
            if (this.water + amount < MAX_WATER) this.water += amount; else this.water = MAX_WATER;
        }

        public void AddSleep()
        {
            this.sleep = MAX_SLEEP;
        }

        public bool AddMoney(int amount)
        {
            if (money + amount >= 0)
            {
                this.money += amount;
                return true;
            }
            return false;
        }

        public bool CanBuyItemWithPrice(int price)
        {
            return this.money - price >= 0;
        }
    }
}
