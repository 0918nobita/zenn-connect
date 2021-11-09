---
title: マクロプロセッサ「m4」で遊ぼう
emoji: 🤖
type: tech
topics: ["m4"]
published: false
---

## m4 とは

汎用マクロプロセッサです。

```text:hello.m4
define(`world', `m4')dnl
Hello, world!
```

```bash:shell
$ m4 hello.m4
Hello, m4!
```

## 環境構築

UNIX 系 OS には大体入っているらしいです。僕は ThinkPad X230 にインストールした Arch Linux x86_64 上で m4 を使っています。

## 基本的な使い方

m4 は、マクロ呼び出しを含まないテキストを入力として受けとると同じものを出力します。

```text:id.m4
hoge
```

```bash:shell
$ m4 id.m4
hoge
```

## マクロ展開のルールとクォート

## `changequote` クォートに用いる文字を変更する

デフォルトでは `` `' `` で挟むことでクォートができますが、この文字列のペアは `changequote` マクロで変更できます。

```text:quote.m4
define(`hello', `Hello,')dnl
changequote([, ])dnl
define([world], [m4])dnl
hello world!
```

```bash:shell
m4 quote.m4
Hello, m4!
```

以下、``changequote([, ])`` でクォートの文法を毎回 `[]` に変更していきます。

## マクロ定義の追加/上書き/削除

- `define`
- `pushdef`
- `popdef`
- `undefine`

## `ifelse` 条件分岐

## 再帰的に展開されるマクロ

## `esyscmd` 外部コマンドを実行し標準出力を展開する

- `sysval`
