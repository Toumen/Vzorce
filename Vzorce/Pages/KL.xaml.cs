namespace Vzorce.Pages;

public partial class KL : ContentPage
{
    public const double PI = Math.PI;
    public KL()
	{
		InitializeComponent();
	}

    private void Vypocet(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(poloK.Text))
        {
            string poloM = poloK.Text;
            double r = double.Parse(poloM);
            double d = Math.Round(r * 2, 2);
            double O = Math.Round(d * PI, 2);
            double P = Math.Round((d * d) * PI, 2);
            double V = Math.Round(((d * d * d) * PI) / 6, 2);
            Vysledek.Text = $"Prùmìr koule je: {d} cm \n Obvod koule je: {O} cm \n Povrch koule je {P} cm\u00b2 \n Objem kruhu je {V} cm\u00b3";
        }
        else
        {
            DisplayAlert("Chyba", "Nebylo zadána délka strany", "OK");
        }
    }
}