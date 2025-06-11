using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IProfesoreService
    {
        Task<IEnumerable<Profesore>> GetAllAsync();
        Task<Profesore?> GetByIdAsync(int profesorId);
        Task<Profesore?> GetByCodigoProfesorAsync(string codigoProfesor);
        Task<Profesore?> GetByPersonaIdAsync(int personaId);
        Task<IEnumerable<Profesore>> GetByEspecialidadAsync(string especialidad);
        Task<IEnumerable<Profesore>> GetByTituloAcademicoAsync(string tituloAcademico);
        Task<IEnumerable<Profesore>> GetByEstadoProfesorAsync(string estadoProfesor);
        Task<IEnumerable<Profesore>> GetByAniosExperienciaAsync(int aniosMinimos);
        Task<IEnumerable<Profesore>> GetByRangoFechaIngresoAsync(DateOnly fechaInicio, DateOnly fechaFin);
        Task<Profesore> CreateAsync(Profesore profesor);
        Task<Profesore> UpdateAsync(Profesore profesor);
        Task<bool> DeleteAsync(int profesorId);
        Task<bool> ExistsCodigoProfesorAsync(string codigoProfesor);
        Task<IEnumerable<Profesore>> GetActivosAsync();
        Task<string> GenerarCodigoProfesorAsync();
    }
}
