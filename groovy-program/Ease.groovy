// Ease.groovy
def foo(str) {
	// if (str != null ) { str.reverse() }
	str?.reverse() // focus this line
}

println foo('this is a test for foo')
println foo(null)
