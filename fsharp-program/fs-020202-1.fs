// File: fs-020202-1.fs

type FullName = { First: string; Last: string; }
let a = { First = "Brown"; Last = "Mike" }
printfn "%s.%s" a.First a.Last
