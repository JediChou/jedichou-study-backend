// package tests

/**
 * Calculate the Adler-32 checksum using Scala.
 * @see http://en.wikipedia.org/wiki/Adler-32
 */
object Adler32Checksum {
	val MOD_ADLER = 65521
	
	def main(args: Array[String]) {
		val sum=adler32sum("wikipedia")
		printf("checksum (int) = %d\n",sum)
		printf("checksum (hex) = %s\n",sum.toHexString)
	}
	
	def adler32sum(s: String): Int = {
		var a=1
		var b=0
		s.getBytes.foreach{char=>
			a=(char+a)%MOD_ADLER
			b=(b+a)%MOD_ADLER
		}
		// note: Int is 32 bits, which this requires
		b*65536+a
	}
}
