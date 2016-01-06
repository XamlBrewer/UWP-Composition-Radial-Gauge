using System;
using System.Windows.Input;
using Windows.UI.Xaml.Controls;

namespace Mvvm
{
    class MenuItem : BindableBase
    {
        private Symbol glyph;
        private string text;
        private DelegateCommand command;
        private Type navigationDestination;

        public Symbol Glyph
        {
            get { return glyph; }
            set { SetProperty(ref glyph, value); }
        }

        public string Text
        {
            get { return text; }
            set { SetProperty(ref text, value); }
        }

        public ICommand Command
        {
            get { return command; }
            set { SetProperty(ref command, (DelegateCommand)value); }
        }

        public Type NavigationDestination
        {
            get { return navigationDestination; }
            set { SetProperty(ref navigationDestination, value); }
        }

        public bool IsNavigation
        {
            get { return navigationDestination != null; }
        }
    }
}
