using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PRACTICA_REPOSITORIO.Models;

namespace PRACTICA_REPOSITORIO.Controllers
{
    public class FakeRepositorioCliente : IRepositorioCliente
    {

        private List<Cliente> listaClientes = new List<Cliente>(){
            new Cliente{Id=1,RazonSocial="CA",PosicionGeodesica="x",Correo="comentario@g.com", Telefono="999999" },
            new Cliente{Id=2,RazonSocial="SL",PosicionGeodesica="y",Correo="comentario@g.com", Telefono="56456456" },
            new Cliente{Id=3,RazonSocial="SA",PosicionGeodesica="z",Correo="comentario@g.com", Telefono="324234" },
             new Cliente{Id=1,RazonSocial="CA",PosicionGeodesica="x",Correo="comentario@g.com", Telefono="999999" },
            new Cliente{Id=2,RazonSocial="SL",PosicionGeodesica="y",Correo="comentario@g.com", Telefono="56456456" },
            new Cliente{Id=3,RazonSocial="SA",PosicionGeodesica="z",Correo="comentario@g.com", Telefono="324234" },

        };


        public FakeRepositorioCliente()
        {

        }


        public async Task Add(Cliente _Cliente)
        {
             listaClientes.Add(_Cliente);
            

        }

        public async Task<Cliente> GetById(int Id)
        {
            return listaClientes.Find(x => x.Id == Id);
        }

        public async Task<IEnumerable<Cliente>> List()
        {
            return listaClientes;
        }

        public async Task Remove(Cliente _Cliente)
        {
            listaClientes.Remove(_Cliente);
        }

        public async Task Update(Cliente _Cliente)
        {
            Cliente _miCliente = listaClientes.Find(x => x.Id == _Cliente.Id);
            if (_miCliente != null)
            {
                _miCliente = _Cliente;
            }
        }
    }
}