using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPElite
{
    class Market
    {
        private readonly Inventory inventory;

        public Market()
        {
            inventory = new Inventory();
            InitializeMarket();
        }

        private void InitializeMarket()
        {
            Random random = new Random();
            foreach (Food food in FoodFactory.GetAllFood())
            {
                int rand = random.Next(1, 50);
                inventory.Add(food, rand);
            }
        }

        public Inventory GetInventory() { return this.inventory; }

        public bool SellItemsToMarket(string itemName)
        {
            Item item = FoodFactory.CreateFood(itemName);
            int price = item.GetPrice();
            Inventory cmdInv = PluginEngine.commander.GetInventory();
            Inventory mrkInv = PluginEngine.market.GetInventory();
            if (cmdInv.CanRemoveItemFromInventory(item) && mrkInv.CanAddItemToInventory(item))
            {
                // Transfer items.
                cmdInv.RemoveItemFromInventory(item);
                mrkInv.AddItemToInventory(item);
                // Money.
                PluginEngine.commander.AddMoney(price);
                return true;
            }
            return false;
        }

        public bool BuyItemsFromMaket(string itemName)
        {
            Item item = FoodFactory.CreateFood(itemName);
            int price = item.GetPrice();
            Inventory cmdInv = PluginEngine.commander.GetInventory();
            Inventory mrkInv = PluginEngine.market.GetInventory();
            if (PluginEngine.commander.CanBuyItemWithPrice(price)
                    && cmdInv.CanAddItemToInventory(item) && mrkInv.CanRemoveItemFromInventory(item))
            {
                // Transfer items.
                cmdInv.AddItemToInventory(item);
                mrkInv.RemoveItemFromInventory(item);
                // Money.
                PluginEngine.commander.AddMoney(-price);
                return true;
            }
            return false;
        }
    }
}
