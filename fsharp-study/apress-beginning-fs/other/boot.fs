open System.Diagnostics;;

let p1 = Process.Start("calc.exe");;
let p2 = Process.Start("Notepad.exe", "d:\\abc.txt");;

