// program in scala, zh-cn, P72
// file name: checksum2.scala

class CheckSum {
    private var sum = 0
    def add(b: Byte): Unit = sum += b
    def checksum(): Int = ~(sum & 0xFF) + 1
}

val cs = new CheckSum
cs.add(3)
cs.add(4)
println(cs.checksum)