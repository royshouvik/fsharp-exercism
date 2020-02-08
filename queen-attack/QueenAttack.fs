module QueenAttack

let create (position: int * int) =
    let x, y = position
    x < 8 && x >= 0 && y < 8 && y >= 0

let canAttack (queen1: int * int) (queen2: int * int) =
    match queen1, queen2 with
    | (x1, y1), (x2, y2) when x1 = x2 || y1 = y2 -> true // same column or same row
    | _ -> false
