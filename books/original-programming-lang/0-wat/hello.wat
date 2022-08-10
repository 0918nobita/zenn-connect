(module
    (import "imports" "print_str" (func $print_str (param i32) (param i32)))
    (import "imports" "memory" (memory 0))
    (data (i32.const 0) "Hello from WASM")
    (func (export "main") (call $print_str (i32.const 0) (i32.const 15))))
