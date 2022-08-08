# DaprCronBinding

* Daprの入力バインディング（cron）を利用したサンプルプログラム

## スケジュールの変更

* Cronのスケジュールの定義は「dapr/components/action.yaml」で行っている

``` yaml
apiVersion: dapr.io/v1alpha1
kind: Component
metadata:
  name: action
  namespace: default
spec:
  type: bindings.cron
  version: v1
  metadata:
  - name: schedule
    value: "@every 5m"
```

* 上記の例では、Daprにより5分ごとに`/action`エンドポイントが呼び出される

* スケジュールの値の指定方法は[こちら](https://docs.dapr.io/reference/components-reference/supported-bindings/cron/)を参照

## 実行

* Daprの実行コマンドで起動する

``` bash
dapr run --app-id cronservice --app-port 6000 --dapr-http-port 3600 --dapr-grpc-port 60000 --components-path ../dapr/components dotnet run
```

* 設定したスケジュール通りにエンドポイントが呼び出されることを確認する