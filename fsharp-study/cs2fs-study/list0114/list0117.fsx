// F# for C# developers, page 21
// Listing 1-17, Changing FSI's current folder

printfn "%s" System.Environment.CurrentDirectory;;
System.Environment.CurrentDirectory <- "c:\\MyCode";;
printfn "%s" System.Environment.CurrentDirectory;;