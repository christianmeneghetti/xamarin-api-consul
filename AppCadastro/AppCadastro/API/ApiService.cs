using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastro.API
{
    class ApiService : IClientService
    {
        private RestService restService = new RestService();

        public async Task<List<Cliente>> GetContentsAsyncClient ( string id = null)
        {
            try
            {
                string urlclie = Constants.base_url + "Cliente";

                if (id != null)
                {
                    urlclie = Constants.base_url + "Cliente/" + id;
                }
                else
                {
                    urlclie = Constants.base_url + "Cliente";
                }

                HttpResponseMessage response = await restService.client.GetAsync(urlclie);

                if (response.IsSuccessStatusCode)
                {

                    using (var responseStream = await response.Content.ReadAsStreamAsync().ConfigureAwait(false))
                    {
                        try
                        {
                            HttpClient client = new HttpClient();
                            string resposta = await client.GetStringAsync(urlclie);
                            List<Cliente> cliente = JsonConvert.DeserializeObject<List<Cliente>>(resposta);
                            return cliente;
                        }
                        catch (Exception e)
                        {
                            System.Diagnostics.Debug.WriteLine(e);
                            return new List<Cliente>();
                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return new List<Cliente>();

        }

    }
}
