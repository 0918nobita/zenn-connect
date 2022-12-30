---
title: 年末に MVU と VDOM を実装してみた話
emoji: ⛄
type: tech
topics: ["typescript"]
published: false
---

## 対象読者

JavaScript / TypeScript の経験がある人

## 記事の構成

MVU / VDOM という概念について説明したあと、TypeScript で MVU フレームワークと VDOM ランタイムを実装し、それらを使って Web アプリを作ります。

## MVU について

MVU は「ボタンを押したら表示が切り替わる」「非同期通信が成功すると取得した内容を表示する」等、様々な状態遷移・副作用を扱う場合に有用なアーキテクチャです。

- **M**odel：プログラムがもつ単一の状態 (データ)
- **V**iew：Model を受け取って表示内容を返す関数
- Message：Model に影響を与える「操作」そのものを表すデータ
- **U**pdate：Model と Message を受け取って新しい Model を返す、状態遷移を表す関数

## VDOM について

## MVU と VDOM を実装する

## まとめ

## 参考文献
