using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface INivelesEducativoService
    {
        Task<IEnumerable<NivelesEducativo>> GetAllAsync();
        Task<NivelesEducativo?> GetByIdAsync(int nivelEducativoId);
        Task<IEnumerable<NivelesEducativo>> GetByOrdenJerarquicoAsync();
        Task<NivelesEducativo?> GetByNombreAsync(string nombre);
        Task<NivelesEducativo> CreateAsync(NivelesEducativo nivelEducativo);
        Task<NivelesEducativo> UpdateAsync(NivelesEducativo nivelEducativo);
        Task<bool> DeleteAsync(int nivelEducativoId);
        Task<bool> ExistsAsync(string nombre);
        Task<IEnumerable<NivelesEducativo>> GetActivosAsync();
    }
}
