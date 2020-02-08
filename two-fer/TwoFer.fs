module TwoFer

let twoFer =
    function
    | None -> sprintf "One for you, one for me."
    | Some input -> sprintf "One for %s, one for me." input
