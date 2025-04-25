namespace QuoteGenerator;

public partial class MainPage : ContentPage
{
	

	public MainPage()
	{
		InitializeComponent();
	}

    private void BtnGenerateQoute_Clicked(object sender, EventArgs e)
        {
        QuoteLable.Text = "The purpose of our lives is to be happy.--Dalai Lama";


        }
    }

