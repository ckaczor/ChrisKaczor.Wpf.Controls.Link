using System.Windows;

namespace ChrisKaczor.Wpf.Controls
{
    public partial class Link
    {
        public event RoutedEventHandler? Click;

        public Link()
        {
            InitializeComponent();

            HyperlinkControl.Click += HandleHyperlinkControlClick;
        }

        private void HandleHyperlinkControlClick(object sender, RoutedEventArgs e)
        {
            Click?.Invoke(sender, e);
        }

        public string Text
        {
            get => ContentControl.Text;
            set => ContentControl.Text = value;
        }

        public new bool IsEnabled
        {
            get => base.IsEnabled;
            set
            {
                base.IsEnabled = value;
                HyperlinkControl.IsEnabled = value;
            }
        }
    }
}
