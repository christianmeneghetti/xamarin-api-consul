using AppCadastro.API;
using AppCadastro.Cell;
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
    public partial class ListaClientes : ContentPage
    {
        private ApiService apiService = new ApiService();
        public List<Cliente> ListaCliente;
        public ListaClientes()
        {
            InitializeComponent();
            ListaCliente = new List<Cliente>();
            ListViewCliente.ItemTemplate = new DataTemplate(typeof(ClienteCell));
            ListViewCliente.RowHeight = 120;
            ListViewCliente.ItemSelected += ListViewCliente_ItemSelect;
        }

        public async void CarregarClientes()
        {
            ListaCliente = await apiService.GetContentsAsyncClient();
            ListViewCliente.ItemsSource = ListaCliente.OrderBy(x => x.Nome).ToList();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarClientes();
        }

        private void ListViewCliente_ItemSelect(object sender, SelectedItemChangedEventArgs e)
        {
           // throw new NotImplementedException();
        }

        private void pesquisarCliente_TextChanged(object sender, TextChangedEventArgs e)
        {
            String textopesquisa = pesquisarCliente.Text;
            ListViewCliente.ItemsSource = ListaCliente.Where(x => x.Nome.ToLower().Contains(textopesquisa.ToLower())).ToList() ;
        }
    }
}