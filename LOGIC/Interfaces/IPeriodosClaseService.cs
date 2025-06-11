using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IPeriodosClaseService
    {
        Task<IEnumerable<PeriodosClase>> GetAllAsync();
        Task<PeriodosClase?> GetByIdAsync(int periodoId);
        Task<IEnumerable<PeriodosClase>> GetByInstitutoIdAsync(int institutoId);
        Task<IEnumerable<PeriodosClase>> GetByOrdenPeriodoAsync(int institutoId);
        Task<PeriodosClase?> GetByHorarioAsync(int institutoId, TimeOnly horaInicio, TimeOnly horaFin);
        Task<bool> ValidarSolapamientoHorarioAsync(int institutoId, TimeOnly horaInicio, TimeOnly horaFin, int? periodoIdExcluir = null);
        Task<PeriodosClase> CreateAsync(PeriodosClase periodo);
        Task<PeriodosClase> UpdateAsync(PeriodosClase periodo);
        Task<bool> DeleteAsync(int periodoId);
        Task<IEnumerable<PeriodosClase>> GetActivosAsync(int institutoId);
    }
}
