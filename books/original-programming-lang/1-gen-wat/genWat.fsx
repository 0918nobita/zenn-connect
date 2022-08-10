type SExpr =
    | Atom of string
    | List of list<SExpr>

module SExpr =
    let rec toString =
        function
        | Atom str -> str
        | List list ->
            list
            |> List.map toString
            |> String.concat " "
            |> sprintf "(%s)"

List [ Atom "module" ]
|> SExpr.toString
|> printfn "%s"

type WatPrimType = I32

module WatPrimType =
    let toString =
        function
        | I32 -> "i32"

type WatInst =
    | I32Const of value: int
    | I32Add
    | I32Mul
    | GetLocal of index: int
    | Call of index: int

type WatFunc = WatFunc of parameters: list<WatPrimType> * result: option<WatPrimType> * body: list<WatInst>

module WatFunc =
    let toSExpr (WatFunc (parameters, result, _body)) =
        let parameters =
            parameters
            |> List.map (fun ty ->
                List [ Atom "param"
                       Atom(WatPrimType.toString ty) ])

        let result =
            result
            |> Option.map (fun ty ->
                [ List [ Atom "result"
                         Atom(WatPrimType.toString ty) ] ])
            |> Option.defaultValue []

        // TODO: body も SExpr に変換する

        List(Atom "func" :: parameters @ result)

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

type WatReprMember = WatReprFunc of WatFunc

type WatRepr = WatRepr of list<WatReprMember>

// TODO: WatRepr -> SExpr
