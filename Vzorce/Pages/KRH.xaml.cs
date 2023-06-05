namespace Vzorce.Pages;

public partial class KRH : ContentPage
{
    public const double PI = Math.PI;

    public KRH()
    {
        InitializeComponent();
    }

    private void Vypocet(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(poloK.Text))
        {
            string poloM = poloK.Text;
            double polo = double.Parse(poloM);
            double prum = Math.Round(polo * 2, 2);
            double obvod = Math.Round(prum * PI, 2);
            double obsah = Math.Round((polo * polo) * PI, 2);
            Vysledek.Text = $"Prùmìr kruhu je: {prum} cm \n Obvod kruhu je: {obvod} cm \n Povrch kruhu je {obsah} cm\u00b2";
        }
        else
        {
            DisplayAlert("Chyba", "Nebylo zadána délka strany", "OK");
        }
    }
}