// Program: ConsoleInApp.fs
// Program F#

open System

Console.WriteLine "Pls input password:"
let s = Console.ReadLine()
if s = "888" then
    let a = Console.Read()
    Console.WriteLine a
else
    Console.WriteLine "Password wrong"
