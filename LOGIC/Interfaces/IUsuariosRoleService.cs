using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IUsuariosRoleService
    {
        Task<IEnumerable<UsuariosRole>> GetAllAsync();
        Task<UsuariosRole?> GetByIdAsync(int usuarioRolId);
        Task<IEnumerable<UsuariosRole>> GetByUsuarioIdAsync(int usuarioId);
        Task<IEnumerable<UsuariosRole>> GetByRolIdAsync(int rolId);
        Task<IEnumerable<UsuariosRole>> GetByInstitutoIdAsync(int institutoId);
        Task<IEnumerable<UsuariosRole>> GetByUsuarioInstitutoAsync(int usuarioId, int institutoId);
        Task<IEnumerable<UsuariosRole>> GetRolesVigentesAsync(int usuarioId);
        Task<IEnumerable<UsuariosRole>> GetRolesVencidosAsync();
        Task<UsuariosRole> CreateAsync(UsuariosRole usuarioRole);
        Task<UsuariosRole> UpdateAsync(UsuariosRole usuarioRole);
        Task<bool> DeleteAsync(int usuarioRolId);
        Task<bool> ExistsAsync(int usuarioId, int rolId, int institutoId);
        Task<bool> TieneRolAsync(int usuarioId, int rolId, int institutoId);
        Task<bool> TieneRolVigenteAsync(int usuarioId, int rolId, int institutoId);
        Task<IEnumerable<UsuariosRole>> GetActivosAsync();
        Task<bool> RevocarRolAsync(int usuarioRolId);
        Task<bool> ExtenderVigenciaAsync(int usuarioRolId, DateTime nuevaFechaVencimiento);
    }
}
