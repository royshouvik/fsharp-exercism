module QueenAttack

let (|SameCol|SameRow|Diagonal|None|) ((x1, y1), (x2, y2)) =
  if  x1 = x2 then
    SameCol
  elif y1 = y2 then
    SameRow
  elif abs (x1 - x2) = abs (y1 - y2) then
    Diagonal
  else
    None

let isWithinBounds x = x >= 0 && x < 8

let create (x, y) =
    isWithinBounds x && isWithinBounds y

let canAttack (queen1: int * int) (queen2: int * int) =
    match queen1, queen2 with
    | SameCol | SameRow | Diagonal -> true
    | _ -> false
