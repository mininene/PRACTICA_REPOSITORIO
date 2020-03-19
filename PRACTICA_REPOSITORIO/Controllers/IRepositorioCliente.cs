using PRACTICA_REPOSITORIO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRACTICA_REPOSITORIO.Controllers
{
    public interface IRepositorioCliente
    {

        Task Add(Cliente _Cliente);
        Task Remove(Cliente _Cliente);
        Task Update(Cliente _Cliente);
        Task<IEnumerable<Cliente>> List();
        Task<Cliente> GetById(int Id);
    }
}
