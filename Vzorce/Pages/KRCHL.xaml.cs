namespace Vzorce.Pages;

public partial class KRCHL : ContentPage
{
	public KRCHL()
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
            double obvod = Math.Round(strana * 12, 2);

            //povrch
            double povrch = Math.Round(strana * strana * 6, 2);

            //Objem
            double objem = Math.Round(strana * strana * strana, 2);

            Vysledek.Text = $"Obvod krychle je {obvod} cm \n Povrch krychle je  {povrch} cm\u00b2 \n Objem krychle je {objem} cm\u00b3";
        }
        else
        {
            DisplayAlert("Chyba", "Nebylo zadána délka strany", "OK");
        }
    }
}