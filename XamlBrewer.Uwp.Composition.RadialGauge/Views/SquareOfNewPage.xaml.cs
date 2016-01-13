using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using XamlBrewer.Uwp.Controls;


namespace XamlBrewer.Uwp.Composition.RadialGauge
{
    /// <summary>
    /// A page with lots of Radial Gauges - new version.
    /// </summary>
    public sealed partial class SquareOfNewPage : Page
    {
        public SquareOfNewPage()
        {
            this.InitializeComponent();
            this.Loaded += SquareOfOldPage_Loaded;
        }

        private void SquareOfOldPage_Loaded(object sender, RoutedEventArgs e)
        {
            foreach (var square in SquareOfSquares.Squares)
            {
                var gauge = new XamlBrewer.Uwp.Controls.RadialGauge() { Height = square.ActualHeight, Width = square.ActualWidth };
                gauge.TrailBrush = new SolidColorBrush(square.RandomColor());
                gauge.TickBrush = new SolidColorBrush(Colors.Transparent);
                gauge.ScaleTickBrush = new SolidColorBrush(Colors.LemonChiffon);
                gauge.NeedleBrush = new SolidColorBrush(Colors.OrangeRed);
                gauge.Maximum = 50;
                var side = square.Side();
                gauge.Value = side;
                square.Content = gauge;
            }
        }
    }
}
