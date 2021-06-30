using AppCadastro.API;
using Plugin.Connectivity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppCadastro.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private ApiService apiService = new ApiService();

        List<Cliente> listcliente;
        public LoginPage()
        {
            InitializeComponent();
            listcliente = new List<Cliente>();
        }

        public async void Logar()
        {
            if (CrossConnectivity.Current.IsConnected)
            {
                listcliente = await apiService.GetContentsAsyncClient();

                var cliente = listcliente.Where(x => x.Email.ToLower() == etUser.Text.ToLower() && x.Senha.ToLower() == etPassword.Text.ToLower()).ToList();
                if (cliente.Count > 0)
                {
                    await Navigation.PushAsync(new ListaClientes());
                }
                else
                {
                    DisplayAlert("Erro", "Login ou senha incorretos.", "OK");
                }
            }
            else
            {
                DisplayAlert("Erro", "Sem conexão com a internet.", "OK");
            }
        }

        private void BtLogin_Clicked(object sender, EventArgs e)
        {
            Logar();
        }
    }
}