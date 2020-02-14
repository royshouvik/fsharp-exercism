﻿module DifferenceOfSquares

let square n = n * n

let squareOfSum (number: int): int =
    [ 1 .. number ]
    |> List.sum
    |> square

let sumOfSquares (number: int): int = [ 1 .. number ] |> List.sumBy square

let differenceOfSquares (number: int): int = squareOfSum number - sumOfSquares number
