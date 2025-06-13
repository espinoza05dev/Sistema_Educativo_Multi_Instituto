using DATA.Models;
using LOGIC.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IEstudianteService
    {
        Task<IEnumerable<EstudianteDto>> GetAllAsync();
        Task<EstudianteDto> GetByIdAsync(int estudianteId);
        Task<EstudianteDto> GetByCodigoEstudianteAsync(string codigoEstudiante);
        Task<IEnumerable<EstudianteDto>> GetByPersonaIdAsync(int personaId);
        Task<IEnumerable<EstudianteDto>> GetByEstadoEstudianteAsync(string estadoEstudiante);
        Task<IEnumerable<EstudianteDto>> GetByFechaIngresoRangoAsync(DateOnly fechaInicio, DateOnly fechaFin);
        Task<IEnumerable<EstudianteDto>> GetActivosAsync();
        Task<EstudianteDto> CreateAsync(CreateEstudianteDto estudiante);
        Task<EstudianteDto> UpdateAsync(UpdateEstudianteDto estudiante);
        Task<bool> DeleteAsync(int estudianteId);
        Task<bool> ActivateAsync(int estudianteId);
        Task<bool> DeactivateAsync(int estudianteId);
        Task<bool> CambiarEstadoAsync(int estudianteId, string nuevoEstado);
        Task<bool> ExisteCodigoEstudianteAsync(string codigoEstudiante);
        Task<string> GenerarCodigoEstudianteAsync();
        Task<IEnumerable<EstudianteDto>> BuscarPorNombreAsync(string nombre);
    }
}
