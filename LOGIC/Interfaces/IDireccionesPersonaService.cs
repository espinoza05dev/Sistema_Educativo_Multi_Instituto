using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IDireccionesPersonaService
    {
        Task<IEnumerable<DireccionesPersona>> GetAllAsync();
        Task<DireccionesPersona> GetByIdAsync(int direccionPersonaId);
        Task<IEnumerable<DireccionesPersona>> GetByPersonaIdAsync(int personaId);
        Task<IEnumerable<DireccionesPersona>> GetByMunicipioIdAsync(int municipioId);
        Task<DireccionesPersona> GetDireccionPrincipalAsync(int personaId);
        Task<IEnumerable<DireccionesPersona>> GetByTipoDireccionAsync(string tipoDireccion);
        Task<IEnumerable<DireccionesPersona>> GetActivasAsync();
        Task<IEnumerable<DireccionesPersona>> GetByCodigoPostalAsync(string codigoPostal);
        Task<DireccionesPersona> CreateAsync(DireccionesPersona direccion);
        Task<DireccionesPersona> UpdateAsync(DireccionesPersona direccion);
        Task<bool> DeleteAsync(int direccionPersonaId);
        Task<bool> ActivateAsync(int direccionPersonaId);
        Task<bool> DeactivateAsync(int direccionPersonaId);
        Task<bool> EstablecerComoPrincipalAsync(int direccionPersonaId);
        Task<bool> ExisteDireccionPrincipalAsync(int personaId);
    }
}
