using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using appMobiWebViewWP8;

namespace AppMobiWP8SimpleJqMobiTemplate
{
    public partial class AppMobiPage : PhoneApplicationPage
    {
        public appMobiWebView amWebView;

        public AppMobiPage()
        {
            InitializeComponent();

            amWebView = new appMobiWebView(webView, phoneApplicationPage, "http://localhost:5888/index.html");
        }
    }
}