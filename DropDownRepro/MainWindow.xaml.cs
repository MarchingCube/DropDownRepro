using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;

namespace DropDownRepro
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

	        var statusPopup = this.FindControl<Popup>("StatusPopup");
	        var statusText = this.FindControl<TextBlock>("StatusText");

	        this.FindControl<Button>("Abort").Click += (sender, args) =>
	        {
		        statusPopup.IsOpen = true;
		        statusText.Text = "Launch aborted!";
	        };

	        this.FindControl<Button>("Launch").Click += (sender, args) =>
	        {
		        statusPopup.IsOpen = true;
				statusText.Text = "Launch successful!";
	        };
		}
    }
}
