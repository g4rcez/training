module Calc

let sum (list) = list |> List.reduce((+))
let diff (list) = list |> List.reduce((-))
let pow (number:int):float = (float number) ** 2.0
let even (int: int) = int % 2 = 0
let odd (int: int) = not (even int)
let evenList (list) = list |> List.filter((even))
let oddList (list) = list |> List.filter((odd))
let powList list = list |> List.map((pow))

let list = [1..10]

printfn "Sum: %A" (sum(list))
printfn "Diff: %A" (diff(list))
printfn "Even numbers: %A" (evenList list)
printfn "Even numbers: %A" (oddList list)
printfn "Pow numbers: %A" (powList list)
