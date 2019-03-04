module Strings

let name = "Mr. Catra"

let salute (fullName : string) =
    let first = fullName.Split(' ').[0]
    let names = fullName.Split(' ').[1..] |> Array.reduce (fun acc el -> acc + " " + el)
    match first with
    | "Mr." -> "Hey, Mister " + names
    | "Mrs." -> "Hey Miss " + names
    | _ -> "I don't know, but, hello " + names

printfn "%s" (salute name)