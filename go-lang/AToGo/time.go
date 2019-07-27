// Listing 4.20, time.go
package main
import (
	"fmt"
	"time"
)

var week time.Duration

func main() {
	t := time.Now()
	fmt.Println("[001]", t)
	fmt.Printf("[002] %02d.%02d.%4d\n", t.Day(), t.Month(), t.Year())
	// 21.12.2011
	t = time.Now().UTC()
	fmt.Println("[003]", t)  // Wed Dec 21 08:52:14 +0000 UTC 2011
	fmt.Println("[004]", time.Now())  // Wed Dec 21 09:52:14 +0000 RST 2011
	
// calculating times:
	week = 60 * 60 * 24 * 7 * 1e9
	week_from_now := t.Add(week)
	fmt.Println("[005]", week_from_now)  // Wed Dec 28 08:52:14 +0000 UTC 2011

// formatting times:
	fmt.Println("[006]", t.Format(time.RFC822))  // 21 Dec 11 0852 UTC
	fmt.Println("[007]", t.Format(time.ANSIC))   // Wed Dec 21 08:56:34 2011
	fmt.Println("[008]", t.Format("02 Jan 2006 15:04"))  // 21 Dec 2011 08:52
	s := t.Format("2006-01-02")
	fmt.Println("[009]", t, "=>", s)
	    // Wed Dec 21 08:52:14 +0000 UTC 2011 => 20111221
}
