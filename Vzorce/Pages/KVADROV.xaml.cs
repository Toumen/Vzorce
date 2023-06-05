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
            // norm�ln� X
            string XX = XN.Text;
            double NX = double.Parse(XX);

            string N = C.Text;
            double NC = double.Parse(N);

            if(XND == 0)
            {

                double vys = Math.Round(NX / -NX, 2);
                Vysledek.Text = $"X na druhou je nula tak�e se nejedn� o kvadratickou rovnoci ale o klasickou rovnici kde v�sledek je {vys}";
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
                    Vysledek.Text = $"Kvadratick� rovnice nem� �e�en� jeliko� jej� diskriminant vy�el  men�� ne� nula  {disND}";
                }
                else
                {
                    double kor1 = Math.Round((-NX + dis) / (2 * XND), 2);
                    double kor2 = Math.Round((-NX - dis)/(2 * XND),2);

                    Vysledek.Text = $"Kvadraticka rovnice vy�la \n Diskriminant se rovn�: {disND} \n Vysledeky pro X jsou: {kor1} a {kor2}";
                }
            }
        }
        else
        {
            DisplayAlert("Chyba", "Nebylo zad�na jedna hodnota", "OK");
        }
    }
}