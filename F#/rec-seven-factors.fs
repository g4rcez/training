module Seven

let findTotalMod (max: int) = 
    ([1..max] |> List.filter(fun x -> max % x = 0)).Length

let rec findNumberWithMod7 (n:int) = 
    if findTotalMod n = 7 then n
    else findNumberWithMod7(n + 1)

printfn "Result %A" (findNumberWithMod7 1)
