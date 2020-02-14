module TwoFer


let twoFer input =
    input
    |> Option.defaultValue "you"
    |> sprintf "One for %s, one for me." // I could not figure out how to avoid using sprintf :(
