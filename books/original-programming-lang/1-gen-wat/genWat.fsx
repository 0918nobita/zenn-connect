#load "sExpr.fsx"
#load "wat.fsx"

open SExpr
open Wat

List [ Atom "module" ]
|> SExpr.toString
|> printfn "%s"

let func =
    WatFunc(
        parameters = [ I32; I32 ],
        result = Some I32,
        body =
            [ GetLocal 0
              I32Const 3
              I32Add
              GetLocal 1
              I32Mul ]
    )

func
|> WatFunc.toSExpr
|> SExpr.toString
|> printfn "%s"
