using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using VK.WindowsPhone.SDK;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.Phone.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Плеер_для_VK
{
    public sealed partial class MainPage : Page
    {
        private List<String> _scope = new List<string> { VKScope.AUDIO, VKScope.STATUS };
        public MainPage()
        {
            this.InitializeComponent();
            this.NavigationCacheMode = NavigationCacheMode.Required;

            //Авторизация в VK.com
            VKSDK.Initialize("5253099");
            VKSDK.Authorize(_scope, false, false);
        }

    }
}
