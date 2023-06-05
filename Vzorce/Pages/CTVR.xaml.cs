namespace Vzorce.Pages;
using Microsoft.Maui.Controls.PlatformConfiguration.AndroidSpecific;

public partial class CTVR : ContentPage
{
    public CTVR()
	{
		InitializeComponent();

	}

    private void Vypocet(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(VelS.Text))
        {
            string stranaS = VelS.Text;
            double strana = double.Parse(stranaS);

            //obvod
            double obvod = Math.Round(strana * 4, 2);
            string obvodt = Convert.ToString(obvod);

            //povrch
            double povrch = Math.Round(strana * strana, 2);
            string povrcht = Convert.ToString(povrch);

            Vysledek.Text = $"Obvod ètverce je {obvodt} cm \n Povrch ètverce je {povrcht} cm\u00b2";
        }
        else
        {
            DisplayAlert("Chyba", "Nebylo zadána délka strany", "OK");
        }
    }
}