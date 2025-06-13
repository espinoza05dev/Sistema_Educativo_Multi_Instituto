using DATA.Data;
using DATA.Models;
using LOGIC.DTOs;
using LOGIC.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LOGIC.Services
{
    internal class StudentService : IEstudianteService
    {
        private readonly IRepository<Estudiante> _EstudianteRepository;
        private  readonly SistemaEducativoContext _context;

        public StudentService(IRepository<Estudiante> estudianteRepository, SistemaEducativoContext context)
        {
            _EstudianteRepository = estudianteRepository;
            _context = context;
        }

        public async Task<IEnumerable<EstudianteDto>> GetAllAsync()
        {
            var estudiantes = await _context.Estudiantes
                .Include(s => s.Inscripciones)
                .Where(c => c.Activo)
                .ToListAsync();

            return estudiantes.Select(MapToDto).ToList();
        }

        public async Task<EstudianteDto> GetByIdAsync(int id)
        {
            var estudiante = await _context.Estudiantes
                .Include(s => s.Inscripciones)
                .FirstOrDefaultAsync(s => s.EstudianteID == id && s.Activo);

            return estudiante != null ? MapToDto(estudiante): null;
        }

        public async Task<IEnumerable<EstudianteDto>> GetByCodigoEstudianteAsync(string codigoEstudiante)
        {
            if (string.IsNullOrWhiteSpace(codigoEstudiante)) return await GetAllAsync();
            var estudiantes = await _context.Estudiantes
                .Include(s => s.Inscripciones)
                .Where(s => s.CodigoEstudiante == codigoEstudiante && s.Activo)
                .ToListAsync();
            return estudiantes.Select(MapToDto).ToList();
        }

        public async Task<IEnumerable<EstudianteDto>> GetByPersonaIdAsync(int personaId)
        {
            var estudiantes = await _context.Estudiantes
                .Include(s => s.Inscripciones)
                .Where(s => s.PersonaID == personaId && s.Activo)
                .ToListAsync();
            return estudiantes.Select(MapToDto).ToList();
        }

        public async Task<IEnumerable<EstudianteDto>> GetByEstadoEstudianteAsync(string estadoEstudiante)
        {
            if (string.IsNullOrWhiteSpace(estadoEstudiante)) return await GetAllAsync();
            var estudiantes = await _context.Estudiantes
                .Include(s => s.Inscripciones)
                .Where(s => s.EstadoEstudiante == estadoEstudiante && s.Activo)
                .ToListAsync();
            return estudiantes.Select(MapToDto).ToList();
        }

        public async Task<IEnumerable<EstudianteDto>> GetByFechaIngresoRangoAsync(DateOnly fechaInicio, DateOnly fechaFin)
        {
            var estudiantes = await _context.Estudiantes
                .Include(s => s.Inscripciones)
                .Where(s => s.FechaIngreso >= fechaInicio && s.FechaIngreso <= fechaFin && s.Activo)
                .ToListAsync();
            return estudiantes.Select(MapToDto).ToList();
        }

        public async Task<IEnumerable<EstudianteDto>> GetActivosAsync()
        {
            var estudiantes = await _context.Estudiantes
                .Include(s => s.Inscripciones)
                .Where(s => s.Activo)
                .ToListAsync();
            return estudiantes.Select(MapToDto).ToList();
        }

        public async Task<bool> ActivateAsync(int id)
        {
            var estudiante = await _EstudianteRepository.GetByIdAsync(id);
            if (estudiante == null) return false;
            estudiante.Activo = true;
            await _EstudianteRepository.UpdateAsync(estudiante);
            return true;
        }

        public async Task<bool> DeactivateAsync(int id)
        {
            var estudiante = await _EstudianteRepository.GetByIdAsync(id);
            if (estudiante == null) return false;
            estudiante.Activo = false;
            await _EstudianteRepository.UpdateAsync(estudiante);
            return true;
        }

        public async Task<bool> CambiarEstadoAsync(int id, string nuevoEstado)
        {
            var estudiante = await _EstudianteRepository.GetByIdAsync(id);
            if (estudiante == null) return false;
            estudiante.EstadoEstudiante = nuevoEstado;
            await _EstudianteRepository.UpdateAsync(estudiante);
            return true;
        }

        public async Task<string> GenerarCodigoEstudianteAsync()
        {
            var ultimoCodigo = await _context.Estudiantes
                .Where(s => s.Activo)
                .OrderByDescending(s => s.EstudianteID)
                .Select(s => s.CodigoEstudiante)
                .FirstOrDefaultAsync();
            if (string.IsNullOrEmpty(ultimoCodigo))
            {
                return "E0001"; // Primer código
            }
            var numero = int.Parse(ultimoCodigo.Substring(1)) + 1;
            return $"E{numero:D4}"; // Formato E0001, E0002, etc.
        }



        public async Task<IEnumerable<EstudianteDto>> BuscarPorNombreAsync(string NombreEstudiante)
        {
            if(string.IsNullOrWhiteSpace(NombreEstudiante)) return await GetAllAsync();

            var estudiante = await _context.Estudiantes
                .Include(s => s.Persona)
                .Where(s => s.Persona.PrimerNombre.Contains(NombreEstudiante) && s.Activo)
                .ToListAsync();

            return estudiante.Select(MapToDto).ToList();
        }

        public async Task<EstudianteDto> CreateAsync(CreateEstudianteDto createDto)
        {
            var estudiante = new Estudiante
            {
                PersonaID = createDto.PersonaID,
                CodigoEstudiante = createDto.CodigoEstudiante,
                FechaIngreso = createDto.FechaIngreso,
                EstadoEstudiante = createDto.EstadoEstudiante ?? "Activo",
                Observaciones = createDto.Observaciones,
                Activo = createDto.Activo ?? true,
                FechaCreacion = DateTime.Now
            };
            await _EstudianteRepository.AddAsync(estudiante);
            return MapToDto(estudiante);
        }

        public async Task<EstudianteDto> UpdateAsync(UpdateEstudianteDto updateDto)
        {
            var estudiante = await _EstudianteRepository.GetByIdAsync(updateDto.EstudianteID);
            if (estudiante == null) return null;
            estudiante.PersonaID = updateDto.PersonaID;
            estudiante.CodigoEstudiante = updateDto.CodigoEstudiante;
            estudiante.FechaIngreso = updateDto.FechaIngreso;
            estudiante.EstadoEstudiante = updateDto.EstadoEstudiante;
            estudiante.Observaciones = updateDto.Observaciones;
            estudiante.Activo = updateDto.Activo ?? true;
            await _EstudianteRepository.UpdateAsync(estudiante);
            return MapToDto(estudiante);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            try
            {
                var estudiante = await _EstudianteRepository.GetByIdAsync(id);
                if (estudiante == null) return false;
                estudiante.Activo = false;
                await _EstudianteRepository.UpdateAsync(estudiante);
                return true;
            }
            catch
            {
                return false;
            }
        }   

        public async Task<bool> ExisteCodigoEstudianteAsync(string codigoEstudiante)
        {
            return await _context.Estudiantes.AnyAsync(s => s.CodigoEstudiante == codigoEstudiante && s.Activo);
        }

        private EstudianteDto MapToDto(Estudiante student)
        {
            return new EstudianteDto
            {
                EstudianteID = student.EstudianteID,
                PersonaID = student.PersonaID,
                CodigoEstudiante = student.CodigoEstudiante,
                FechaIngreso = student.FechaIngreso,
                EstadoEstudiante = student.EstadoEstudiante,
                Observaciones = student.Observaciones,
                Activo = student.Activo,
                FechaCreacion = student.FechaCreacion,
                Persona = student.Persona
            };
        }
    }
}
