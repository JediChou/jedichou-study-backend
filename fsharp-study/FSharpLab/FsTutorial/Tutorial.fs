
// F# 教學課程檔案
//
// 這個檔案包含程式碼範例，可逐步引導您
// 了解 F# 語言的基本型別。
//
// 請參閱 http://fsharp.net，進一步了解 F#
// 
// 如需更大的 F# 範例集合，請參閱:
//     http://go.microsoft.com/fwlink/?LinkID=124614
//
// 內容:
//   - 簡單計算
//   - 整數的函式
//   - Tuple
//   - 布林值
//   - 字串
//   - 清單
//   - 陣列
//   - 更多集合
//   - 函式
//   - 型別: 等位
//   - 型別: 記錄
//   - 型別: 類別
//   - 型別: 介面
//   - 型別: 含介面實作的類別
//   - 列印

// 開啟一些標準命名空間
open System

// 簡單計算
// ---------------------------------------------------------------
// 這裡是一些簡單的計算。請注意程式碼用
// '///' 加註註解的方式。將游標置於任何變數參考上方
// 就可以查看說明文件。

/// 非常簡單的常數整數
let int1 = 1

/// 第二個非常簡單的常數整數
let int2 = 2

/// 兩個整數相加
let int3 = int1 + int2

// 整數的函式
// ---------------------------------------------------------------

/// 整數的函式
let f x = 2*x*x - 5*x + 3

/// 簡單計算的結果
let result = f (int3 + 4)

/// 另一個整數的函式
let increment x = x + 1

/// 計算整數的階乘
let rec factorial n = if n=0 then 1 else n * factorial (n-1)

/// 計算兩個整數的最大公因數
let rec hcf a b =                       // 注意: 2 個參數以空格分隔
    if a=0 then b
    elif a<b then hcf a (b-a)           // 注意: 2 個引數以空格分隔
    else hcf (a-b) b
    // 注意: 函式引數通常是以空格分隔
    // 注意: 'let rec' 會定義遞迴函式

      
// Tuple
// ---------------------------------------------------------------

// 簡單的整數 Tuple
let pointA = (1, 2, 3)

// 簡單的整數、字串和雙精確度浮點數的 Tuple
let dataB = (1, "fred", 3.1415)

/// 將 Tuple 中兩個值的順序互換的函式
let Swap (a, b) = (b, a)

// 布林值
// ---------------------------------------------------------------

/// 簡單的布林值
let boolean1 = true

/// 第二個簡單的布林值
let boolean2 = false

/// 使用 And、Or 和 Not 計算新的布林值
let boolean3 = not boolean1 && (boolean2 || false)

// 字串
// ---------------------------------------------------------------

/// 簡單的字串
let stringA  = "Hello"

/// 第二個簡單的字串
let stringB  = "world"

/// 使用字串串連計算 "Hello world"
let stringC  = stringA + " " + stringB

/// 使用 .NET 程式庫函式計算 "Hello world"
let stringD = String.Join(" ",[| stringA; stringB |])
  // 嘗試重新輸入上一行，以查看 IntelliSense 的作用
  // 注意，在識別項上使用 Ctrl-J (部分) 會重新啟動該識別項

// 功能清單
// ---------------------------------------------------------------

/// 空白清單
let listA = [ ]           

/// 有 3 個整數的清單
let listB = [ 1; 2; 3 ]     

/// 有 3 個整數的清單，注意 :: 是指 'cons' 作業
let listC = 1 :: [2; 3]    

/// 使用遞迴函式計算整數清單的總和
let rec SumList xs =
    match xs with
    | []    -> 0
    | y::ys -> y + SumList ys

/// 清單的總和
let listD = SumList [1; 2; 3]  

/// 介於 1 到 10 (含) 之間的整數清單
let oneToTen = [1..10]

/// 前 10 個整數的平方
let squaresOfOneToTen = [ for x in 0..10 -> x*x ]


