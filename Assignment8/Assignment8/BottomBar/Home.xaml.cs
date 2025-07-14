
using Assignment8.TopBar; 
namespace Assignment8.BottomBar;

public partial class Home : ContentPage
{
	public Home()
	{
		InitializeComponent();
	}
    private async void OnGoToAnimePageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Anime());
    }
    private async void OnGoToConceptArtPageClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new ConceptArt());
    }
}