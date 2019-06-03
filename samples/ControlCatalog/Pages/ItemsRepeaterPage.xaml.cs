using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Controls.Repeaters;
using Avalonia.Markup.Xaml;

namespace ControlCatalog.Pages
{
    public class ItemsRepeaterPage : UserControl
    {
        private ItemsRepeater _repeater;
        private ScrollViewer _scroller;

        public ItemsRepeaterPage()
        {
            this.InitializeComponent();
            _repeater = this.FindControl<ItemsRepeater>("repeater");
            _scroller = this.FindControl<ScrollViewer>("scroller");
            _repeater.Layout = new UniformGridLayout { MinItemWidth = 100 };
            _scroller.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            _scroller.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            DataContext = Enumerable.Range(1, 100000).Select(i => $"Item {i}" )
                .ToArray();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void LayoutChanged(object sender, SelectionChangedEventArgs e)
        {
            //if (_repeater == null)
            //{
            //    return;
            //}

            //var comboBox = (ComboBox)sender;

            //switch (comboBox.SelectedIndex)
            //{
            //    case 0:
            //        ((StackLayout)_repeater.Layout).Orientation = Orientation.Vertical;
            //        _scroller.HorizontalScrollBarVisibility = ScrollBarVisibility.Disabled;
            //        _scroller.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            //        break;
            //    case 1:
            //        ((StackLayout)_repeater.Layout).Orientation = Orientation.Horizontal;
            //        _scroller.HorizontalScrollBarVisibility = ScrollBarVisibility.Auto;
            //        _scroller.VerticalScrollBarVisibility = ScrollBarVisibility.Disabled;
            //        break;
            //}
        }
    }
}
