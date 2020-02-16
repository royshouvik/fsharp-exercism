module PhoneNumber

open System

let clean input =
    let number = input |> String.filter Char.IsDigit
    // |> UInt64.TryParse
    let numberLength = String.length number
    let maybeNumber = UInt64.TryParse number
    match (maybeNumber, numberLength) with
    | (true, result), 10 -> Ok result
    | (true, result), 9 -> Error "incorrect number of digits"
    | _ -> Error "go figure"
