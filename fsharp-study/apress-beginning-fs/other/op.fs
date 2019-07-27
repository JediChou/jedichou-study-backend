open System.Diagnostics;;
let proc = Process.GetCurrentProcess()
printfn "current process: %s" proc.ProcessName
printfn "start time: %O" (proc.StartTime.ToLongTimeString())
printfn "memory: %i" proc.PrivateMemorySize64;;

