using Microsoft.UI.Xaml.Controls.Primitives;

namespace meuPrimeiroMaui
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt_a.Text); 
            double b = Convert.ToDouble(txt_b.Text);
            double c = Convert.ToDouble(txt_c.Text);

            double x1 = 0, x2 = 0;

            string msg = $"O resultado é {x1} e {x2}";

            double delta = (b * b) - (4 * a * c);

            if (delta = 0)
            {
                 x1 = (-b + Math.Sqrt(delta)) /2*a;


                DisplayAlert("Resultado", msg, "Fechar");
            }

            
             x2 = -b - Math.Sqrt(delta) / 2 * a;

        }
    }

}
