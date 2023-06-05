namespace Vzorce.Pages;

public partial class OBDL : ContentPage
{
	public OBDL()
	{
		InitializeComponent();
	}
    private void Vypocet(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(VelS1.Text) && !string.IsNullOrWhiteSpace(VelS2.Text))
        {
            string stranaS1 = VelS1.Text;
            double strana1 = double.Parse(stranaS1);
            string stranaS2 = VelS2.Text;
            double strana2 = double.Parse(stranaS2);

            //obvod
            double obvod = Math.Round((strana1 * 2) + (strana2 * 2), 2);

            //povrch
            double povrch = Math.Round(strana1 * strana2, 2);

            Vysledek.Text = $"Obvod obdeln�ku je {obvod}  cm \n Povrch obdeln�ku je {povrch} cm\u00b2";
        }

        else
        {
            DisplayAlert("Chyba", "Nebylo zad�na d�lka strany", "OK");
        }
    }

}