using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface ICuentasPorCobrarService
    {
        Task<IEnumerable<CuentasPorCobrar>> GetAllAsync();
        Task<CuentasPorCobrar> GetByIdAsync(int cuentaId);
        Task<IEnumerable<CuentasPorCobrar>> GetByEstudianteIdAsync(int estudianteId);
        Task<IEnumerable<CuentasPorCobrar>> GetByConceptoIdAsync(int conceptoId);
        Task<IEnumerable<CuentasPorCobrar>> GetByAnioLectivoAsync(int anioLectivo);
        Task<IEnumerable<CuentasPorCobrar>> GetByEstadoAsync(string estado);
        Task<IEnumerable<CuentasPorCobrar>> GetVencidasAsync();
        Task<IEnumerable<CuentasPorCobrar>> GetProximasAVencerAsync(int dias);
        Task<IEnumerable<CuentasPorCobrar>> GetByFechaVencimientoRangoAsync(DateOnly fechaInicio, DateOnly fechaFin);
        Task<CuentasPorCobrar> CreateAsync(CuentasPorCobrar cuenta);
        Task<CuentasPorCobrar> UpdateAsync(CuentasPorCobrar cuenta);
        Task<bool> DeleteAsync(int cuentaId);
        Task<bool> MarcarComoPagadaAsync(int cuentaId);
        Task<bool> MarcarComoPendienteAsync(int cuentaId);
        Task<decimal> GetSaldoPendienteEstudianteAsync(int estudianteId);
        Task<decimal> GetTotalCuentasPorCobrarAsync(int anioLectivo);
    }
}
