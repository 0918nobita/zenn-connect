---
title: 開発環境を構築しよう
free: true
---

Python の環境構築を進めていきます。

## pyenv の導入

Python ランタイムを管理してくれる pyenv を導入します。

## poetry の導入

Python のパッケージ管理で便利なツールである Poetry を導入します。

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

### wasmer の導入

WebAssembly のランタイムである wasmer を導入します。

```bash
poetry add wasmer
```
