using CitasApp.Domain.Citas;
using CitasApp.Domain.OperationResults;
using System.Threading.Tasks;

namespace CitasApp.Persistence.Repositories
{
    public interface ICitaRepository
    {
        Task<OperationResult> AgregarAsync(Cita cita);
        Task<OperationResult> ActualizarAsync(Cita cita);
    }
}