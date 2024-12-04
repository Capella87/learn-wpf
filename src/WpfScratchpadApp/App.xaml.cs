using System.Configuration;
using System.Data;
using System.Windows;

namespace WpfScratchpadApp;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    App() : base()
    {
        Application.Current.ThemeMode = ThemeMode.System;
    }
}

