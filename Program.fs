open System

let sayHello person=
    printfn "Hello %s from F#" person

let isValid person=
    not(String.IsNullOrWhiteSpace(person))  

let isAllowed person=
    person<>"Eve"
    

// For more information see https://aka.ms/fsharp-console-apps
[<EntryPoint>]
let main argv =
    argv
    |>Array.filter isValid
    |>Array.filter isAllowed
    |>Array.iter sayHello        
    printfn "nice to meet you"
    0