namespace GlitoneaDesktopApp;

using System;
using System.Reflection;
using Avalonia;
using Glitonea;

internal static class Program
{
    [STAThread]
    public static void Main(string[] args)
        => BuildAvaloniaApp()
            .StartWithClassicDesktopLifetime(args);

    public static AppBuilder BuildAvaloniaApp()
        => AppBuilder.Configure<App>()
            .UseGlitoneaFramework(Assembly.GetExecutingAssembly())
            .UsePlatformDetect()
            .WithInterFont()
            .LogToTrace();
}