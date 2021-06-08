using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AppCadastro.API
{
    public interface IClientService
    {
        Task<List<Cliente>> GetContentsAsyncClient(string id = null);
    }
}
