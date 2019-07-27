open System.Diagnostics

let proc = Process.GetCurrentProcess()
printfn "Current: %s" proc.ProcessName
printfn "Starting time: %O" (proc.StartTime.ToLongTimeString())
printfn "Memory: %i" proc.PrivateMemorySize64
