// ExceptionHandling2.groovy
try {
	openFile("NonExistentFile")
} catch (ex) {
	println "Oops: " + "some exception pop"
	println ex
}
