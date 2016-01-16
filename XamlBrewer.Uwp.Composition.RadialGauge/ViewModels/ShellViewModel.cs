using Windows.UI.Xaml.Controls;
using XamlBrewer.Uwp.Composition.RadialGauge;

namespace Mvvm
{
    class ShellViewModel : ViewModelBase
    {
        public ShellViewModel()
        {
            // Build the menu
            // Symbol enumeration is here: https://msdn.microsoft.com/en-us/library/windows/apps/windows.ui.xaml.controls.symbol.aspx
            Menu.Add(new MenuItem() { Glyph = Symbol.Remote, Text = "Comparison", NavigationDestination = typeof(MainPage) });
            Menu.Add(new MenuItem() { Glyph = Symbol.OutlineStar, Text = "Classic", NavigationDestination = typeof(SquareOfOldPage) });
            Menu.Add(new MenuItem() { Glyph = Symbol.SolidStar, Text = "New", NavigationDestination = typeof(SquareOfNewPage) });
        }
    }
}
