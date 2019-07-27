// c#与.NET高级程序设计（第五版）
// 13.1.1 隐式类型本地变量
// Jedi Chou - 2016.2.27 21:09
class UseVar {
    class Point {
        public int X {get; set;}
        public int Y {get; set;}
    }
    
    static void PrintType(object o) {
        System.Console.WriteLine(o.GetType().Name);
    }
    
    static void Main() {
        var myInt = 0;
        var myBool = true;
        var myString = "Time, marches on ...";
        var myPoint = new Point {X=1, Y=1};
        PrintType(myInt);
        PrintType(myBool);
        PrintType(myString);
        PrintType(myPoint);
    }
}