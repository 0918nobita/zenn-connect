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
