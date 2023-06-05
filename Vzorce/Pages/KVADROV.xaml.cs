namespace Vzorce.Pages;

public partial class KVADROV : ContentPage
{
	public KVADROV()
	{
		InitializeComponent();
	}

    private void Vypocet(object sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(X2.Text) && !string.IsNullOrWhiteSpace(XN.Text) && !string.IsNullOrWhiteSpace(C.Text))
        {
            //X na druhou
            string XNR = X2.Text;
            double XND = double.Parse(XNR);
            // normální X
            string XX = XN.Text;
            double NX = double.Parse(XX);

            string N = C.Text;
            double NC = double.Parse(N);

            if(XND == 0)
            {

                double vys = Math.Round(NX / -NX, 2);
                Vysledek.Text = $"X na druhou je nula takže se nejedná o kvadratickou rovnoci ale o klasickou rovnici kde výsledek je {vys}";
            }
            else
            {
                //diskriminant
                double dis1 = Math.Pow(NX,2);
                double dis2 = 4d * XND * NC;
                double disND = Math.Round(dis1 - dis2,2);
                double dis = Math.Round(Math.Sqrt(disND),2);

                if(disND < 0)
                {
                    Vysledek.Text = $"Kvadratická rovnice nemá øešení jelikož její diskriminant vyšel  menší než nula  {disND}";
                }
                else
                {
                    double kor1 = Math.Round((-NX + dis) / (2 * XND), 2);
                    double kor2 = Math.Round((-NX - dis)/(2 * XND),2);

                    Vysledek.Text = $"Kvadraticka rovnice vyšla \n Diskriminant se rovná: {disND} \n Vysledeky pro X jsou: {kor1} a {kor2}";
                }
            }
        }
        else
        {
            DisplayAlert("Chyba", "Nebylo zadána jedna hodnota", "OK");
        }
    }
}