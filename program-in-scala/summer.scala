// program in scala, zh-cn, P75
// file name: summer.scala

import scala.collection.mutable.Map

object ChecksumAccumulator {
    private var sum = 0
    private val cache = Map[String, Int]()
    
    def add(b: Byte) { sum += b }
    def checksum(): Int = ~(sum &0xFF) + 1
    
    def calculate(s: String): Int =
        if (cache.contains(s))
            cache(s)
        else {
            // TODO can not create ChecksumAccumulator instance
            val acc = new ChecksumAccumulator
            for (c <- s)
                acc.add(c.toByte)
            val cs = acc.checksum()
            cache += (s -> cs)
            cs
        }
}

object Summer {
    def main(args: Array[String]) {
        for (arg <- args)
            println(arg + ": " + ChecksumAccumulator.calculate(arg))
    }
}