using System.Collections.Generic;

namespace RPElite
{
    class FoodFactory
    {
        private readonly static List<Food> foodList = new List<Food>();

        public static void Init()
        {
            foodList.Add(new Food("Яблоко", "Красное яблоко", 10, 5, 3, 0));
            foodList.Add(new Food("Суп", "Космический суп", 50, 50, 30, 0));
            foodList.Add(new Food("Квас", "Как насчёт космической окрошки?", 30, 10, 40, 0));
            foodList.Add(new Food("Молоко", "В космосе с огурцами лучше не употреблять", 25, 0, 30, 0));
            foodList.Add(new Food("Энегетик", "Нужно отложить сон? Это то, что нужно!", 60, 0, 5, 80));
        }

        public static Food CreateFood(string name)
        {
            return foodList.Find(item => item.GetName().Equals(name));
        }

        public static List<Food> GetAllFood() { return foodList; }
    }
}
