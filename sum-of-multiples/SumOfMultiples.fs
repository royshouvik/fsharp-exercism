module SumOfMultiples

let isMultipleOf num =
    List.exists (fun n ->
        if n <> 0 then num % n = 0 else false)

let sum (numbers: int list) (upperBound: int): int =
    [ for n in 1 .. upperBound - 1 do
        if isMultipleOf n numbers then yield n ]
    |> List.sum
