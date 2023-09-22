(* File Fun/ParseAndRun.fs *)

(* Added a runFile function to work with FunTests.ff by recursive rebels *)

module ParseAndRun

let fromString = Parse.fromString;;

let eval = Fun.eval;;

let run e = eval e [];;

let runFile filename = 
    System.IO.File.ReadAllText(filename).Split ";;" 
    |> Seq.ofArray 
    |> Seq.map (fromString) 
    |> Seq.map run;;