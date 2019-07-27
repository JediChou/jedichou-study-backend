// Ctrl + A；“交互執行”
// 快捷鍵為：Alt+Enter

let mutable sum = 0
for i in [0..100] do
    sum <- sum + i
printfn "1-100的自然数合计为: %A" sum