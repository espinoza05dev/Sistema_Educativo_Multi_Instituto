using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IMateriaService
    {
        Task<IEnumerable<Materia>> GetAllAsync();
        Task<Materia> GetByIdAsync(int materiaId);
        Task<IEnumerable<Materia>> GetByNombreContainsAsync(string nombre);
        Task<Materia> GetByCodigoAsync(string codigo);
        Task<IEnumerable<Materia>> GetByCreditosAcademicosAsync(int creditosAcademicos);
        Task<IEnumerable<Materia>> GetByHorasSemanalesAsync(int horasSemanales);
        Task<IEnumerable<Materia>> GetActivasAsync();
        Task<Materia> CreateAsync(Materia materia);
        Task<Materia> UpdateAsync(Materia materia);
        Task<bool> DeleteAsync(int materiaId);
        Task<bool> ActivateAsync(int materiaId);
        Task<bool> DeactivateAsync(int materiaId);
        Task<bool> ExisteMateriaAsync(string nombre);
        Task<bool> ExisteCodigoMateriaAsync(string codigo);
        Task<IEnumerable<Materia>> GetMateriasPorGradoAsync(int gradoId);
        Task<IEnumerable<Materia>> GetMateriasObligatoriasAsync();
        Task<IEnumerable<Materia>> GetMateriasElectivasAsync();
    }
}
