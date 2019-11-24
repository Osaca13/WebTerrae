using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebTerrae.Data.Data;

namespace WebTerrae.Data.Services
{
    public class EmpleadoServices : TerraeServices<Empleados>, IEmpleadoServices
    {
        public EmpleadoServices(WebterraeContext context) : base(context)
        {

        }
        public Task<IEnumerable<Empleados>> GetAllEmpleados()
        {
            return Task.FromResult(GetAll());
        }

        public Task<Empleados> GetEmpleadoById(int id)
        {
            return Task.FromResult(GetAll().FirstOrDefault(x => x.EmpleadoId == id));
        }

        public Task<Empleados> AddNewEmpleado(Empleados empleados)
        {
            Insert(empleados);
            Save();
            return Task.FromResult(empleados);
        }
    }
}
