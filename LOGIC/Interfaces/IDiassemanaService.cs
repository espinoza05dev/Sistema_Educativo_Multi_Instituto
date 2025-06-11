using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IDiassemanaService
    {
        Task<IEnumerable<Diassemana>> GetAllAsync();
        Task<Diassemana> GetByIdAsync(int diaSemanaId);
        Task<Diassemana> GetByNombreAsync(string nombre);
        Task<Diassemana> GetByAbreviaturaAsync(string abreviatura);
        Task<Diassemana> CreateAsync(Diassemana diaSemana);
        Task<Diassemana> UpdateAsync(Diassemana diaSemana);
        Task<bool> DeleteAsync(int diaSemanaId);
    }
}
