// program in scala, zh-cn, P71
// file name: privateField.scala

class CheckAcc {
	private var sum = 0
}

val acc = new CheckAcc
acc.sum = 5  // will pop a error
