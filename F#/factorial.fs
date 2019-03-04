module Factorial

let rec factorial (x : int) : int =
    if x < 1 then 1
    else x * factorial (x - 1)

let decide (x) =
    match x with
    | x when x % 2 = 0 -> x * x
    | _ -> x * x * x

let arrays (x) = x |> List.map (decide)

printfn "Factorial: %A" (arrays [ 1..10 ])
