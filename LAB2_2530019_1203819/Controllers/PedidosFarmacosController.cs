using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using LAB2_2530019_1203819.Data;
using LAB2_2530019_1203819.Models;

namespace LAB2_2530019_1203819.Controllers
{
    public class PedidosFarmacosController : Controller
    {
        private readonly LAB2_2530019_1203819Context _context;

        public PedidosFarmacosController(LAB2_2530019_1203819Context context)
        {
            _context = context;
        }

        // GET: PedidosFarmacos
        public async Task<IActionResult> Index()
        {
            return View(await _context.PedidosFarmacos.ToListAsync());
        }

        // GET: PedidosFarmacos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidosFarmacos = await _context.PedidosFarmacos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidosFarmacos == null)
            {
                return NotFound();
            }

            return View(pedidosFarmacos);
        }

        // GET: PedidosFarmacos/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PedidosFarmacos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre_Cliente,Direccion,Nit,Listado_Farmacos,Total_Cancelar")] PedidosFarmacos pedidosFarmacos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pedidosFarmacos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pedidosFarmacos);
        }

        // GET: PedidosFarmacos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidosFarmacos = await _context.PedidosFarmacos.FindAsync(id);
            if (pedidosFarmacos == null)
            {
                return NotFound();
            }
            return View(pedidosFarmacos);
        }

        // POST: PedidosFarmacos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre_Cliente,Direccion,Nit,Listado_Farmacos,Total_Cancelar")] PedidosFarmacos pedidosFarmacos)
        {
            if (id != pedidosFarmacos.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pedidosFarmacos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PedidosFarmacosExists(pedidosFarmacos.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(pedidosFarmacos);
        }

        // GET: PedidosFarmacos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pedidosFarmacos = await _context.PedidosFarmacos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (pedidosFarmacos == null)
            {
                return NotFound();
            }

            return View(pedidosFarmacos);
        }

        // POST: PedidosFarmacos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var pedidosFarmacos = await _context.PedidosFarmacos.FindAsync(id);
            _context.PedidosFarmacos.Remove(pedidosFarmacos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PedidosFarmacosExists(int id)
        {
            return _context.PedidosFarmacos.Any(e => e.Id == id);
        }
    }
}
