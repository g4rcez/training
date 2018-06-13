let sum (list) = list |> List.reduce((+))
let diff (list) = list |> List.reduce((-))
let pow (number:int):float = (float number) ** 2.0
let even (int: int) = int % 2 = 0
let odd (int: int) = not (even int)
let evenList (list) = list |> List.filter((even))
let oddList (list) = list |> List.filter((odd))
let powList list = list |> List.map((pow))

printfn "Sum: %A" (sum([1..10]))
printfn "Diff: %A" (diff([1..10]))
printfn "Even numbers: %A" (evenList [1..10])
printfn "Even numbers: %A" (oddList [1..10])
printfn "Pow numbers: %A" (powList [1..10])
