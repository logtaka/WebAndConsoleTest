# WebAndConsoleTest

.NET 8 向けのサンプルソリューションです。数値に 2 を足す処理を共通ライブラリとして実装し、コンソールアプリと Blazor WebAssembly アプリの両方から利用します。

## プロジェクト構成
- `AddTwoShared` … `MathService.AddTwo` を提供するクラスライブラリ。【AddTwoShared/MathService.cs†L1-L6】
- `AddTwoConsole` … コンソールで数値入力を受け取り、`MathService` で加算して表示するアプリ。【AddTwoConsole/Program.cs†L1-L17】
- `AddTwoBlazor` … ブラウザで数値を入力し、結果をその場で表示する Blazor WebAssembly アプリ。【AddTwoBlazor/Pages/Index.razor†L1-L20】

## 前提条件
- .NET 8 SDK がインストールされていること

## ビルド
リポジトリ直下でソリューション全体をビルドできます。

```bash
dotnet build AddTwoSample.sln
```

## 実行方法
### コンソールアプリ
```bash
dotnet run --project AddTwoConsole
```
- 数字を入力すると結果が表示されます。

### Blazor アプリ
開発サーバーを起動してブラウザで確認できます。
```bash
dotnet run --project AddTwoBlazor
```
- 起動後に表示される URL（既定では `http://localhost:5000` など）へアクセスし、入力欄に数字を入れて「計算」を押すと結果が更新されます。【AddTwoBlazor/Pages/Index.razor†L1-L20】

## 仕組み
両アプリは共通ライブラリ `AddTwoShared` を参照し、`MathService.AddTwo` で加算処理を共有しています。この構成により、ビジネスロジックを 1 か所にまとめたまま複数のフロントエンドから再利用できます。【AddTwoShared/MathService.cs†L1-L6】【AddTwoConsole/AddTwoConsole.csproj†L1-L11】【AddTwoBlazor/AddTwoBlazor.csproj†L1-L13】
