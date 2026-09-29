namespace BlazorWasmApp.Entities
{
    /// <summary>
    /// Representa un lote de materiales que puede ser empaque o materia prima.
    /// </summary>
    public class Lot
    {
        /// <summary>
        /// Obtiene o establece el identificador único del lote.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece el número de lote (batch).
        /// </summary>
        public string? Batch { get; set; }

        /// <summary>
        /// Obtiene o establece el código del lote.
        /// </summary>
        public string? Code { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del lote.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Obtiene o establece la cantidad disponible en el lote.
        /// </summary>
        public decimal? Quantity { get; set; }

        /// <summary>
        /// Obtiene o establece el número de contenedor.
        /// </summary>
        public int NumberContainer { get; set; }

        /// <summary>
        /// Obtiene o establece la fecha de inicio del lote.
        /// </summary>
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// Obtiene o establece el código del proveedor del lote.
        /// </summary>
        public string? LotSuplier { get; set; }

        /// <summary>
        /// Obtiene o establece el proveedor asociado al lote.
        /// </summary>
        public virtual Supplier? Supplier { get; set; }

        /// <summary>
        /// Obtiene o establece el estado actual del lote.
        /// </summary>
        public State StateLot { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de material del lote.
        /// </summary>
        public Type TypeMaterial { get; set; }

        /// <summary>
        /// Obtiene o establece la información de manufactura.
        /// </summary>
        public string? Manufacturing { get; set; }

        /// <summary>
        /// Obtiene un valor que indica si la manufactura está habilitada (solo para materia prima).
        /// </summary>
        public bool? IsManufacturingEnabled => TypeMaterial == Type.MateriaPrima;

        /// <summary>
        /// Obtiene o establece la colección de análisis asociados al lote.
        /// </summary>
        public ICollection<Analysis>? Analysis { get; set; }
    }

    /// <summary>
    /// Enumeración que representa los tipos de material disponibles.
    /// </summary>
    public enum Type
    {
        /// <summary>Empaque</summary>
        Empaque,
        /// <summary>Materia Prima</summary>
        MateriaPrima
    }

    /// <summary>
    /// Enumeración que representa los estados posibles de un lote.
    /// </summary>
    public enum State
    {
        /// <summary>Pendiente de evaluación</summary>
        Pendiente,
        /// <summary>Aceptado</summary>
        Aceptado,
        /// <summary>Rechazado</summary>
        Rechazado
    }
}
