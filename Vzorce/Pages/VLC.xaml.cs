namespace Vzorce.Pages;

public partial class VLC : ContentPage
{
    public const double PI = Math.PI;
    public VLC()
	{
		InitializeComponent();
	}

    private void Vypocet(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(poloK.Text) && !string.IsNullOrWhiteSpace(vysK.Text))
        {
            string poloM = poloK.Text;
            double r = double.Parse(poloM);

            string vys = vysK.Text;
            double v = double.Parse(vys);


            double d = Math.Round(r * 2, 2);

            double obvod = Math.Round(d * PI, 2);

            double PP = Math.Round((r * r) * PI, 2);

            double PS = Math.Round(v * obvod ,2);
            double povrch = Math.Round((2 * PP) +  PS, 2);
            double objem = Math.Round(PP * v, 2);

            Vysledek.Text = $"Prùmìr válce je: {d} cm \n Obvod kruhu je: {obvod} cm \n Povrch válce je {povrch} cm\u00b2 \n Obsah kruhu je {objem} cm\u00b3" ;
        }
        else
        {
            DisplayAlert("Chyba", "Nebylo zadána délka strany", "OK");
        }
    }
}