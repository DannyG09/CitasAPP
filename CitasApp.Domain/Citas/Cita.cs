﻿namespace CitasApp.Domain.Citas
{
    public class Cita
    {
        // Propiedades de la cita
        public int Id { get; set; } // Identificador único de la cita
        public DateTime Fecha { get; set; } // Fecha y hora de la cita
        public string? Descripcion { get; set; } // Descripción de la cita (ahora acepta valores nulos)
        public int UsuarioId { get; set; } // ID del usuario asociado a la cita
        public int EstadoCitaId { get; set; } // ID del estado de la cita
        public int TipoCitaId { get; set; } // ID del tipo de cita
    }
}