import scala.collection.mutable.Map

object ChecksumAccumulator {
    
    private var sum = 0
    private val cache = Map[String, Int]()
    
    def add(b: Byte) { sum += b }
    def checksum(): Int = ~(sum &0xFF) + 1
    
    def calculate(s: String): Int =
        if (cache.contains(s))
            cache(s)
        else
        {
            // TODO can not create CheckSumlator instance
            val acc = ChecksumAccumulator
            for (c <- s)
                acc.add(c.toByte)
            val cs = acc.checksum
            cache += (s->cs)
            cs
        }
}