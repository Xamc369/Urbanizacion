using Microsoft.AspNetCore.Identity.UI.Pages;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Urbanizacion.Web.Data;
using Urbanizacion.Web.Data.Entities;
using Urbanizacion.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Urbanizacion.Web.Helpers
{
    public class ConverterHelper : IConverterHelper
    {
        private readonly DataContext _dataContext1;
        private readonly ICombosHelper _combosHelper;
        


        public ConverterHelper(DataContext dataContext1,
            ICombosHelper combosHelper)
        {
            _dataContext1 = dataContext1;
            _combosHelper = combosHelper;
            
        }

        public async Task<Vehiculostbl> ToVehiculoAsync(VehiculoViewModel model, string path, bool IsNew)
        {
            return new Vehiculostbl
            {
               Veh_Codigo = model.Veh_Codigo,
               Veh_Placa = model.Veh_Placa,
               Veh_Born = DateTime.Today,
                Id = IsNew ? 0 : model.Id,
                ImageUrl = path,
                Veh_Estado = 'A',
                Propietario = await _dataContext1.Propietariostbls.FindAsync(model.PropietarioId),
               Veh_Detalles = model.Veh_Detalles
            };
        }

        public async Task<Negociostbl> ToNegocioAsync(NegocioViewModel model, string path, bool IsNew)
        {
            return new Negociostbl
            {
                Neg_Nombre = model.Neg_Nombre,
                Neg_Descripcion = model.Neg_Descripcion,
                Neg_Telefono = model.Neg_Telefono,
                Id = IsNew ? 0 : model.Id,
                ImageUrl = path,
                Neg_Estado = 'A',
                Neg_Direccion = model.Neg_Direccion,
                Propietarios = await _dataContext1.Propietariostbls.FindAsync(model.PropietarioId),
            };
        }

        public async Task<Noticiastbl> ToNoticiaAsync(NoticiaViewModel model, bool IsNew, string path)
        {
            return new Noticiastbl
            {
                Not_Titulo = model.Not_Titulo,
                Not_Autor = model.Not_Autor,
                Not_Descripcion = model.Not_Descripcion,
                Not_Fecha = model.Not_Fecha,
                Id = IsNew ? 0 : model.Id,
                ImageUrl = path,
                Not_Estado = 'A',
            };
        }

        public async Task<Valorestbl> ToValorAsync(ValorViewModel model, bool IsNew)
        {
            return new Valorestbl
            {
                Val_Valor = model.Val_Valor,
                Val_FechaCreacion = DateTime.Today,
                Id = IsNew ? 0 : model.Id,
                Val_Estado = 'A',

            };
        }

        public async Task<Egresostbl> ToEgresoAsync(EgresoViewModel model, bool IsNew)
        {
            var egresos = new Egresostbl
            {
                Egr_FechadePago = model.Egr_FechadePago,
                Egr_Descripcion = model.Egr_Descripcion,
                Egr_Valor = model.Egr_Valor,
                Egr_FechadeRegistro = DateTime.Today,
                Id = IsNew ? 0 : model.Id,
                Egr_Estado = 'A',
                Anio = await _dataContext1.Aniostbls.FindAsync(model.AnioId),
                Mes = await _dataContext1.Mesestbls.FindAsync(model.MesId),
                TiposG = await _dataContext1.TiposGastotbls.FindAsync(model.TipoId1)
            };

            return egresos;
        }

        public async Task<Pagostbl> ToPagoAsync(PagoViewModel model, bool isNew, char pag)
        {
            var pagos = new Pagostbl
            {
                PAG_FECHAPAGADO = model.PAG_FECHAPAGADO,
                PAG_FECHACREACION = DateTime.Today,
                PAG_ESTADO = 'A',
                PAG_PAGADO = 'P',
                Id = isNew ? 0 : model.Id,
                Propietario = await _dataContext1.Propietariostbls.FindAsync(model.PropietarioId),
                Anio = await _dataContext1.Aniostbls.FindAsync(model.AnioId),
                Mes = await _dataContext1.Mesestbls.FindAsync(model.MesId),
                Val = await _dataContext1.Valorestbls.FindAsync(model.ValorId),
                Tipos = await _dataContext1.TiposPagotbls.FindAsync(model.TipoPagoId),
                PuntodePago = await _dataContext1.PuntosPagotbls.FindAsync(model.PuntoPagoId),
            };


                return pagos;     
            

        }

        public PagoViewModel ToPagoViewModel(Pagostbl pago)
        {
            return new PagoViewModel
            {
                PAG_FECHAPAGADO = pago.PAG_FECHAPAGADO,
                PAG_FECHACREACION = DateTime.Today,
                PAG_ESTADO = 'A',
                Propietario = pago.Propietario,
                Anio = pago.Anio,
                Mes = pago.Mes,
                Val = pago.Val,
                Tipos = pago.Tipos,
                PuntodePago = pago.PuntodePago,
                Id = pago.Id,
                PropietarioId = pago.Propietario.Id,
                AnioId = pago.Anio.Id,
                MesId = pago.Mes.Id,
                ValorId = pago.Val.Id,
                TipoPagoId = pago.Tipos.Id,
                PuntoPagoId = pago.PuntodePago.Id,
                Anios1 = _combosHelper.GetComboAnios(),
                Meses1 = _combosHelper.GetComboMeses(),
                Valores = _combosHelper.GetComboValores(),
                TiposPago =_combosHelper.GetComboValoresDescripcion(),
                Puntos = _combosHelper.GetComboPuntos(),
            };
        }

     

        public VehiculoViewModel ToVehiculoViewModel(Vehiculostbl vehiculo)
        {
            return new VehiculoViewModel
            {
                Veh_Codigo = vehiculo.Veh_Codigo,
                Veh_Placa = vehiculo.Veh_Placa,
                Veh_Born = vehiculo.Veh_Born,
                ImageUrl = vehiculo.ImageUrl,
                //Veh_Estado = "A",
                Propietario = vehiculo.Propietario,
                Veh_Detalles = vehiculo.Veh_Detalles,
                Id = vehiculo.Id,
                PropietarioId = vehiculo.Propietario.Id,
            };
        }

        public NegocioViewModel ToNegocioViewModel(Negociostbl negocio)
        {
            return new NegocioViewModel
            {
                Neg_Nombre = negocio.Neg_Nombre,
                Neg_Descripcion = negocio.Neg_Descripcion,
                Neg_Telefono = negocio.Neg_Telefono,
                ImageUrl = negocio.ImageUrl,
                Neg_Direccion = negocio.Neg_Direccion,
                PropietarioId = negocio.Propietarios.Id,
            };
        }

        public NoticiaViewModel ToNoticiaViewModel(Noticiastbl noticia)
        {
            return new NoticiaViewModel
            {
                Not_Titulo = noticia.Not_Titulo,
                Not_Autor = noticia.Not_Autor,
                Not_Descripcion = noticia.Not_Descripcion,
                ImageUrl = noticia.ImageUrl,
                Not_FechaCreacion = noticia.Not_FechaCreacion,
            };
        }

        public async Task<Productostbl> ToProductoAsync(ProductoViewModel model, bool isNew, string path)
        {
            return new Productostbl
            {
                Id = isNew ? 0 : model.Id,
                Negocio = await _dataContext1.Negociostbls.FindAsync(model.NegocioId),
                Pro_Nombre = model.Pro_Nombre,
                Pro_Precio = model.Pro_Precio,
                Pro_FechaCreacion = DateTime.Today,
                Pro_Estado = 'A',
                ImageUrl = path,
            };
        }

        public ProductoViewModel ToProductoViewModel(Productostbl producto)
        {
            return new ProductoViewModel
            {
                Id = producto.Id,
                NegocioId = producto.Negocio.Id,
                Pro_Nombre = producto.Pro_Nombre,
                Pro_Precio = producto.Pro_Precio,
                Pro_FechaCreacion = DateTime.Today,
                Pro_Estado = 'A',
                ImageUrl = producto.ImageUrl,
            };
        }

        public EgresoViewModel ToEgresoViewModel(Egresostbl egreso)
        {
            return new EgresoViewModel
            {
                Egr_FechadePago = egreso.Egr_FechadePago,
                Egr_Descripcion = egreso.Egr_Descripcion,
                Egr_Valor = egreso.Egr_Valor,
                Egr_FechadeRegistro = DateTime.Today,
                Egr_Estado = 'A',
                Anios1 = _combosHelper.GetComboAnios(),
                Meses1 = _combosHelper.GetComboMeses(),
                Tipos1 = _combosHelper.GetComboTipoGasto(),
            };
        }
    }
}
