using Microsoft.AspNetCore.Http;
using Urbanizacion.Web.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Urbanizacion.Web.Models
{
    public class VehiculoViewModel:Vehiculostbl
    {
        public int PropietarioId { get; set; }

        [Display(Name = "Image")]
        public IFormFile ImageFile { get; set; }


    }
}
