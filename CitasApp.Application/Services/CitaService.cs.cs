using CitasApp.Domain.Citas;
using CitasApp.Domain.OperationResults;
using CitasApp.Persistence.Repositories;
using System.Threading.Tasks;

namespace CitasApp.Application.Services
{
    public class CitaService : ICitaService
    {
        private readonly ICitaRepository _citaRepository;

        public CitaService(ICitaRepository citaRepository)
        {
            _citaRepository = citaRepository;
        }

        public async Task<OperationResult> CrearCita(Cita cita)
        {
            // Lógica de negocio para crear una cita
            var resultado = await _citaRepository.AgregarAsync(cita);
            return resultado;
        }

        public async Task<OperationResult> ActualizarCita(Cita cita)
        {
            // Lógica de negocio para actualizar una cita
            var resultado = await _citaRepository.ActualizarAsync(cita);
            return resultado;
        }
    }
}

//