namespace BlazorWasmApp.DTOs
{
    /// <summary>
    /// Objeto de transferencia de datos (DTO) para la entidad Analysis.
    /// Se utiliza para transferir datos entre la API y el cliente.
    /// </summary>
    public class AnalysisDto
    {
        /// <summary>
        /// Obtiene o establece el identificador único del análisis.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de creación del análisis.
        /// </summary>
        public DateTime Create { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de expiración del análisis.
        /// </summary>
        public DateTime Expirate { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad analizada.
        /// </summary>
        public decimal Quantity { get; set; }
    }

    /// <summary>
    /// DTO para crear un nuevo análisis.
    /// </summary>
    public class CreateAnalysisDto
    {
        /// <summary>
        /// Obtiene o establece la fecha de creación del análisis.
        /// </summary>
        public DateTime Create { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de expiración del análisis.
        /// </summary>
        public DateTime Expirate { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad analizada.
        /// </summary>
        public decimal Quantity { get; set; }
    }

    /// <summary>
    /// DTO para actualizar un análisis existente.
    /// </summary>
    public class UpdateAnalysisDto
    {
        /// <summary>
        /// Obtiene o establece el identificador único del análisis.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de creación del análisis.
        /// </summary>
        public DateTime Create { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de expiración del análisis.
        /// </summary>
        public DateTime Expirate { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad analizada.
        /// </summary>
        public decimal Quantity { get; set; }
    }
}
