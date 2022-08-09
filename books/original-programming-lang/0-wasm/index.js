const memory = new WebAssembly.Memory({ initial: 1, maximum: 1 });

WebAssembly.instantiateStreaming(fetch("hello.wasm"), {
  imports: {
    memory,
    print_str: (addr, len) =>
      console.log(
        String.fromCharCode.apply(
          null,
          new Uint8Array(memory.buffer.slice(addr, addr + len))
        )
      ),
  },
}).then((module) => module.instance.exports.main());
