using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IEstudianteService
    {
        Task<IEnumerable<Estudiante>> GetAllAsync();
        Task<Estudiante> GetByIdAsync(int estudianteId);
        Task<Estudiante> GetByCodigoEstudianteAsync(string codigoEstudiante);
        Task<IEnumerable<Estudiante>> GetByPersonaIdAsync(int personaId);
        Task<IEnumerable<Estudiante>> GetByEstadoEstudianteAsync(string estadoEstudiante);
        Task<IEnumerable<Estudiante>> GetByFechaIngresoRangoAsync(DateOnly fechaInicio, DateOnly fechaFin);
        Task<IEnumerable<Estudiante>> GetActivosAsync();
        Task<Estudiante> CreateAsync(Estudiante estudiante);
        Task<Estudiante> UpdateAsync(Estudiante estudiante);
        Task<bool> DeleteAsync(int estudianteId);
        Task<bool> ActivateAsync(int estudianteId);
        Task<bool> DeactivateAsync(int estudianteId);
        Task<bool> CambiarEstadoAsync(int estudianteId, string nuevoEstado);
        Task<bool> ExisteCodigoEstudianteAsync(string codigoEstudiante);
        Task<string> GenerarCodigoEstudianteAsync();
        Task<IEnumerable<Estudiante>> BuscarPorNombreAsync(string nombre);
    }
}
