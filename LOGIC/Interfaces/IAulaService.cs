using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IAulaService
    {
        Task<IEnumerable<Aula>> GetAllAsync();
        Task<Aula> GetByIdAsync(int aulaId);
        Task<IEnumerable<Aula>> GetByInstitutoIdAsync(int institutoId);
        Task<IEnumerable<Aula>> GetByTipoAulaIdAsync(int tipoAulaId);
        Task<IEnumerable<Aula>> GetByNombreAsync(string nombre);
        Task<Aula> GetByCodigoAsync(string codigo);
        Task<IEnumerable<Aula>> GetByCapacidadMinimaAsync(int capacidadMinima);
        Task<IEnumerable<Aula>> GetByPisoAsync(int piso);
        Task<IEnumerable<Aula>> GetByEdificioAsync(string edificio);
        Task<IEnumerable<Aula>> GetActivasAsync();
        Task<Aula> CreateAsync(Aula aula);
        Task<Aula> UpdateAsync(Aula aula);
        Task<bool> DeleteAsync(int aulaId);
        Task<bool> ActivateAsync(int aulaId);
        Task<bool> DeactivateAsync(int aulaId);
        Task<bool> IsDisponibleAsync(int aulaId, int diaSemanaId, int periodoId, int anioLectivo);
        Task<IEnumerable<Aula>> GetAulasDisponiblesAsync(int diaSemanaId, int periodoId, int anioLectivo);
    }
}
