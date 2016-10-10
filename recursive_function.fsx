let rec length = function
    | [] -> 0
    | x::xs -> 1 + length xs
    
     
let rec factorial x = 
    if x < 2 then
        1
    else
        x * factorial (x - 1)
         