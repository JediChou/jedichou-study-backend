package main

type Integer int

func (a Integer) Less(b Integer) bool {
	return a < b
}

func (a Integer) Bigger(b Integer) bool {
	return a > b
}
