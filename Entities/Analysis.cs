namespace BlazorWasmApp.Entities
{
    /// <summary>
    /// Representa un análisis asociado a un lote de materiales.
    /// </summary>
    public class Analysis
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
