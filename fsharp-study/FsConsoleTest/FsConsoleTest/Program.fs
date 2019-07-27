//////////////////////////////////////////
// Page38 
//let string1 = "This is my computer"
//let c1 = string1.[3]
//let string2 = "Apple"
//let string3 = string1 + " " + string2
//printfn "%s" string1
//printfn "%c" c1
//printfn "%s" string3

//////////////////////////////////////////
// Page39 - 2.2.1 元組
//let a = (1.0, 5.0)
//printfn "%O" a

//////////////////////////////////////////
// Page40 - 2.2.1 元組
//let maxmin a b c = 
//    if a > b then
//        if b > c then (a, c)
//        else if a >  c then (a, b)
//        else (c, b)
//    else
//        if b < c then (c, a)
//        else if a < c then (b, a)
//        else (b, c)
//
//let OutputMsg = 
//    let r = maxmin 2.0 5.0 4.0
//    printfn "%O" r
//    printfn "(MAX: %f, Min: %f)" (fst r) (snd r)
//
//OutputMsg

//////////////////////////////////////////
// Page41 - 2.2.2 記錄
//type FullName = {First: string; Last: string;}
//type Specialty = {First: string; Last: string;}
//let HowToUseRecord = 
//    let a = {First = "Brown"; Last = "Mike"}
//    let output = a.First + " " + a.Last
//    printfn "%s" output

//////////////////////////////////////////
// Page41 - 2.2.2 記錄
// Notice: 
//type FullName = { First: string; Last: string; }
//type 中文名稱 ={ First: string; Last: string; }
//let t = {First = "Brown"; Last = "Mike"}
//let t': 中文名稱 = { First = "周"; Last = "顥" }
//printfn "%O" t'.GetType

//////////////////////////////////////////
// Page41 - 2.2.2 記錄
// time: 2017.7.27 10:21
//type FullName = { First: string; Last: string; }
//type SpecialName = { First: string; Last: string; }
//
//let printEng (a: FullName) = printfn "%s %s" (a.First) (a.Last)
//let printChn (a: FullName) = printfn "%s.%s" (a.Last) (a.First)
//
//let book1 : FullName = { First = "軟件工程"; Last = "程序設計語言" }
//let book2 = { book1 with First = "編譯器" }
//let book3 : SpecialName = { First = "JavaEE"; Last = "新Java新語言" }
//
//printEng book1; printEng book2;
//printChn book1; printChn book2;


//////////////////////////////////////////
// Page41 - 2.2.3 聯合
//type Vechicle = | Car | Truck | Bus | Nothing
//let ProgramExecuteHere =
//    printfn "Pls select a vechile: [C]ar, [T]ruck, [B]us"
//    let ch = System.Console.ReadLine().[0]
//    let v =
//        if ch = 'c' then Car
//        else if ch = 't' then Truck
//        else if ch = 'b' then Bus
//        else Nothing
//    if v = Car then printfn "You select Car"
//        else if v = Truck then printfn "You select Truck"
//        else if v = Bus then printfn "You select Bus"
//        else printfn "Aha! Without this opition"
//ProgramExecuteHere

//////////////////////////////////////////
// Page41 - 2.2.3 聯合
//type Vehicle = 
//    | Car of int
//    | Truck of int
//    | Bus of int
//let v1 = Car 6
//let v2 = Bus 20
//printfn "Car value is: %O" v1.ToString
//printfn "Bus value is: %O" v2.ToString

//////////////////////////////////////////
// Page42 - 2.2.3 聯合
// Jedi: 2017.7.27, How to get value of object property
//type Street = { Area: string; StreetName: string; Num: int; }
//type School = { Name: string; Department: string; }
//type Address = 
//    | Common of string
//    | Street of string * string * int
//    | School of School
//let addr1 = Common("common")
//let addr2 = Street("ChaoYang Area", "JianWai Street", 31)
//let addr3 = School({Name="BeiJing University"; Department="Math"})
//printfn "addr1 toString(): %O" addr1
//printfn "addr2 toString(): %O" addr2
//printfn "addr3 toString(): %O" addr3


//////////////////////////////////////////
// Page42 - 2.2.3 聯合
// Jedi: Use Chinese to write again
//type 街道 = { 區: string; 街道名: string; 門牌號碼: int; }
//type 學校 = { 學校名: string; 部門: string; }
//type Address = 
//    | S組織 of string
//    | S街道 of string * string * int
//    | S學校 of 學校
//let 地址1 = S組織 "高等學府"
//let 地址2 = S街道 ("朝陽區", "建外大街", 31)
//let 地址3 = S學校 ({學校名="北京大學"; 部門="數學系"})
//printfn "addr1 toString(): %O" 地址1
//printfn "addr2 toString(): %O" 地址2
//printfn "addr3 toString(): %O" 地址3


//////////////////////////////////////////
// Page42 - 2.2.3 聯合
// Jedi: 2017.7.27, 循環引用
// Code Snippet 1
//type 路由 =
//    | S方向 of (string * string)
//    | S轉向 of (string * 路由)
//let r1 = S方向("北京", "廈門")
//let r2 = S轉向("上海", r1)
// Code Snippet 2
//type Route =
//    | Direct of (string * string)
//    | Transfer of (string * Route)
//let r1 = Direct("BeiJing", "XiaMen")
//let r2 = Transfer("ShangHai", r1)

//////////////////////////////////////////
// Page43 - 2.3.1 可變類型
//let mutable x = 5
//x <- 15
//printfn "%d" x

//////////////////////////////////////////
// Page43 - 2.3.1 可變類型 - 類型必須一致
//let mutable x = 5
//x <- "14"
//printfn "%d" x

