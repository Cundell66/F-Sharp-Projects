// For more information see https://aka.ms/fsharp-console-apps
open System

[<EntryPoint>]
let main argv =

    let total = 
        // Array.init 1000 (fun i -> 
        //     let x = i + 1
        //     x * x)
        // |> Array.sum
    
        // [|
        //     for i in 1..1000 -> i * i
        // |]
        // |> Array.sum
    
        seq { for i in 1..1000 -> i * i}
        |> Seq.sum

    printfn "%i" total

    0