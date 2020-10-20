open System;

let main () =
    let ints = 
        [ 1 .. 10 ]
        |> List.map (fun i -> i * i)
        |> List.filter (fun i -> i > 5)

    printf "%s" (String.Join(Environment.NewLine, ints))

    printf "Total: %i" (ints |> Seq.sum)
    
main ()