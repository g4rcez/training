module CaesarCipher

let shifter (str:string, shift:int)  =
    let inline flipzip a b = b, a
    str
    |> String.map (fun charAt ->
        charAt
        |> int
        |> flipzip (int 'A')
        ||> (-)
        |> (+) shift
        |> flipzip 26
        ||> (%)
        |> (+) (int 'A')
        |> char)

let encode (str:string, shift:int) = shifter(str, shift)
let decode (str:string, shift:int) = shifter(str, 26 - shift)


printfn "%s" (encode("ABC", 3))
printfn "%s" (decode(encode("ABC", 3), 3))