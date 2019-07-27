// GroovyCar.groovy

// class define
class Car {
	def miles = 0
	final year
	Car(theYear) { year = theYear}
}

// create a car instance
Car car = new Car(2008)

// process
println "Year: $car.year"
println "Miles: $car.miles"
println "Setting miles"
car.miles = 25
println "Miles: $car.miles"
