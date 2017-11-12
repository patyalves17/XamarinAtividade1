using System;
using Xamarin.Forms;

namespace Main
{
    public partial class MainPage : ContentPage
    {
        ConfigPage cp;

        public MainPage()
        {
            InitializeComponent();
            cp = new ConfigPage();
        }

        private void btnEnviar_Clicked (object sender, EventArgs e) {
            //Navigation.PushAsync(new EnviarPage());
            if(cp.Recebe){
                DisplayAlert("Enviar email",string.Format("Email enviado para {0}", cp.Email), "OK");
            }else{
                DisplayAlert("Enviar email", "Não foi possivel enviar o email", "OK");
            }
        }

        private void btnConfig_Clicked(object sender, EventArgs e) {
            Navigation.PushAsync(cp);
        }
    }
}