//////////////////////////////////////////
// Page43 - 2.3.1 可變類型 - 使用元組寫法賦值
//let mutable x1, x2 = 1, -1
//printfn "x1=%d, x2=%d" x1 x2

//////////////////////////////////////////
// Page43 - 2.3.1 可變類型 - 默認情況記錄中的字典也不可變
// Compile Error Message: 這個欄位不是可變動的欄位
//type Socre = {
//    Math: int;
//    Phys: int;
//    Chem: int
//}
//let s:Socre = { Math=90; Phys=92; Chem=80 }
//printfn "%d" s.Math
//s.Math <- 100;

//////////////////////////////////////////
// Page43 - 2.3.1 可變類型 - 修改成mutable則可變
//type Socre = {
//    mutable Math: int;
//    mutable Phys: int;
//    mutable Chem: int
//}
//let s:Socre = { Math=90; Phys=92; Chem=80 }
//s.Math <- 100;
//printfn "%d" s.Math


//////////////////////////////////////////
// Page44 - 2.3.2 引用類型
// Jedi: 可否簡單的理解ref類型就是指針（應該不完全是）
//let y = ref 2.25
//printfn "%f" !y
//printfn "%O" y

//////////////////////////////////////////
// Page44 - 2.3.2 引用類型
// Jedi: 使用引用類型來更改值
//let y1 = ref "Jedi Chou"
//let y2 = ref "Becky"
//let y3 = ref "temp"
//y1 := !y2
//printfn "%s" !y1

//////////////////////////////////////////
// Page44 - 2.3.2 引用類型
//let y', y'' = ref 0, ref 0
//let x', x'' = (10, 6)
//let z', z'' := (10, 6) // 編譯錯誤

//////////////////////////////////////////
// Page44 - 2.3.2 引用類型
// Jedi: 2017.7.27 - 不使用引用類型時的狀況
//let mutable x1 = "old value"
//let mutable x2 = x1
//x1 <- "new value"
//printfn "x1: [%s]" x1
//printfn "x2: [%s]" x2

//////////////////////////////////////////
// Page44 - 2.3.2 引用類型
// Jedi: 2017.7.27 - 使用引用類型時的狀況
// Jedi: 2017.7.27 - 使用該特性可以用作別名
// Jedi: 2017.7.27 - 可是用此特性實現很多數據結構
//let y1 = ref "old value"
//let y2 = y1
//y1 := "new value"
//printfn "y1: [%s]" !y1
//printfn "y2: [%s]" !y2

//////////////////////////////////////////
// Page45 - 2.4 可選類型
//let mutable x = Some(50)
//let mutable y = Some("Jedi Chou")
//
//x <- Some(40)
//printfn "%d" x.Value
//printfn "%s" y.Value
//
//x <- None
//if x.IsNone then
//    printfn "Wrong!"
//    else printfn "%d" x.Value  // Compile success, runtime error

//////////////////////////////////////////
// Page46 - 2.4 可選類型
//let x', x'' = Some(8), Some(12)
//if (x'.IsSome && x''.IsSome) then
//    printfn "%i" (x'.Value + x''.Value)
//    else printfn "Wrong formula"

//////////////////////////////////////////
// Page48 - 3.1.1 函數定義
//let f1 = fun x -> x * x - 2 * x
//let f2 x =
//    let x' = x - 2
//    x * x'
//let g1 = fun x y -> x*(x+1) + y*(y-1)
//let g2 = fun x y z -> 1.0 + x*x + y*y + z*z
//printfn "%d" (f1 20)
//printfn "%d" (f2 20)
//printfn "%d" (g1 1 2)
//printfn "%f" (g2 3.0 4.0 5.0)

//////////////////////////////////////////
// Page48 - 3.1.2 形參和實參
//let mutable a, b = 6, 9
//let vChange x y =
//    let t = x
//    let x = x + y
//    let y = y - t
//    (x, y)
//let z1 = (vChange a b)
//printfn "%O" z1.GetHashCode
//printfn "%d" (fst z1)
//printfn "%d" (snd z1)

//////////////////////////////////////////
// Page49 - 3.1.2 形參和實參
// Jedi - 改變外部的傳參數，類似C#的REF
// Jedi - 在模板的使用上可能大量使用
//let a1, b1 = ref 6, ref 9
//let rChange ref x y =
//    let t = !x
//    x := !x + !y
//    y := !y - t
//    (x, y)
//let z2 = (rChange ref a1 b1)
//printfn "%O" z2
//printfn "old value: %d, return a1: %d" !a1 (fst z2).Value
//printfn "old value: %d, return b1: %d" !b1 (snd z2).Value

//////////////////////////////////////////
// Page49 - 3.1.3 空參數和空返回值
//let getsec = fun() ->
//    let now = System.DateTime.Now
//    now.Second
//let sec = getsec()  // 注意這裡要有括號
//printfn "current sec: %d" sec

//////////////////////////////////////////
// Page50 - 3.1.3 空參數和空返回值
// Jedi- 上面例子的簡單擴展
//let getsec = fun() ->
//    let now = System.DateTime.Now
//    let year = now.Year
//    let month = now.Month
//    let day = now.Day
//    let hh = now.Hour
//    let mm = now.Minute
//    let ss = now.Second
//    printfn "Date is: %d-%d-%d %d:%d:%d" year month day hh mm ss
//getsec()

//////////////////////////////////////////
// Page51 - 3.1.4 局部變量和全局變量
//let mutable z = 100
//let h1 x y =
//    let mutable z = x * y
//    z <- z-1
//    printfn "(local)z = %i" z
//    z * z
//printfn "%d" z
//printfn "h1(3,7) = %i" (h1 3 7)

