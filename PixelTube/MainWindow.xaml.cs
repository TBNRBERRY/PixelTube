using Microsoft.UI.Xaml;
using Microsoft.Web.WebView2.Core;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace PixelTube
{
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            InitializeWebViewAsync();
        }

        private async Task InitializeWebViewAsync()
        {
            await WebView.EnsureCoreWebView2Async();

            // Xbox / TV User Agent
            WebView.CoreWebView2.Settings.UserAgent =
                "Mozilla/5.0 (Xbox; Xbox One) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/110 Safari/537.36";

            WebView.CoreWebView2.Settings.IsScriptEnabled = true;

            // Navigate to YouTube TV
            WebView.Source = new Uri("https://www.youtube.com/tv");

        }
    }
}
