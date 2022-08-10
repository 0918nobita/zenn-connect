const memory = new WebAssembly.Memory({ initial: 1, maximum: 1 });

WebAssembly.instantiateStreaming(fetch("store.wasm"), {
  imports: { memory },
}).then((module) => module.instance.exports.write_code());
