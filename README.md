# ClickOnceTest
ClickOnceのテスト

# ClickOnceのトラブル

* ビルド時、署名に失敗したときの対応  
「パス C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\bin\signtool.exe で ignTool.exe が見つかりませんでした。」  
→ VisualStudioの変更から「Windows 開発 と Web 開発」-「ClickOnce Publishing Tools」をインストールする。
* ClickOnceのインストール時にエラー  
「配置内の参照が、アプリケーション マニフェスト内で定義された ID と一致していません。」  
→ マニュフェスト内ID(アセンブリのID(アセンブリの名前、バージョン、カルチャおよび公開キー トークン）)とClickOnceの「説明」情報が不一致だった。  
[ClickOnce 配置の固有のエラーのトラブルシューティング](https://msdn.microsoft.com/ja-jp/library/ms229001.aspx)
* 「ファイル ～.exe.config は、マニフェストで指定されているものとは異なる処理されたハッシュを持っています。」  
→ 「.gitattributes」に下記を追加  
    ```
     *.application   binary
     *.deploy        binary
     *.manifest      binary
    ```

## デプロイページ
[https://kazenetu.github.io/ClickOnceTest/doc/](https://kazenetu.github.io/ClickOnceTest/doc/)