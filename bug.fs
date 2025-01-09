let mutable x = 10
let mutable y = 20

let swap x y =
    let temp = x
    x <- y
    y <- temp

//Incorrect Swap
swap x y
printfn "%d %d" x y // Output: 20 20

//Correct Swap
let swapCorrect x y = 
    let temp = x
    x <- y
    y <- temp
    (x,y)

let (a,b) = swapCorrect x y
printfn "%d %d" a b // Output: 20 10