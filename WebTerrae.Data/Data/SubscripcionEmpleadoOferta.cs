﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace WebTerrae.Data.Data
{
    public partial class SubscripcionEmpleadoOferta
    {
        public int SubscripcionId { get; set; }
        public int EmpleadoId { get; set; }
        public int OfertaId { get; set; }

        public virtual Empleados Empleado { get; set; }
        public virtual Ofertas Oferta { get; set; }
    }
}