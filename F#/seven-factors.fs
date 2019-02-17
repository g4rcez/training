module Seven

let mutable hasMod7 = false
let mutable numberIterator = 0

let findTotalMod (max: int) = 
    let mutable factors = 0
    for quotient in [1..max] do
        if max % quotient = 0 then factors <- factors + 1
    factors

while not hasMod7 do
    let totalFactors = findTotalMod numberIterator
    if totalFactors = 7 then hasMod7 <- true
    else 
        numberIterator <- numberIterator + 1

printfn "Result %A" numberIterator
