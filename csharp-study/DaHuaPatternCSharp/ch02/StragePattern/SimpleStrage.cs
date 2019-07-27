
namespace DaHuaPatternCSharp.Ch2.SimpleStrage
{
    using System;
    
    abstract class Stragey
    {
        // Algorithms
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Stragey
    {
        // Implement algorithms A
        public override void AlgorithmInterface()
        {
            Console.WriteLine("Implement Algorithms A");
        }
    }
}