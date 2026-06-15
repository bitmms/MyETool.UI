using System.Windows;
using MyETool.UI.App.View;

namespace MyETool.UI.App
{
    public partial class App
    {
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            // new MainWindow().ShowDialog();
            // new IconWindow().ShowDialog();
            new ButtonWindow().ShowDialog();
        }
    }
}
