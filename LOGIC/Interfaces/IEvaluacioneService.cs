using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IEvaluacioneService
    {
        Task<IEnumerable<Evaluacione>> GetAllAsync();
        Task<Evaluacione> GetByIdAsync(int evaluacionId);
        Task<IEnumerable<Evaluacione>> GetByAsignacionIdAsync(int asignacionId);
        Task<IEnumerable<Evaluacione>> GetByTipoEvaluacionIdAsync(int tipoEvaluacionId);
        Task<IEnumerable<Evaluacione>> GetByFechaEvaluacionRangoAsync(DateOnly fechaInicio, DateOnly fechaFin);
        Task<IEnumerable<Evaluacione>> GetByNombreContainsAsync(string nombre);
        Task<IEnumerable<Evaluacione>> GetActivasAsync();
        Task<IEnumerable<Evaluacione>> GetByProfesorAsync(int profesorId, int anioLectivo);
        Task<IEnumerable<Evaluacione>> GetByGradoMateriaAsync(int gradoId, int materiaId, int anioLectivo);
        Task<Evaluacione> CreateAsync(Evaluacione evaluacion);
        Task<Evaluacione> UpdateAsync(Evaluacione evaluacion);
        Task<bool> DeleteAsync(int evaluacionId);
        Task<bool> ActivateAsync(int evaluacionId);
        Task<bool> DeactivateAsync(int evaluacionId);
        Task<decimal> GetTotalPorcentajeAsync(int asignacionId);
        Task<bool> ValidarPorcentajeAsync(int asignacionId, decimal nuevoPorcentaje, int? evaluacionIdExcluir = null);
    }
}
