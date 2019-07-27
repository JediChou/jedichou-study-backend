// ExceptionHandling.groovy
try {
	openFile("nonexistenfile")
} catch(FileNotFoundException ex) {
	// your process code
	println "Oops: " + ex
}
