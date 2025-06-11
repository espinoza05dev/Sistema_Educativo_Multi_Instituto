using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface ITiposInstitutoService
    {
        Task<IEnumerable<TiposInstituto>> GetAllAsync();
        Task<TiposInstituto?> GetByIdAsync(int tipoInstitutoId);
        Task<TiposInstituto?> GetByNombreAsync(string nombre);
        Task<TiposInstituto> CreateAsync(TiposInstituto tipoInstituto);
        Task<TiposInstituto> UpdateAsync(TiposInstituto tipoInstituto);
        Task<bool> DeleteAsync(int tipoInstitutoId);
        Task<bool> ExistsAsync(string nombre);
        Task<IEnumerable<TiposInstituto>> GetActivosAsync();
    }
}
