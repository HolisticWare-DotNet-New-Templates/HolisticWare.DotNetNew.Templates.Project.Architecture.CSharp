namespace ProjectsStructureTemplate.UserInterface.Library.MAUI.Views;

public partial class WebView :	ContentView
								//Microsoft.Maui.Controls.WebView
{
	public WebView()
	{
		InitializeComponent();
	}

    protected void webview_Navigating(System.Object sender, Microsoft.Maui.Controls.WebNavigatingEventArgs e)
    {
        return;
    }

    protected void webview_Navigated(System.Object sender, Microsoft.Maui.Controls.WebNavigatingEventArgs e)
    {
        return;
    }
}
