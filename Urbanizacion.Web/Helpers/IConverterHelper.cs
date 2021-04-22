using Urbanizacion.Web.Data.Entities;
using Urbanizacion.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Helpers
{
    public interface IConverterHelper
    {
        Task<Vehiculostbl> ToVehiculoAsync(VehiculoViewModel model, string path, bool IsNew);
        Task<Negociostbl> ToNegocioAsync(NegocioViewModel model, string path, bool IsNew);
        Task<Pagostbl> ToPagoAsync(PagoViewModel model, bool isNew, char pag);
        Task<Productostbl> ToProductoAsync(ProductoViewModel model, bool IsNew, string path);
        Task<Noticiastbl> ToNoticiaAsync(NoticiaViewModel model, bool IsNew, string path);
        Task<Valorestbl> ToValorAsync(ValorViewModel model, bool IsNew);
        Task<Egresostbl> ToEgresoAsync(EgresoViewModel model, bool IsNew);

        PagoViewModel ToPagoViewModel(Pagostbl pago);
        VehiculoViewModel ToVehiculoViewModel(Vehiculostbl vehiculo);
        NegocioViewModel ToNegocioViewModel(Negociostbl negocio);
        NoticiaViewModel ToNoticiaViewModel(Noticiastbl noticia);
        ProductoViewModel ToProductoViewModel(Productostbl producto);
        EgresoViewModel ToEgresoViewModel(Egresostbl egreso);
    }
}
