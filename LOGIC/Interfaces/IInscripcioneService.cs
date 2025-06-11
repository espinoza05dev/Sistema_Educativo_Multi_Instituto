using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IInscripcioneService
    {
        Task<IEnumerable<Inscripcione>> GetAllAsync();
        Task<Inscripcione> GetByIdAsync(int inscripcionId);
        Task<IEnumerable<Inscripcione>> GetByEstudianteIdAsync(int estudianteId);
        Task<IEnumerable<Inscripcione>> GetByGradoIdAsync(int gradoId);
        Task<IEnumerable<Inscripcione>> GetByAnioLectivoAsync(int anioLectivo);
        Task<IEnumerable<Inscripcione>> GetByEstadoInscripcionAsync(string estadoInscripcion);
        Task<IEnumerable<Inscripcione>> GetByFechaInscripcionRangoAsync(DateTime fechaInicio, DateTime fechaFin);
        Task<Inscripcione> GetInscripcionActivaEstudianteAsync(int estudianteId, int anioLectivo);
        Task<IEnumerable<Inscripcione>> GetActivasAsync();
        Task<Inscripcione> CreateAsync(Inscripcione inscripcion);
        Task<Inscripcione> UpdateAsync(Inscripcione inscripcion);
        Task<bool> DeleteAsync(int inscripcionId);
        Task<bool> ActivateAsync(int inscripcionId);
        Task<bool> DeactivateAsync(int inscripcionId);
        Task<bool> CambiarEstadoAsync(int inscripcionId, string nuevoEstado);
        Task<bool> ExisteInscripcionActivaAsync(int estudianteId, int anioLectivo);
        Task<int> GetCantidadEstudiantesGradoAsync(int gradoId, int anioLectivo);
        Task<IEnumerable<Inscripcione>> GetEstudiantesPorGradoYAnioAsync(int gradoId, int anioLectivo);
    }
}
