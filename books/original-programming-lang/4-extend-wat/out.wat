(module
    (memory 1)
    (func $add-and-write (param $addr i32) (param $x i32) (param $y i32)
        (local $sum i32)
        (local.set $sum (i32.add (local.get $x) (local.get $y)))
        (i32.store (local.get $addr) (local.get $sum))))
