using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IDireccionesInstitutoService
    {
        Task<IEnumerable<DireccionesInstituto>> GetAllAsync();
        Task<DireccionesInstituto> GetByIdAsync(int direccionId);
        Task<IEnumerable<DireccionesInstituto>> GetByInstitutoIdAsync(int institutoId);
        Task<IEnumerable<DireccionesInstituto>> GetByMunicipioIdAsync(int municipioId);
        Task<DireccionesInstituto> GetDireccionPrincipalAsync(int institutoId);
        Task<IEnumerable<DireccionesInstituto>> GetActivasAsync();
        Task<IEnumerable<DireccionesInstituto>> GetByCodigoPostalAsync(string codigoPostal);
        Task<DireccionesInstituto> CreateAsync(DireccionesInstituto direccion);
        Task<DireccionesInstituto> UpdateAsync(DireccionesInstituto direccion);
        Task<bool> DeleteAsync(int direccionId);
        Task<bool> ActivateAsync(int direccionId);
        Task<bool> DeactivateAsync(int direccionId);
        Task<bool> EstablecerComoPrincipalAsync(int direccionId);
        Task<bool> ExisteDireccionPrincipalAsync(int institutoId);
    }
}
