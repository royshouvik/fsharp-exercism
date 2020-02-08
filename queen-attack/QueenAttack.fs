module QueenAttack

let (|SameCol|SameRow|Diagonal|None|) (pos1, pos2) =
  let x1, y1 = pos1
  let x2, y2 = pos2
  if  x1 = x2 then
    SameCol
  elif y1 = y2 then
    SameRow
  elif abs (x1 - x2) = abs (y1 - y2) then
    Diagonal
  else
    None


let create (position: int * int) =
    let x, y = position
    x < 8 && x >= 0 && y < 8 && y >= 0

let canAttack (queen1: int * int) (queen2: int * int) =
    match queen1, queen2 with
    | SameCol | SameRow | Diagonal -> true
    | _ -> false
