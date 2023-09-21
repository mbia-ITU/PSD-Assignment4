(* File Fun/ParseAndRun.fs *)

module ParseAndRun

let fromString = Parse.fromString;;

let eval = Fun.eval;;

let run e = eval e [];;

let runFile filename = 
    System.IO.File.ReadLines(filename) |> Seq.map (fromString) |> Seq.map run;;