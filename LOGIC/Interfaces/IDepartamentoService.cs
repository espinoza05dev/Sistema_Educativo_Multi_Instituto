using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IDepartamentoService
    {
        Task<IEnumerable<Departamento>> GetAllAsync();
        Task<Departamento> GetByIdAsync(int departamentoId);
        Task<IEnumerable<Departamento>> GetByPaisIdAsync(int paisId);
        Task<IEnumerable<Departamento>> GetByNombreAsync(string nombre);
        Task<Departamento> GetByCodigoAsync(string codigo);
        Task<IEnumerable<Departamento>> GetActivosAsync();
        Task<Departamento> CreateAsync(Departamento departamento);
        Task<Departamento> UpdateAsync(Departamento departamento);
        Task<bool> DeleteAsync(int departamentoId);
        Task<bool> ActivateAsync(int departamentoId);
        Task<bool> DeactivateAsync(int departamentoId);
        Task<bool> ExisteDepartamentoAsync(int paisId, string nombre);
    }
}
