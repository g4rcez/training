module Sum
printfn "Add all multiples of 5, from 0 to 1000 => ShellterLabs Challenge"
let sum = [ 0..5..1000 ] |> List.reduce (( + ))
printfn "Result: %A" sum
