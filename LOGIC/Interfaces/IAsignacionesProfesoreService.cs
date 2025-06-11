using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IAsignacionesProfesoreService
    {
        Task<IEnumerable<AsignacionesProfesore>> GetAllAsync();
        Task<AsignacionesProfesore> GetByIdAsync(int asignacionId);
        Task<IEnumerable<AsignacionesProfesore>> GetByProfesorIdAsync(int profesorId);
        Task<IEnumerable<AsignacionesProfesore>> GetByMateriaGradoIdAsync(int materiaGradoId);
        Task<IEnumerable<AsignacionesProfesore>> GetByAnioLectivoAsync(int anioLectivo);
        Task<IEnumerable<AsignacionesProfesore>> GetByEstadoAsync(string estado);
        Task<AsignacionesProfesore> CreateAsync(AsignacionesProfesore asignacion);
        Task<AsignacionesProfesore> UpdateAsync(AsignacionesProfesore asignacion);
        Task<bool> DeleteAsync(int asignacionId);
        Task<bool> ActivateAsync(int asignacionId);
        Task<bool> DeactivateAsync(int asignacionId);
        Task<bool> ExistsAsync(int profesorId, int materiaGradoId, int anioLectivo);
    }
}
