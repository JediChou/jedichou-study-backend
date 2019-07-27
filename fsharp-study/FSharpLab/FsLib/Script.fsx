// 這是可以用 F# Interactive 執行的指令碼檔案。
// 它可以用來瀏覽和測試程式庫專案。
// 注意，指令碼檔案不是專案建置的一部分。

#load "Module1.fs"
open Module1

let t = Module1.getOne()
printfn "%d" t