def getSign(x: Int) = if (x > 0) 1 else { if (x == 0) 0 else -1 }

println( "getSign(1) = " + getSign(1) )
println( "getSign(0) = " + getSign(0) )
println( "getSign(-1) = " + getSign(-1) )
