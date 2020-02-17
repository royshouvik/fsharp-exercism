module PhoneNumber

open System

let head (input: UInt64) =
    (string input)
    |> Seq.head
    |> string
    |> UInt64.Parse

let tail (input: UInt64) =
    let inputTail = (string input) |> Seq.tail
    String.Join("", inputTail) |> UInt64.Parse

let clean input =
    let number = input |> String.filter Char.IsDigit
    let numberLength = String.length number
    let maybeNumber = UInt64.TryParse number
    match (maybeNumber, numberLength) with
    | (true, _), 9 -> Error "incorrect number of digits"
    | (true, result), 10 -> Ok result
    | (true, result), 11 when head result = 1UL -> Ok(tail result)
    | (true, result), 11 when head result <> 1UL -> Error "11 digits must start with 1"
    | _ -> Error "go figure"
