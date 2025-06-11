using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface ITiposEvaluacionService
    {
        Task<IEnumerable<TiposEvaluacion>> GetAllAsync();
        Task<TiposEvaluacion?> GetByIdAsync(int tipoEvaluacionId);
        Task<TiposEvaluacion?> GetByNombreAsync(string nombre);
        Task<IEnumerable<TiposEvaluacion>> GetByRangoPorcentajeAsync(decimal porcentajeMinimo, decimal porcentajeMaximo);
        Task<TiposEvaluacion> CreateAsync(TiposEvaluacion tipoEvaluacion);
        Task<TiposEvaluacion> UpdateAsync(TiposEvaluacion tipoEvaluacion);
        Task<bool> DeleteAsync(int tipoEvaluacionId);
        Task<bool> ExistsAsync(string nombre);
        Task<IEnumerable<TiposEvaluacion>> GetActivosAsync();
        Task<bool> ValidarPorcentajeMaximoAsync(decimal porcentaje);
    }
}
