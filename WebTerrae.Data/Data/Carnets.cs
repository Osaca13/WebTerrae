﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace WebTerrae.Data.Data
{
    public partial class Carnets
    {
        public int CarnetId { get; set; }
        public string Tipo { get; set; }
        public int? EmpleadoId { get; set; }

        public virtual Empleados Empleado { get; set; }
    }
}