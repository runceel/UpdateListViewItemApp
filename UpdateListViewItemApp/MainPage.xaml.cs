using Reactive.Bindings;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// 空白ページの項目テンプレートについては、https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x411 を参照してください

namespace UpdateListViewItemApp
{
    /// <summary>
    /// それ自体で使用できる空白ページまたはフレーム内に移動できる空白ページ。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel ViewModel { get; } = new MainPageViewModel();
        public MainPage()
        {
            this.InitializeComponent();
        }
    }

    public class MainPageViewModel
    {
        public ObservableCollection<ListItem> Items { get; } = new ObservableCollection<ListItem>
        {
            new ListItem("Item0"),
            new ListItem("Item1"),
            new ListItem("Item2"),
            new ListItem("Item3"),
        };

        public ReactiveProperty<ListItem> SelectedItem { get; } = new ReactiveProperty<ListItem>();

        public ReactiveProperty<string> Text { get; } = new ReactiveProperty<string>();

        public ReactiveCommand UpdateTextCommand { get; }

        public ReactiveCommand AddListItemCommand { get; }

        public MainPageViewModel()
        {
            UpdateTextCommand = Observable.CombineLatest(
                Text,
                SelectedItem,
                (text, selectedItem) => !string.IsNullOrEmpty(text) && selectedItem != null)
                .ToReactiveCommand()
                .WithSubscribe(() => SelectedItem.Value.Text.Value = Text.Value);

            AddListItemCommand = Text.Select(x => !string.IsNullOrEmpty(x))
                .ToReactiveCommand()
                .WithSubscribe(() => Items.Add(new ListItem(Text.Value)));
        }

        public void AddItem()
        {
            Items.Add(new ListItem($"Item{Items.Count}"));
        }
    }

    public class ListItem
    {
        public ListItem(string text)
        {
            Text = new ReactiveProperty<string>(text);
        }
        public ReactiveProperty<string> Text { get; }
    }
}
