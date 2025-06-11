using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    ublic interface ITiposAulaService
    {
        Task<IEnumerable<TiposAula>> GetAllAsync();
        Task<TiposAula?> GetByIdAsync(int tipoAulaId);
        Task<TiposAula?> GetByNombreAsync(string nombre);
        Task<TiposAula> CreateAsync(TiposAula tipoAula);
        Task<TiposAula> UpdateAsync(TiposAula tipoAula);
        Task<bool> DeleteAsync(int tipoAulaId);
        Task<bool> ExistsAsync(string nombre);
        Task<IEnumerable<TiposAula>> GetActivosAsync();
    }
}
