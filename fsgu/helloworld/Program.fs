// For more information see https://aka.ms/fsharp-console-apps
open System

let sayHello person =
    printfn "Hello %s from my F# program" person

let isValid person =
    String.IsNullOrWhiteSpace person |> not

let isAllowed person =
    person <> "alice"

[<EntryPoint>]
let main argv =  
    
    // if then conditional
    // let person = 
    //     if argv.Length > 0 then
    //         argv.[0]
    //     else
    //         "Anonymous Person"
    // printfn "Hello %s from my F# program" person

    // indexed for loop
    // for i in 0..argv.Length-1 do
    //     let person = argv.[i]
    //     printfn "Hello %s from my f# program" person

    //iterator based for loop
    // for person in argv do
    //     printfn "Hello %s from my F# program" person

        //higher order function
        // Array.iter sayHello argv
        argv 
        |> Array.filter isValid 
        |> Array.filter isAllowed
        |> Array.iter sayHello
        printfn "Nice to meet you."
        0

