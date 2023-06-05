namespace Vzorce.Pages;

public partial class KVDR : ContentPage
{
	public KVDR()
	{
		InitializeComponent();
	}

    private void Vypocet(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(VelS1.Text) && !string.IsNullOrWhiteSpace(VelS2.Text) && !string.IsNullOrWhiteSpace(VelS3.Text))
        {
            string stranaS1 = VelS1.Text;
            double a = double.Parse(stranaS1);
            string stranaS2 = VelS2.Text;
            double b = double.Parse(stranaS2);
            string stranaS3 = VelS3.Text;
            double c = double.Parse(stranaS3);

            double obvod = Math.Round(4 * (a + b + c), 2);

            double povrch = Math.Round(2 * ((a * b) + (b * c) + (a * c)),2);

            double objem = Math.Round(a * b * c,2);


            Vysledek.Text = $"Obvod kvádru je: {obvod} cm \n Povrch kvádru je: {povrch} cm\u00b2 \n Objem kvádru je: {objem} cm\u00b3 ";

        }
        else
        {
            DisplayAlert("Chyba", "Nebylo zadána délka strany", "OK");
        }
    }
}