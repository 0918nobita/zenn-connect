type WatPrimType = I32

type WatFuncIndex = WatFuncIndex of int

type WatInst =
    | I32Const of int
    | Call of WatFuncIndex

type WatFunc = WatFunc of parameters: list<WatPrimType> * result: WatPrimType * body: list<WatInst>

let mainFunc =
    WatFunc(
        parameters = [],
        result = I32,
        body =
            [ I32Const 0
              I32Const 15
              Call(WatFuncIndex 0) ]
    )
