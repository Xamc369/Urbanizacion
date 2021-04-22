﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Urbanizacion.Web.Data;
using Urbanizacion.Web.Helpers;
using Urbanizacion.Web.Models;


namespace Urbanizacion.Web.Controllers
{
    public class EgresoController : Controller
    {
        private readonly IConverterHelper _converterHelper;
        private readonly IImageHelper _imageHelper;
        
        private readonly DataContext _context;
        private readonly ICombosHelper _combosHelper;

        public EgresoController(DataContext context, IImageHelper imageHelper, IConverterHelper converterHelper, ICombosHelper combosHelper)
        {
            _context = context;
            _imageHelper = imageHelper;
            _combosHelper = combosHelper;
            _converterHelper = converterHelper;

        }

        // GET: Noticia
        public async Task<IActionResult> Index()
        {
            return View(await _context.Egresostbls
                .Include(e => e.Anio)
                .Include(e => e.Mes)
                .Include(e => e.TiposG)
                .ToListAsync());
        }

        // GET: Noticia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var egresostbl = await _context.Egresostbls
                .FirstOrDefaultAsync(m => m.Id == id);
            if (egresostbl == null)
            {
                return NotFound();
            }

            return View(egresostbl);
        }

        // GET: Noticia/Create
        public async Task<IActionResult> Create()
        {
            var model = new EgresoViewModel
            {
                Egr_FechadeRegistro = DateTime.Today,
                Egr_Estado = 'A',
                Anios1 = _combosHelper.GetComboAnios(),
                Meses1 = _combosHelper.GetComboMeses(),
                Tipos1 = _combosHelper.GetComboTipoGasto()
            };
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(EgresoViewModel model)
        {
            if (ModelState.IsValid)
            {
                var egreso = await _converterHelper.ToEgresoAsync(model, true);
                _context.Egresostbls.Add(egreso);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));

            }

            model.Anios1 = _combosHelper.GetComboAnios();
            model.Meses1 = _combosHelper.GetComboMeses();
            model.Tipos1 = _combosHelper.GetComboTipoGasto();
            return View(model);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticiastbls
                .FirstOrDefaultAsync(n => n.Id == id);

            if (noticia == null)
            {
                return NotFound();
            }
            return View(_converterHelper.ToNoticiaViewModel(noticia));
        }

        [HttpPost]
        public async Task<IActionResult> Edit(NoticiaViewModel model)
        {
            if (ModelState.IsValid)
            {
                var path = model.ImageUrl;

                if (model.ImageFile != null)
                {
                    path = await _imageHelper.UploadImageAsyncNoticia(model.ImageFile);

                }

                var noticia = await _converterHelper.ToNoticiaAsync(model, false, path);
                _context.Noticiastbls.Update(noticia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var noticia = await _context.Noticiastbls
                .FirstOrDefaultAsync(h => h.Id == id.Value);

            if (noticia == null)
            {
                return NotFound();
            }

            noticia.Not_Estado = 'I';
            // _context.Negociostbls.Remove(negocio);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NoticiastblExists(int id)
        {
            return _context.Noticiastbls.Any(e => e.Id == id);
        }
    }
}

