namespace SMAFS

type public SMAFS =
    static member sma (sma : double array) (c : double array) (period : int) (total : int) (prev : int) : int =
        if 0 < period && period <= total
        then Array.windowed period c
        else [|[||]|]

        let a = [|0.0; 1.0; 2.0; 3.0; 4.0; 5.0; 6.0; 7.0; 8.0; 9.0|]
        Array.windowed 3 a
        |> Array.map Array.average
        |> Array.append (Array.zeroCreate 2)
        |> let result =

        let it : double array = Array.zeroCreate 2

        Array.average [|0.0; 1.0; 2.0|]
        let empty : int array = [||]
        Array.sub a 0 3
        (fun x -> x + 1) 1

        let x0 = [|0; 1; 2; 3; 4|]
        let x1 = Array.copy x0
        x1.[1] <- 5
        let result0 = x0
        let result1 = x1

        let plusOne x = x + 1
        let twice x = x * x
        let result = 100 |> plusOne |> twice

        let b = [|0.0; 1.0; 2.0; 3.0; 4.0; 5.0; 6.0; 7.0; 8.0; 9.0|]
        let result =
            b
            |> Array.windowed 3
            |> Array.map Array.average
            |> Array.append (Array.zeroCreate 2)
        
        let arr = [||]
        arr <- result

        0
