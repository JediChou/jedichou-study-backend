//@file name: ch2-gp-SimpleMap.go
//@description: Create a simple map
//@author: Jedi Zhou <skyzhx@163.com>
//@copyright: 2014-4-10, Jedi Zhou

package ch2

import "fmt"

type PersonInfo struct {
	Id      string
	Name    string
	Address string
}

func main() {

	////////////////////////////////////////////////////
	// 申明: var myMap map[string] PersonInfo
	//  1. var 修饰符
	//  2. myMap 是变量名
	//  3. string 键类型
	//  4. PersonInfo 值类型
	////////////////////////////////////////////////////
	//  创建1: myMap = make(map[string] PersonInfo)
	//  创建2: myMap = make(map[string] PersonInfo, 100)
	////////////////////////////////////////////////////

	// Define a map
	var PersonDB map[string]PersonInfo
	PersonDB = make(map[string]PersonInfo)

	// Add some data to PersonDB
	PersonDB["1"] = PersonInfo{"88888", "Terry Guo", "C1"}
	PersonDB["12345"] = PersonInfo{"f3216338", "Jedi Zhou", "D13"}

	// Search and output
	person, ok := PersonDB["12345"]
	if ok {
		fmt.Println("工号：", person.Id, "名字：", person.Name)
	} else {
		fmt.Println("Man does not exists.")
	}

}
