// c#与.NET高级程序设计（第五版）
// 13.1.2 对象和集合初始化与语法
// Jedi Chou - 2016.2.27 

using System;
using System.Collections.Generic;

class ObjectInitByCollections {
    
    class Point {
        public int X {get; set;}
        public int Y {get; set;}
    }
    
    class Retangle {
        public Point TopLeft {get; set;}
        public Point BottomRight {get; set;}
    }
    
    static void Main() {
        var Retangles = new List<Retangle> {
            new Retangle { 
                TopLeft = new Point {X=1, Y=20},
                BottomRight = new Point {X=30, Y=30}
            },
            new Retangle { 
                TopLeft = new Point {X=2, Y=2},
                BottomRight = new Point {X=100, Y=100}
            },
            new Retangle { 
                TopLeft = new Point {X=5, Y=5},
                BottomRight = new Point {X=90, Y=75}
            }
        };
        
        foreach (var rect in Retangles) {
            Console.WriteLine(
                "TopLeft({0},{1}), BottomRight({2},{3})",
                rect.TopLeft.X, rect.TopLeft.Y,
                rect.BottomRight.X, rect.BottomRight.Y
            );
        }
    }
}