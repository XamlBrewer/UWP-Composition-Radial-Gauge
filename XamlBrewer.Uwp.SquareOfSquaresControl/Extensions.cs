using System;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace XamlBrewer.Uwp.Controls
{
    /// <summary>
    /// Extension methods for an inner square.
    /// </summary>
    public static class Extensions
    {
        private static Random r = new Random(DateTime.Now.Millisecond);

        /// <summary>
        /// Returns the side of an inner square.
        /// </summary>
        public static int Side(this UIElement element)
        {
            return (int)element.GetValue(Grid.RowSpanProperty);
        }

        /// <summary>
        /// Returns a random color.
        /// </summary>
        /// <remarks>Not necessarily an extension method. Just for convenience.</remarks>
        public static Color RandomColor(this UIElement element)
        {
            byte red = (byte)r.Next(0, 255);
            byte green = (byte)r.Next(0, 255);
            byte blue = (byte)r.Next(0, 255);

            return new Color() { A = 255, R = red, G = green, B = blue };
        }
    }
}
