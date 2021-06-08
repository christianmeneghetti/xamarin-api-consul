using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Net.Http.Headers;

namespace AppCadastro
{
    public class RestService
    {

        public HttpClient client;

        public RestService()
        {
            var authData = string.Format("{0}:{1}", Constants.Username, Constants.Password);
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));

            client = new HttpClient();
            //  client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue); 
            client.DefaultRequestHeaders.Add("Accept", "application/json");
        }

        public HttpClient getRest()
        {
            return client;
        }
    }
}
