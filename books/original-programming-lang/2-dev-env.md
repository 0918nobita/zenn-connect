---
title: 開発環境を構築しよう
free: true
---

Python の環境構築を進めていきます。

## pyenv の導入

## poetry の導入

## プロジェクトの作成

### テンプレートの生成

```bash
poetry new mylang
cd mylang
```

### mypy の導入

型ヒントをもとにした静的型チェックをしてくれる mypy を導入します。

```bash
poetry add -D mypy
```

### wamser の導入

WebAssembly のランタイムである wasmer を導入します。

```bash
poetry add wasmer
```
