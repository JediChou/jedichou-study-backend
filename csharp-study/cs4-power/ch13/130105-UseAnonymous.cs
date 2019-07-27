// C#与.NET4高级程序设计（第五版）
// 13.1.5 匿名类型
// Jedi Chou - 2016.2.27, 22:13
class Program {
    static void Main() {
        var purchaseItem = new {
            TimeBought = System.DateTime.Now,
            ItemBought = new { Color = "Red", Make = "Saab", CurrentSpeed = 55},
            Price = 34.000
        };
        
        System.Console.WriteLine(
            "TimeBought:{0}, ItemBought.Color:{1}, ItemBought.Make:{2}, ItemBought.CurrentSpeed:{3}, Price:{4}",
             purchaseItem.TimeBought.ToString(),
             purchaseItem.ItemBought.Color,
             purchaseItem.ItemBought.Make,
             purchaseItem.ItemBought.CurrentSpeed,
             purchaseItem.Price
        );
    }
}