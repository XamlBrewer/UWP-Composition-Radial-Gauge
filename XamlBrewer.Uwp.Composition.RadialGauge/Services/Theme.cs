using System;
using System.Globalization;
using Windows.Foundation.Metadata;
using Windows.UI;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media;

namespace Mvvm.Services
{
    public class Theme
    {
        //public static Color ToColor(uint argb)
        //{
        //    return Color.FromArgb((byte)((argb & -16777216) >> 0x18),
        //                          (byte)((argb & 0xff0000) >> 0x10),
        //                          (byte)((argb & 0xff00) >> 8),
        //                          (byte)(argb & 0xff));
        //}

        // Call this in App OnLaunched.
        // Requires reference to Windows Mobile Extensions for the UWP.
        public static void ApplyToContainer()
        {
            //PC customization
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.ApplicationView"))
            {
                var titleBar = ApplicationView.GetForCurrentView().TitleBar;
                if (titleBar != null)
                {
                    titleBar.ButtonBackgroundColor = ((SolidColorBrush)Application.Current.Resources["TitlebarBackgroundBrush"]).Color;
                    titleBar.ButtonForegroundColor = Colors.White;
                    titleBar.BackgroundColor = ((SolidColorBrush)Application.Current.Resources["TitlebarBackgroundBrush"]).Color;
                    titleBar.ForegroundColor = Colors.White;
                }
            }

            //Mobile customization
            if (ApiInformation.IsTypePresent("Windows.UI.ViewManagement.StatusBar"))
            {
                var statusBar = StatusBar.GetForCurrentView();
                if (statusBar != null)
                {
                    statusBar.BackgroundOpacity = 1;
                    statusBar.BackgroundColor = ((SolidColorBrush)Application.Current.Resources["StatusbarBackgroundBrush"]).Color;
                    statusBar.ForegroundColor = Colors.White;
                }
            }
        }
    }
}
