using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPElite
{
    class Item
    {
        protected readonly string name;
        protected readonly string desc;
        protected readonly int price;

        public Item(string name, string desc, int price)
        {
            this.name = name;
            this.desc = desc;
            this.price = price;
        }

        public string GetName() { return this.name; }
        public string GetDesc() { return this.desc; }
        public int GetPrice() { return this.price; }

        public string[] ToStringArray()
        {
            return new string[] { this.name, this.desc, this.price.ToString() };
        }
    }
}
