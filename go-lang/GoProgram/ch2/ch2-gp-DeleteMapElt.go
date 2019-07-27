//@file name: ch2-gp-DeleteMapElt.go
//@description: Create a simple map
//@author: Jedi Zhou <skyzhx@163.com>
//@copyright: 2014-4-10, Jedi Zhou

package ch2

import "fmt"

type Employee struct {
	workid     string
	worklever  string
	department string
	master     string
}

func dispElt(container map[string]Employee) {
	for _, elt := range container {
		fmt.Print(elt.workid, ",", elt.worklever)
		fmt.Println(",", elt.department, ",", elt.master)
	}
}

func main() {

	// create a map
	var EmployeeContainer map[string]Employee
	EmployeeContainer = make(map[string]Employee)

	// Add elements
	EmployeeContainer["Jedi"] = Employee{"f3216338", "5", "SIDC", "Hong"}
	EmployeeContainer["Ray"] = Employee{"f3229871", "1", "SIDC", "BaoJun"}
	EmployeeContainer["Ed"] = Employee{"lanlanlan", "9", "SIDC", "YuChen"}

	// Before delete action
	fmt.Println("Before delete")
	dispElt(EmployeeContainer)

	// Delete and display again
	delete(EmployeeContainer, "Ed")
	fmt.Println("============")
	fmt.Println("After delete")
	dispElt(EmployeeContainer)
}
