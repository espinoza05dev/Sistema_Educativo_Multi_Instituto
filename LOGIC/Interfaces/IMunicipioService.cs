using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IMunicipioService
    {
        Task<IEnumerable<Municipio>> GetAllAsync();
        Task<Municipio?> GetByIdAsync(int municipioId);
        Task<IEnumerable<Municipio>> GetByDepartamentoIdAsync(int departamentoId);
        Task<Municipio?> GetByCodigoAsync(string codigo);
        Task<IEnumerable<Municipio>> GetByNombreAsync(string nombre);
        Task<Municipio> CreateAsync(Municipio municipio);
        Task<Municipio> UpdateAsync(Municipio municipio);
        Task<bool> DeleteAsync(int municipioId);
        Task<bool> ExistsAsync(string codigo);
        Task<IEnumerable<Municipio>> GetActivosAsync();
    }
}
