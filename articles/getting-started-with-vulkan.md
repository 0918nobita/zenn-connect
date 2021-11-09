---
title: 全くの 3DCG 初心者が Rust で Vulkan に入門した話
emoji: 🖌️
type: tech
topics: ["rust", "glsl", "vulkan", "cg"]
published: false
---

## 前提知識

Rust の基本的な言語機能等の説明はしません。Rust の公式チュートリアルを完走しているくらいの習熟度を想定しています。

## はじめに

僕は普段 TypeScript で Web アプリを開発したり、関数型プログラミング言語で遊んだりしている人です。ネイティブの GUI アプリケーションの開発や 3D グラフィックス API の利用については全くの初心者です。この記事では、そんな僕が Rust を使って Vulkan に入門して、ウィンドウに三角形を描画することに成功するまでの道筋や考えたことをまとめてみました。

## Vulkan SDK のインストール

## Cargo パッケージの作成

```bash
cargo new hello-triangle
cd hello-triangle
```

## `ash`, `glfw-rs` クレートの導入

```toml:Cargo.toml
...
[dependencies]
ash = "0.32"

[dependencies.glfw]
git = "https://github.com/bjz/glfw-rs.git"
features = ["vulkan"]
...
```

## Vulkan インスタンスの作成

## ウィンドウに画像を送る準備

### ウィンドウサーフェス

### スワップチェーン

### フレームバッファ
