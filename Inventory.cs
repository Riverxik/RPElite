using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPElite
{
    class Inventory
    {
        private readonly Dictionary<Item, int> items = new Dictionary<Item, int>();
        private readonly int maxCount = 50;

        public void Add(Item item, int count)
        {
            items.Add(item, count);
        }

        public bool CanAddItemToInventory(Item item)
        {
            if(this.items.ContainsKey(item))
            {
                int count = this.items[item];
                if (count + 1 > maxCount)
                {
                    return false;
                }
            }
            return true;
        }

        public bool CanRemoveItemFromInventory(Item item)
        {
            if (this.items.ContainsKey(item))
            {
                int count = this.items[item];
                if (count - 1 < 0)
                {
                    return false;
                }
                return true;
            }
            else
            {
                throw new NullReferenceException("This item is not exists in inventory: " + item.GetName());
            }
        }

        public void AddItemToInventory(Item item)
        {
            if (this.items.ContainsKey(item))
            {
                int count = this.items[item];
                this.items[item] = ++count;
            }
            else
            {
                this.items.Add(item, 1);
            }
        }

        public void RemoveItemFromInventory(Item item)
        {
            int count = this.items[item];
            if (count - 1 >= 0)
            {
                this.items[item] = --count;
            }
        }

        public string[][] GetInventoryItemsInfoByClass(string className)
        {
            List<string[]> resList = new List<string[]>();
            List<string> row = new List<string>();
            foreach (Item item in this.items.Keys)
            {
                if (item.GetType().ToString().Equals("RPElite."+className))
                {
                    string name = item.GetName();
                    foreach (string s in item.ToStringArray())
                    {
                        row.Add(s);
                    }
                    row.Add(this.items[item].ToString());
                    row.Add("<");
                    row.Add(PluginEngine.commander.GetInventory().GetCountOfItemByName(name).ToString());
                    resList.Add(row.ToArray());
                    row.Clear();
                }
            }
            return resList.ToArray();
        }

        public int GetCountOfItemByName(string itemName)
        {
            try
            {
                return items[FoodFactory.CreateFood(itemName)];
            } catch (KeyNotFoundException)
            {
                return 0;
            }
        }
    }
}
