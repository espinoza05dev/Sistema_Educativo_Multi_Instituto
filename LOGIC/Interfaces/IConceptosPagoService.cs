using DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOGIC.Interfaces
{
    public interface IConceptosPagoService
    {
        Task<IEnumerable<ConceptosPago>> GetAllAsync();
        Task<ConceptosPago> GetByIdAsync(int conceptoId);
        Task<IEnumerable<ConceptosPago>> GetByInstitutoIdAsync(int institutoId);
        Task<IEnumerable<ConceptosPago>> GetByNombreAsync(string nombre);
        Task<IEnumerable<ConceptosPago>> GetByTipoConceptoAsync(string tipoConcepto);
        Task<IEnumerable<ConceptosPago>> GetByRangoMontoAsync(decimal montoMinimo, decimal montoMaximo);
        Task<IEnumerable<ConceptosPago>> GetActivosAsync();
        Task<ConceptosPago> CreateAsync(ConceptosPago concepto);
        Task<ConceptosPago> UpdateAsync(ConceptosPago concepto);
        Task<bool> DeleteAsync(int conceptoId);
        Task<bool> ActivateAsync(int conceptoId);
        Task<bool> DeactivateAsync(int conceptoId);
        Task<bool> ExisteConceptoAsync(int institutoId, string nombre);
    }
}
