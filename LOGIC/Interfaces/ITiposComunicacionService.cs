using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface ITiposComunicacionService
    {
        Task<IEnumerable<TiposComunicacion>> GetAllAsync();
        Task<TiposComunicacion?> GetByIdAsync(int tipoComunicacionId);
        Task<TiposComunicacion?> GetByNombreAsync(string nombre);
        Task<TiposComunicacion> CreateAsync(TiposComunicacion tipoComunicacion);
        Task<TiposComunicacion> UpdateAsync(TiposComunicacion tipoComunicacion);
        Task<bool> DeleteAsync(int tipoComunicacionId);
        Task<bool> ExistsAsync(string nombre);
        Task<IEnumerable<TiposComunicacion>> GetActivosAsync();
    }
}
