using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IPagoService
    {
        Task<IEnumerable<Pago>> GetAllAsync();
        Task<Pago?> GetByIdAsync(int pagoId);
        Task<IEnumerable<Pago>> GetByCuentaIdAsync(int cuentaId);
        Task<IEnumerable<Pago>> GetByFechaPagoAsync(DateTime fechaInicio, DateTime fechaFin);
        Task<IEnumerable<Pago>> GetByMetodoPagoAsync(string metodoPago);
        Task<Pago?> GetByNumeroReciboAsync(string numeroRecibo);
        Task<IEnumerable<Pago>> GetByUsuarioRegistroAsync(int usuarioId);
        Task<decimal> GetTotalPagadoByCuentaAsync(int cuentaId);
        Task<decimal> GetTotalPagosByPeriodoAsync(DateTime fechaInicio, DateTime fechaFin);
        Task<Pago> CreateAsync(Pago pago);
        Task<Pago> UpdateAsync(Pago pago);
        Task<bool> DeleteAsync(int pagoId);
        Task<bool> ExistsNumeroReciboAsync(string numeroRecibo);
    }
}
