module ThousandProds

let ref = 13
let mutable bigNumber:int = 0
let mutable pos:int = 0

let mutable product = 0
while pos + ref < 1000 do
  let endNumber = pos + ref - 1
  product <- [pos..endNumber] |> List.reduce((+))
  if product > bigNumber then bigNumber <- product
  pos <- pos + 1

printfn "Total: %A" product