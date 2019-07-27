// program in scala, zh-cn, P72
// file name: checksum3.scala

class CheckSum {
    private var sum = 0
    def add(b: Byte) { sum += b }  // Notice!
    def checksum(): Int = ~(sum & 0xFF) + 1
}

val cs = new CheckSum
cs.add(3)
cs.add(4)
println(cs.checksum)