module QueenAttack

let create (position: int * int) = 
  let x, y = position
  x < 8 && x >= 0 && y < 8 && y >= 0

let canAttack (queen1: int * int) (queen2: int * int) = failwith "You need to implement this function."