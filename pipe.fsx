[1;2;3;4] 
    |> List.filter (fun x -> x % 2 = 0)
    |> List.map ((*)2)
    |> List.sum


sin <| 2. + 1.