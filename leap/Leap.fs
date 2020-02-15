module Leap

let isDivisibleBy number year = year % number = 0
let isNotDivisibleBy number year = year % number <> 0

let leapYear (year: int): bool =
    (year |> isDivisibleBy 4 && year |> isNotDivisibleBy 100)
    || year |> isDivisibleBy 400
