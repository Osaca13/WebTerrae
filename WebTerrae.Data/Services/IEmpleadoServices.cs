using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using WebTerrae.Data.Data;

namespace WebTerrae.Data.Services
{
    public interface IEmpleadoServices : ITerraeServices<Empleados>
    {
        Task<IEnumerable<Empleados>> GetAllEmpleados();

        Task<Empleados> GetEmpleadoById(int id);

        Task<Empleados> AddNewEmpleado(Empleados empleados);
    }
}
