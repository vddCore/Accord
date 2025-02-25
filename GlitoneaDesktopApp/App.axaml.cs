namespace GlitoneaDesktopApp;

using System.Diagnostics;
using Autofac;
using Glitonea.Extensibility;
using GlitoneaDesktopApp.View.Windows;

[DoNotNotify]
public partial class App : Application, IContainerBuildingSubscriber
{
    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
    }

    public override void OnFrameworkInitializationCompleted()
    {
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop) 
            desktop.MainWindow = new MainWindow();

        base.OnFrameworkInitializationCompleted();
    }

    public void OnBuildingIoC(ContainerBuilder containerBuilder)
    {
        Debug.WriteLine("Building IoC container.");
    }
}