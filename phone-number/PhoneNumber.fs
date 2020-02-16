module PhoneNumber

open System

let clean input = 
  let number = input |> String.filter Char.IsDigit |> UInt64.TryParse
  match number with
  | (true, result) -> Ok result
  | _ -> Error "go figure"
