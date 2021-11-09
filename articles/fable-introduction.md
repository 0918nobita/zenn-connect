---
title: JS / TS で疲弊している人に Fable (F#) をオススメする記事
emoji: 💙
type: tech
topics: ["javascript", "fsharp", "fable"]
published: false
---

## 対象読者

JavaScript / TypeScript で疲弊していて、もっと快適に Web フロントエンドを作りたいと思っている人を対象にしています。

## 要するに

Fable を導入すると、それまで JS / TS で頑張っていた部分が、代わりに最高なプログラミング言語 F# で簡潔に書けるようになり、幸せになれます。

## F# を知らない人へ

F# は**静的型付けのマルチパラダイム・プログラミング言語**です。マイクロソフトが中心となってオープンソースで開発されています。
.NET 仮想マシン上で動作し、既存の .NET クラスライブラリを利用できます。そのため、C# 等の .NET 言語と相互運用性があります。関数型・オブジェクト指向のどちらでも書ける柔軟性があります。
有名な開発・実行環境としては .NET 5 や Mono があります。

## Fable とは

F# プログラムは通常コンパイラ側で CIL (共通中間言語) に変換されたうえで動作します。それに対して Fable は、**CIL ではなく JavaScript に変換する**機能と、JavaScript に移植された標準ライブラリを提供しています。

## F# に軽く入門してみる

.NET 6 SDK をインストールしてください。

https://dotnet.microsoft.com/download/dotnet/6.0

以下のコマンドを実行して、F# の対話型実行環境 (以下、REPL) を起動します。

```bash
dotnet fsi
```
