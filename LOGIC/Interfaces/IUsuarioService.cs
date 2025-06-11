using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IUsuarioService
    {
        Task<IEnumerable<Usuario>> GetAllAsync();
        Task<Usuario?> GetByIdAsync(int usuarioId);
        Task<Usuario?> GetByNombreUsuarioAsync(string nombreUsuario);
        Task<Usuario?> GetByPersonaIdAsync(int personaId);
        Task<IEnumerable<Usuario>> GetUsuariosBloqueadosAsync();
        Task<IEnumerable<Usuario>> GetUsuariosActivosAsync();
        Task<IEnumerable<Usuario>> GetUsuariosPorVencerPasswordAsync(int diasAnticipacion);
        Task<Usuario> CreateAsync(Usuario usuario);
        Task<Usuario> UpdateAsync(Usuario usuario);
        Task<bool> DeleteAsync(int usuarioId);
        Task<bool> ExistsNombreUsuarioAsync(string nombreUsuario);
        Task<bool> ValidarCredencialesAsync(string nombreUsuario, string password);
        Task<bool> BloquearUsuarioAsync(int usuarioId);
        Task<bool> DesbloquearUsuarioAsync(int usuarioId);
        Task<bool> CambiarPasswordAsync(int usuarioId, string nuevoPassword);
        Task<bool> ResetearPasswordAsync(int usuarioId);
        Task ActualizarUltimoAccesoAsync(int usuarioId);
        Task IncrementarIntentosLoginAsync(int usuarioId);
        Task ReiniciarIntentosLoginAsync(int usuarioId);
        Task<string> GenerarSaltAsync();
        Task<string> HashPasswordAsync(string password, string salt);
    }
}
