using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IMateriasGradoService
    {
        Task<IEnumerable<MateriasGrado>> GetAllAsync();
        Task<MateriasGrado?> GetByIdAsync(int materiaGradoId);
        Task<IEnumerable<MateriasGrado>> GetByGradoIdAsync(int gradoId);
        Task<IEnumerable<MateriasGrado>> GetByMateriaIdAsync(int materiaId);
        Task<IEnumerable<MateriasGrado>> GetMateriasObligatoriasAsync(int gradoId);
        Task<IEnumerable<MateriasGrado>> GetMateriasElectivasAsync(int gradoId);
        Task<IEnumerable<MateriasGrado>> GetByOrdenPensumAsync(int gradoId);
        Task<MateriasGrado> CreateAsync(MateriasGrado materiaGrado);
        Task<MateriasGrado> UpdateAsync(MateriasGrado materiaGrado);
        Task<bool> DeleteAsync(int materiaGradoId);
        Task<bool> ExistsAsync(int gradoId, int materiaId);
        Task<IEnumerable<MateriasGrado>> GetActivasAsync();
    }
}