// 可變動的陣列
// ---------------------------------------------------------------

/// 建立陣列
let arr = Array.create 4 "hello"
arr.[1] <- "world"
arr.[3] <- "don"

/// 使用陣列物件的執行個體方法，計算陣列的長度
let arrLength = arr.Length        

// 使用切割標記法擷取子陣列
let front = arr.[0..2]


// 更多集合
// ---------------------------------------------------------------

/// 內含整數索引鍵和字串值的字典
let lookupTable = dict [ (1, "One"); (2, "Two") ]

let oneString = lookupTable.[1]

// 如需其他通用資料結構，請參閱:
//   System.Collections.Generic
//   Microsoft.FSharp.Collections
//   Microsoft.FSharp.Collections.Seq
//   Microsoft.FSharp.Collections.Set
//   Microsoft.FSharp.Collections.Map

// 函式
// ---------------------------------------------------------------

/// 計算輸入值之平方的函式
let Square x = x*x              

// 在值清單之間對應函式
let squares1 = List.map Square [1; 2; 3; 4]
let squares2 = List.map (fun x -> x*x) [1; 2; 3; 4]

// 管線
let squares3 = [1; 2; 3; 4] |> List.map (fun x -> x*x) 
let SumOfSquaresUpTo n = 
  [1..n] 
  |> List.map Square 
  |> List.sum

// 型別: 等位
// ---------------------------------------------------------------

type Expr = 
  | Num of int
  | Add of Expr * Expr
  | Mul of Expr * Expr
  | Var of string
  
let rec Evaluate (env:Map<string,int>) exp = 
    match exp with
    | Num n -> n
    | Add (x,y) -> Evaluate env x + Evaluate env y
    | Mul (x,y) -> Evaluate env x * Evaluate env y
    | Var id    -> env.[id]
  
let envA = Map.ofList [ "a",1 ;
                        "b",2 ;
                        "c",3 ]
             
let expT1 = Add(Var "a",Mul(Num 2,Var "b"))
let resT1 = Evaluate envA expT1


// 型別: 記錄
// ---------------------------------------------------------------

type Card = { Name  : string;
              Phone : string;
              Ok    : bool }
              
let cardA = { Name = "Alf" ; Phone = "(206) 555-0157" ; Ok = false }
let cardB = { cardA with Phone = "(206) 555-0112"; Ok = true }
let ShowCard c = 
  c.Name + " Phone: " + c.Phone + (if not c.Ok then " (unchecked)" else "")


// 型別: 類別
// ---------------------------------------------------------------

/// 二維向量
type Vector2D(dx:float, dy:float) = 
    // 向量預先計算的長度
    let length = sqrt(dx*dx + dy*dy)
    /// 在 X 軸上的位移
    member v.DX = dx
    /// 在 Y 軸上的位移
    member v.DY = dy
    /// 向量的長度
    member v.Length = length
    // 依照一個常數重新調整向量
    member v.Scale(k) = Vector2D(k*dx, k*dy)
    

// 型別: 介面
// ---------------------------------------------------------------

type IPeekPoke = 
    abstract Peek: unit -> int
    abstract Poke: int -> unit

              
// 型別: 含介面實作的類別
// ---------------------------------------------------------------

/// 計算自身被查詢次數的 Widget
type Widget(initialState:int) = 
    /// Widget 的內部狀態
    let mutable state = initialState

    // 實作 IPeekPoke 介面
    interface IPeekPoke with 
        member x.Poke(n) = state <- state + n
        member x.Peek() = state 
        
    /// Widget 被查詢過嗎?
    member x.HasBeenPoked = (state <> 0)


let widget = Widget(12) :> IPeekPoke

widget.Poke(4)
let peekResult = widget.Peek()

              
// 列印
// ---------------------------------------------------------------

// 列印整數
printfn "peekResult = %d" peekResult 

// 使用 %A 列印結果以進行一般列印
printfn "listC = %A" listC
