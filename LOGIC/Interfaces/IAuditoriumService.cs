using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IAuditoriumService
    {
        Task<IEnumerable<Auditorium>> GetAllAsync();
        Task<Auditorium> GetByIdAsync(int auditoriaId);
        Task<IEnumerable<Auditorium>> GetByTablaAsync(string nombreTabla);
        Task<IEnumerable<Auditorium>> GetByOperacionAsync(string operacion);
        Task<IEnumerable<Auditorium>> GetByUsuarioIdAsync(int usuarioId);
        Task<IEnumerable<Auditorium>> GetByFechaRangoAsync(DateTime fechaInicio, DateTime fechaFin);
        Task<IEnumerable<Auditorium>> GetByDireccionIPAsync(string direccionIp);
        Task<Auditorium> CreateAsync(Auditorium auditoria);
        Task<IEnumerable<Auditorium>> GetAuditoriaByEntityAsync(string tabla, int entityId);
    }
}
