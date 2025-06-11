using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IHorarioService
    {
        Task<IEnumerable<Horario>> GetAllAsync();
        Task<Horario> GetByIdAsync(int horarioId);
        Task<IEnumerable<Horario>> GetByAsignacionIdAsync(int asignacionId);
        Task<IEnumerable<Horario>> GetByDiaSemanaIdAsync(int diaSemanaId);
        Task<IEnumerable<Horario>> GetByPeriodoIdAsync(int periodoId);
        Task<IEnumerable<Horario>> GetByAulaIdAsync(int aulaId);
        Task<IEnumerable<Horario>> GetByAnioLectivoAsync(int anioLectivo);
        Task<IEnumerable<Horario>> GetByFechaRangoAsync(DateOnly fechaInicio, DateOnly fechaFin);
        Task<IEnumerable<Horario>> GetByProfesorAsync(int profesorId, int anioLectivo);
        Task<IEnumerable<Horario>> GetByGradoAsync(int gradoId, int anioLectivo);
        Task<IEnumerable<Horario>> GetActivosAsync();
        Task<Horario> CreateAsync(Horario horario);
        Task<Horario> UpdateAsync(Horario horario);
        Task<bool> DeleteAsync(int horarioId);
        Task<bool> ActivateAsync(int horarioId);
        Task<bool> DeactivateAsync(int horarioId);
        Task<bool> ValidarDisponibilidadProfesorAsync(int profesorId, int diaSemanaId, int periodoId, int anioLectivo, int? horarioIdExcluir = null);
        Task<bool> ValidarDisponibilidadAulaAsync(int aulaId, int diaSemanaId, int periodoId, int anioLectivo, int? horarioIdExcluir = null);
        Task<IEnumerable<Horario>> GetHorarioProfesorSemanalAsync(int profesorId, int anioLectivo);
        Task<IEnumerable<Horario>> GetHorarioGradoSemanalAsync(int gradoId, int anioLectivo);
        Task<bool> TieneConflictoHorarioAsync(Horario horario);
    }
}
