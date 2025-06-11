using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IGradoService
    {
        Task<IEnumerable<Grado>> GetAllAsync();
        Task<Grado> GetByIdAsync(int gradoId);
        Task<IEnumerable<Grado>> GetByInstitutoIdAsync(int institutoId);
        Task<IEnumerable<Grado>> GetByNivelEducativoIdAsync(int nivelEducativoId);
        Task<IEnumerable<Grado>> GetByNombreAsync(string nombre);
        Task<Grado> GetByCodigoAsync(string codigo);
        Task<IEnumerable<Grado>> GetByRangoEdadAsync(int edadMinima, int edadMaxima);
        Task<IEnumerable<Grado>> GetByOrdenJerarquicoAsync(int orden);
        Task<IEnumerable<Grado>> GetActivosAsync();
        Task<Grado> CreateAsync(Grado grado);
        Task<Grado> UpdateAsync(Grado grado);
        Task<bool> DeleteAsync(int gradoId);
        Task<bool> ActivateAsync(int gradoId);
        Task<bool> DeactivateAsync(int gradoId);
        Task<bool> ExisteGradoAsync(int institutoId, string nombre);
        Task<IEnumerable<Grado>> GetGradosDisponiblesParaEstudianteAsync(int edad);
        Task<int> GetSiguienteOrdenJerarquicoAsync(int institutoId, int nivelEducativoId);
    }
}
