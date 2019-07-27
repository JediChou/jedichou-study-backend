// File: fs-020202-2.fs

type FullName = { First: string; Last: string; }
type Specialty = { First: string; Last: string; }
let s: Specialty = { First = "Computer Science"; Last = "Program Language" }

printfn "[Master] %s -> [Branch] %s" s.First s.Last
