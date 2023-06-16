// For more information see https://aka.ms/fsharp-console-apps

open System

let quote symbol s =
    sprintf "%c%s%c" symbol s symbol

let singleQuote = quote '''
let doubleQuote = quote '"'

[<EntryPoint>]
let main argv =
    printfn "%s" (singleQuote "It was the best of times.")
    printfn "%s" (doubleQuote "It was the worst of times")
    0
