using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IPaiseService
    {
        Task<IEnumerable<Paise>> GetAllAsync();
        Task<Paise?> GetByIdAsync(int paisId);
        Task<Paise?> GetByCodigoISOAsync(string codigoISO);
        Task<Paise?> GetByNombreAsync(string nombre);
        Task<Paise> CreateAsync(Paise pais);
        Task<Paise> UpdateAsync(Paise pais);
        Task<bool> DeleteAsync(int paisId);
        Task<bool> ExistsAsync(string codigoISO);
        Task<IEnumerable<Paise>> GetActivosAsync();
    }
}
