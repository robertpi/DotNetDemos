namespace Sqreen.DemoFSharpInterop

open System

module Numberz =
    let CreateAndFilter 
        start 
        ``end`` 
        (map: Func<int, int>) 
        (filter: Func<int, bool>) =

            let ints = 
                [start .. ``end``]
                |> List.map (fun i -> map.Invoke(i))
                |> List.filter (fun i -> filter.Invoke(i))

            ints