using AppCadastro.API;
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
        public LoginPage()
        {
            InitializeComponent();
        }

        public async void Logar()
        {
            //if (etUser.Text && etPassword.Text == )
            //{

            //}
            string bla = "1";

            var Clientes = await apiService.GetContentsAsyncClient();
        }

        private void BtLogin_Clicked(object sender, EventArgs e)
        {
            Logar();
        }
    }
}