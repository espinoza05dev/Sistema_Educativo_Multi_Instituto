using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IRolesUsuarioService
    {
        Task<IEnumerable<RolesUsuario>> GetAllAsync();
        Task<RolesUsuario?> GetByIdAsync(int rolId);
        Task<RolesUsuario?> GetByNombreAsync(string nombre);
        Task<IEnumerable<RolesUsuario>> GetByPermisosAsync(string permisos);
        Task<RolesUsuario> CreateAsync(RolesUsuario rol);
        Task<RolesUsuario> UpdateAsync(RolesUsuario rol);
        Task<bool> DeleteAsync(int rolId);
        Task<bool> ExistsAsync(string nombre);
        Task<IEnumerable<RolesUsuario>> GetActivosAsync();
        Task<bool> TienePermisoAsync(int rolId, string permiso);
    }
}
