package main

import "fmt"

type Human struct {
	name  string
	age   int
	phone string
}

type Student struct {
	Human
	school string
	loan   float32
}

type Employee struct {
	Human
	company string
	money   float32
}

// Human implement SayHi method.
func (h Human) SayHi() {
	fmt.Printf("Hi, I am %s you can call me on %s\n", h.name, h.phone)
}

// Human implement Sing method.
func (h Human) Sing(lyrics string) {
	fmt.Println("La la la la ...", lyrics)
}

// Employee overload human's SayHi method.
func (e Employee) SayHi() {
	fmt.Printf("Hi, I am %s, I work at %s. Call me on %s\n", e.name, e.company, e.phone)
}

// Interface Men for Human/Student/Employee
type Men interface {
	SayHi()
	Sing(lyrics string)
}

func main() {
	mike := Student{Human{"Mike", 25, "222-222-xxx"}, "MIT", 0.00}
	paul := Student{Human{"Paul", 26, "111-222-xxx"}, "Harvard", 100}
	Sam := Employee{Human{"Sam", 36, "444-222-xxx"}, "Golang Inc.", 1000}
	Tom := Employee{Human{"Tom", 36, "444-222-xxx"}, "Things Ltd.", 5000}

	// Define a variable for Men type
	var i Men

	// Variable i storage Student
	i = mike
	fmt.Println("This is Mike, a Student:")
	i.SayHi()
	i.Sing("November rain")

	// Variable i storage Employee
	i = Tom
	fmt.Println("This is Tom, an Employee:")
	i.SayHi()
	i.Sing("Born to be wild")

	// Define a slice Men.
	fmt.Println("Let's use a slice of Men and see what happens")
	x := make([]Men, 3)
	x[0], x[1], x[2] = paul, Sam, mike

	for _, value := range x {
		value.SayHi()
	}

}
