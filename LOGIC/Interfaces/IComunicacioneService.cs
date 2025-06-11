using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IComunicacioneService
    {
        Task<IEnumerable<Comunicacione>> GetAllAsync();
        Task<Comunicacione> GetByIdAsync(int comunicacionId);
        Task<IEnumerable<Comunicacione>> GetByInstitutoIdAsync(int institutoId);
        Task<IEnumerable<Comunicacione>> GetByTipoComunicacionIdAsync(int tipoComunicacionId);
        Task<IEnumerable<Comunicacione>> GetByUsuarioEnviaAsync(int usuarioEnvia);
        Task<IEnumerable<Comunicacione>> GetByFechaRangoAsync(DateTime fechaInicio, DateTime fechaFin);
        Task<IEnumerable<Comunicacione>> GetUrgentesAsync();
        Task<IEnumerable<Comunicacione>> GetQueRequierenConfirmacionAsync();
        Task<IEnumerable<Comunicacione>> GetActivasAsync();
        Task<IEnumerable<Comunicacione>> GetByTituloContainsAsync(string titulo);
        Task<Comunicacione> CreateAsync(Comunicacione comunicacion);
        Task<Comunicacione> UpdateAsync(Comunicacione comunicacion);
        Task<bool> DeleteAsync(int comunicacionId);
        Task<bool> ActivateAsync(int comunicacionId);
        Task<bool> DeactivateAsync(int comunicacionId);
        Task<bool> MarcarComoUrgenteAsync(int comunicacionId);
        Task<IEnumerable<Comunicacione>> GetComunicacionesPorPersonaAsync(int personaId);
    }
}
