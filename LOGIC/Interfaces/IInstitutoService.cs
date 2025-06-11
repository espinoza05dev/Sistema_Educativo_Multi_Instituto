using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IInstitutoService
    {
        Task<IEnumerable<Instituto>> GetAllAsync();
        Task<Instituto> GetByIdAsync(int institutoId);
        Task<Instituto> GetByCodigoInstitutoAsync(string codigoInstituto);
        Task<IEnumerable<Instituto>> GetByTipoInstitutoIdAsync(int tipoInstitutoId);
        Task<IEnumerable<Instituto>> GetByNombreContainsAsync(string nombre);
        Task<IEnumerable<Instituto>> GetByEmailAsync(string email);
        Task<IEnumerable<Instituto>> GetByTelefonoAsync(string telefono);
        Task<IEnumerable<Instituto>> GetActivosAsync();
        Task<Instituto> CreateAsync(Instituto instituto);
        Task<Instituto> UpdateAsync(Instituto instituto);
        Task<bool> DeleteAsync(int institutoId);
        Task<bool> ActivateAsync(int institutoId);
        Task<bool> DeactivateAsync(int institutoId);
        Task<bool> ExisteCodigoInstitutoAsync(string codigoInstituto);
        Task<string> GenerarCodigoInstitutoAsync();
        Task<bool> ActualizarLogoAsync(int institutoId, byte[] logo);
        Task<byte[]> GetLogoAsync(int institutoId);
    }
}
