using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IDestinatariosComunicacionService
    {
        Task<IEnumerable<DestinatariosComunicacion>> GetAllAsync();
        Task<DestinatariosComunicacion> GetByIdAsync(int destinatarioId);
        Task<IEnumerable<DestinatariosComunicacion>> GetByComunicacionIdAsync(int comunicacionId);
        Task<IEnumerable<DestinatariosComunicacion>> GetByPersonaIdAsync(int personaId);
        Task<IEnumerable<DestinatariosComunicacion>> GetLeidosAsync(int comunicacionId);
        Task<IEnumerable<DestinatariosComunicacion>> GetNoLeidosAsync(int comunicacionId);
        Task<IEnumerable<DestinatariosComunicacion>> GetConfirmadosAsync(int comunicacionId);
        Task<IEnumerable<DestinatariosComunicacion>> GetNoConfirmadosAsync(int comunicacionId);
        Task<DestinatariosComunicacion> CreateAsync(DestinatariosComunicacion destinatario);
        Task<DestinatariosComunicacion> UpdateAsync(DestinatariosComunicacion destinatario);
        Task<bool> DeleteAsync(int destinatarioId);
        Task<bool> MarcarComoLeidoAsync(int destinatarioId);
        Task<bool> MarcarComoConfirmadoAsync(int destinatarioId);
        Task<bool> AgregarDestinatariosAsync(int comunicacionId, IEnumerable<int> personaIds);
        Task<int> GetConteoLeidosAsync(int comunicacionId);
        Task<int> GetConteoConfirmadosAsync(int comunicacionId);
    }
}
