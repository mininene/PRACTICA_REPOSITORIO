using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using PRACTICA_REPOSITORIO.Models;

namespace PRACTICA_REPOSITORIO.Controllers
{
    public class EFRepositorioCliente : IRepositorioCliente
    {

        private desaprendiendoDBEntities db = new desaprendiendoDBEntities();


        public async Task Add(Cliente _Cliente)
        {
            db.Cliente.Add(_Cliente);
            await db.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<Cliente> GetById(int Id)
        {
            Cliente _Cliente = await db.Cliente.FindAsync(Id).ConfigureAwait(false);
            return _Cliente;
        }

        public async Task<IEnumerable<Cliente>> List()
        {
            return await db.Cliente.ToListAsync().ConfigureAwait(false);

        }

        public async Task Remove(Cliente _Cliente)
        {
            db.Cliente.Remove(_Cliente);
            await db.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task Update(Cliente _Cliente)
        {
            db.Entry(_Cliente).State = EntityState.Modified;
            await db.SaveChangesAsync().ConfigureAwait(false);

        }
    }
}