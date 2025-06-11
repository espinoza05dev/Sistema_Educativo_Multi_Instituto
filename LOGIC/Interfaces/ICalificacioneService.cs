using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface ICalificacioneService
    {
        Task<IEnumerable<Calificacione>> GetAllAsync();
        Task<Calificacione> GetByIdAsync(int calificacionId);
        Task<IEnumerable<Calificacione>> GetByEvaluacionIdAsync(int evaluacionId);
        Task<IEnumerable<Calificacione>> GetByEstudianteIdAsync(int estudianteId);
        Task<Calificacione> GetByEvaluacionEstudianteAsync(int evaluacionId, int estudianteId);
        Task<IEnumerable<Calificacione>> GetByEstudianteAnioLectivoAsync(int estudianteId, int anioLectivo);
        Task<IEnumerable<Calificacione>> GetByRangoPuntajeAsync(decimal puntajeMinimo, decimal puntajeMaximo);
        Task<IEnumerable<Calificacione>> GetByNotaLiteralAsync(string notaLiteral);
        Task<Calificacione> CreateAsync(Calificacione calificacion);
        Task<Calificacione> UpdateAsync(Calificacione calificacion);
        Task<bool> DeleteAsync(int calificacionId);
        Task<bool> ActivateAsync(int calificacionId);
        Task<bool> DeactivateAsync(int calificacionId);
        Task<decimal> GetPromedioEstudianteAsync(int estudianteId, int anioLectivo);
        Task<decimal> GetPromedioMateriaAsync(int materiaId, int gradoId, int anioLectivo);
    }
}
