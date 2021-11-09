---
title: PureScript でプログラミング入門 第1章
emoji: 🎉 
type: tech
topics: ["purescript"]
published: false
---

## 対象読者

プログラミング経験があり、スキルを向上させたい人

## PureScript とは

JavaScript にコンパイルされる純粋関数型プログラミング言語です。

## 環境構築

### ① Node.js の導入

#### Windows の場合

#### macOS の場合

#### Linux の場合

### ② pnpm の導入

```bash
npm i -g pnpm
```

## プロジェクトの作成

まず、作業用ディレクトリを作成 (`mkdir`) してカレントディレクトリをそのなかに移動 (`cd`) し、git リポジトリとして設定してください。

```bash
mkdir purs1
cd purs1
git init
```

次に、`package.json` と `.gitignore` を作成してください。

```json:package.json
{
  "name": "purs1",
  "version": "0.1.0"
}
```

```text:.gitignore
node_modules
```

`pnpm add` コマンドを利用して、`purescript`, `spago` パッケージをインストールしてください。
この操作で、`package.json` の内容が更新され、`node_modules` ディレクトリと `pnpm-lock.yaml` が生成されます。

```bash
pnpm add -D purescript spago
```

```json:package.json (更新後)
{
  "name": "purs1",
  "version": "0.1.0",
  "devDependencies": {
    "purescript": "^0.14.5",
    "spago": "^0.20.3"
  }
}
```
