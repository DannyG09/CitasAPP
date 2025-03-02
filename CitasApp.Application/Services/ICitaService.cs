using CitasApp.Domain.Citas;
using CitasApp.Domain.OperationResults;
using System.Threading.Tasks;

namespace CitasApp.Application.Services
{
    public interface ICitaService
    {
        Task<OperationResult> CrearCita(Cita cita);
        Task<OperationResult> ActualizarCita(Cita cita);
    }
}