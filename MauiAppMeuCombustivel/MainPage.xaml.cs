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
                // Capturando os valores dos campos
                double precoEtanol = Convert.ToDouble(txt_etanol.Text);
                double precoGasolina = Convert.ToDouble(txt_gasolina.Text);

                string marca = txt_marca.Text;
                string modelo = txt_modelo.Text;

                double resultado = precoEtanol / precoGasolina;

                string msg = "";
                if (resultado >= 0.7)
                {
                    msg = $"A Gasolina está compensando para o seu {marca} {modelo}.";
                }
                else
                {
                    msg = $"O Etanol está compensando para o seu {marca} {modelo}.";
                }

                DisplayAlert("Resultado", msg, "OK");
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", "Por favor, preencha todos os campos corretamente. Erro: " + ex.Message, "Fechar");
            }
        }
    }
}