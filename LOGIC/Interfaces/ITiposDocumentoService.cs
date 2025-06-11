using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface ITiposDocumentoService
    {
        Task<IEnumerable<TiposDocumento>> GetAllAsync();
        Task<TiposDocumento?> GetByIdAsync(int tipoDocumentoId);
        Task<TiposDocumento?> GetByNombreAsync(string nombre);
        Task<TiposDocumento?> GetByCodigoAsync(string codigo);
        Task<TiposDocumento> CreateAsync(TiposDocumento tipoDocumento);
        Task<TiposDocumento> UpdateAsync(TiposDocumento tipoDocumento);
        Task<bool> DeleteAsync(int tipoDocumentoId);
        Task<bool> ExistsAsync(string codigo);
        Task<IEnumerable<TiposDocumento>> GetActivosAsync();
    }
}
