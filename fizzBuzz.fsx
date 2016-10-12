let (|MultOf3|_|) i = if i % 3 = 0 then Some MultOf3 else None
let (|MultOf5|_|) i = if i % 5 = 0 then Some MultOf5 else None

let fuzzBizz n =
    match n with
    |MultOf3 & MultOf5 -> printf "FuzzBizz, "
    |MultOf3 -> printf "Fuzz, "
    |MultOf5 -> printf "Bizz, "
    |_ -> printf "%i, " n

[1..99] |> List.iter fuzzBizz