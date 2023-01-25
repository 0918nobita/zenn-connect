---
title: Renovate で密接に関係する依存パッケージ群を更新する
emoji: 📦
type: tech
topics: ["renovate"]
published: true
---

## Renovate について

GitHub リポジトリで Renovate による依存パッケージの更新を設定すると、新バージョンがリリースされるごとに更新を適用するプルリクエストが自動生成されてとても便利です。Node.js で開発するときに利用する npm パッケージをはじめ、Rust のクレート、さらには Docker イメージの更新にも対応しています。

## 密接に関係するパッケージ群を扱う際の問題

業務でも個人開発でも依存パッケージの更新作業を効率化してくれる Renovate ですが、デフォルトの設定では問題が生じることもあります。
本記事では、**直接依存している複数のパッケージ同士が密接に関係しており、どれか１つを先に更新してしまうと型エラーや実行時エラーを引き起こす**という問題への対処方法を紹介します。

### 実例

よくある例としては、React, TypeScript を用いた Web フロントエンド開発において

- `@types/react`[^1]：React のコアの型定義を提供するもの
- `@types/react-dom`[^2]：ブラウザ上のレンダリングに関する型定義を提供するもの

を別々に Renovate に更新させると、どちらも CI 上の自動ビルド用ジョブで型エラーが発生してしまう、というものがあります。

ちなみに今回僕が遭遇した問題は、Rust でサーバーサイドを開発している自分のブログに記事の全文検索機能を実装した後に、依存している

- `tantivy`[^3]：全文検索エンジン Tantivy
- `lindera-tantivy`[^4]：Tantivy と連携するトークナイザ (日本語対応の形態素解析ライブラリ Lindera を利用)

を別々に更新させるとどちらのプルリクエストの CI でもビルドが通らない、というものでした。

![それぞれのCIが落ちている様子](/images/renovate-update-same-time.png)

## 対処方法

このような問題が発生することが予想されるパッケージ群に関しては、特別にまとめて更新するプルリクエストを生成するように Renovate の挙動をカスタマイズできます。実際にはプロジェクトルートに配置した `renovate.json` でそのための設定を記述します。

```json:renovate.json
{
    "extends": ["config:base"],
    "packageRules": [
        {
            "groupName": "Search Engine",
            "matchManagers": ["cargo"],
            "matchPackageNames": ["tantivy", "lindera-tantivy"]
        }
    ]
}
```

`packageRules` 配列に要素を追加し、

- グループ名は `Search Engine`
- 対象のパッケージマネージャは `cargo` (Rust 用)
- グループに含めるパッケージの名前は `tantivy` と `lindera-tantivy`

のように指定し、保存して commit したうえで、デフォルトブランチに push します。

すると要求通りに↓のようなプルリクエストが生成され、別々に生成されていた過去のプルリクエストは自動的にクローズされます。

![グループ化されたプルリクエスト](/images/renovate-pr.png)

## 参考にした Web ページ

[Configuration Options - Renovate Docs](https://docs.renovatebot.com/configuration-options/#groupname)

[^1]: [@types/react - npm](https://www.npmjs.com/package/@types/react)
[^2]: [@types/react-dom - npm](https://www.npmjs.com/package/@types/react-dom)
[^3]: [tantivy - crates.io: Rust Package Registry](https://crates.io/crates/tantivy)
[^4]: [lindera-tantivy - crates.io: Rust Package Registry](https://crates.io/crates/lindera-tantivy)
