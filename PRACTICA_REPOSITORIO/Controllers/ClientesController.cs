using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PRACTICA_REPOSITORIO.Models;

namespace PRACTICA_REPOSITORIO.Controllers
{
    public class ClientesController : Controller
    {
       
        // private IRepositorioCliente repositorio = new FakeRepositorioCliente();
       private IRepositorioCliente repositorio = new EFRepositorioCliente();

        public ClientesController(IRepositorioCliente repositorio)
        {
            this.repositorio = repositorio;
        }

        public ClientesController()
        { }

        // GET: Clientes
        public async Task<ActionResult> Index()
        {
            return View(await repositorio.List());
        }

        // GET: Clientes/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = await repositorio.GetById((int)id).ConfigureAwait(false); ;
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Clientes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Clientes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Id,RazonSocial,PosicionGeodesica,Correo,Telefono")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                await repositorio.Add(cliente).ConfigureAwait(false);
                return RedirectToAction("Index");
            }

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = await repositorio.GetById((int)id).ConfigureAwait(false);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Id,RazonSocial,PosicionGeodesica,Correo,Telefono")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                await repositorio.Update(cliente).ConfigureAwait(false);
                return RedirectToAction("Index");
            }
            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cliente cliente = await repositorio.GetById((int)id).ConfigureAwait(false);
            if (cliente == null)

            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Cliente cliente = await repositorio.GetById((int)id).ConfigureAwait(false);
            if (cliente != null)
            {
                await repositorio.Remove(cliente).ConfigureAwait(false);
            }
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
           
        }
    }
}
