namespace MauiAppMeuCombustivel
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double precoEtanol = Convert.ToDouble(txt_etanol.Text);
                double precoGasolina = Convert.ToDouble(txt_gasolina.Text);
                double resultado = precoEtanol / precoGasolina;

                string msg = "";
                if (resultado >= 0.7)
                {
                    msg = "Melhor utilizar Gasolina";
                }
                else
                {
                    msg = "Melhor utilizar Etanol";
                }

                DisplayAlert("Resultado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "Fechar");
            } // Fecha método
        }
    } // Fecha classe
}// Fecha namespace
