namespace CitasApp.Domain.OperationResults
{
    public class OperationResult
    {
        // Propiedades
        public bool Success { get; set; } // Indica si la operación fue exitosa
        public string Message { get; set; } // Mensaje descriptivo del resultado
        public object? Data { get; set; } // Datos adicionales (opcional y anulable)

        // Constructor
        public OperationResult(bool success, string message, object? data = null)
        {
            Success = success;
            Message = message ?? string.Empty; // Inicializa Message con un valor predeterminado
            Data = data; // Data puede ser nulo
        }

        // Constructor adicional para casos simples
        public OperationResult(bool success, string message)
            : this(success, message, null) // Llama al constructor principal con Data = null
        {
        }
    }
}