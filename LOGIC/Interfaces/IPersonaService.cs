using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IPersonaService
    {
        Task<IEnumerable<Persona>> GetAllAsync();
        Task<Persona?> GetByIdAsync(int personaId);
        Task<Persona?> GetByNumeroDocumentoAsync(string numeroDocumento);
        Task<Persona?> GetByEmailAsync(string email);
        Task<IEnumerable<Persona>> GetByNombreCompletoAsync(string nombre);
        Task<IEnumerable<Persona>> GetByTipoDocumentoAsync(int tipoDocumentoId);
        Task<IEnumerable<Persona>> GetByGeneroAsync(string genero);
        Task<IEnumerable<Persona>> GetByRangoEdadAsync(int edadMinima, int edadMaxima);
        Task<Persona> CreateAsync(Persona persona);
        Task<Persona> UpdateAsync(Persona persona);
        Task<bool> DeleteAsync(int personaId);
        Task<bool> ExistsNumeroDocumentoAsync(string numeroDocumento);
        Task<bool> ExistsEmailAsync(string email);
        Task<IEnumerable<Persona>> GetActivasAsync();
        Task<int> GetEdadAsync(int personaId);
    }
}
