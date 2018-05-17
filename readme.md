# ListView へのバインドと変更通知

ListView の ItemsSource へのバインドは INotifyCollectionChanged インターフェースを実装したコレクションをバインドすると要素の追加削除などのコレクションの変更に対応可能になります。

この例では、MainPage.xaml.cs の MainPageViewModel の Items プロパティが ObservableCollection です。
これを MainPage.xaml の ListView の ItemsSource にバインドしています。これで要素の追加があったとき（削除は実装してませんが対応可能です）に ListView の要素が増えます。

アプリを実行して TextBox に何か入れて Add ボタンをクリックすると確認できます。

MainPageViewModel の AddItemListItemCommand で追加処理をしています。
Text に何か入れてないと押せないように実装しています。

# LsitView の中のクラスのインスタンスのプロパティの変更通知

これは ObservableCollection に格納されたオブジェクトが変わったことを通知する必要があるので ObservableCollection の中に入っているクラス自体が INotifyPropertyChanged を実装しなければなりません。
今回は ReactiveProperty を使ってプロパティ自身が変更通知するようにしています。

ListItem クラスがそのようになっています。

アプリを起動して TextBox にテキストを入力して ListView で任意の行を選択すると Set ボタンが押せるようになるので、それで動作確認できます。

MainPageViewModel クラスの UpdateTextCommand で実装しています。
UpdateTextCommand はテキストに何か入っていて ListView で何か選択されていないと押せないようにしています。
