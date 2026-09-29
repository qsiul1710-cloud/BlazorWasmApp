using BlazorWasmApp.Entities;

namespace BlazorWasmApp.DTOs
{
    /// <summary>
    /// Objeto de transferencia de datos para la entidad Lot.
    /// </summary>
    public class LotDto
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
        /// Obtiene o establece el nombre del proveedor (para mostrar en UI).
        /// </summary>
        public string? SupplierName { get; set; }

        /// <summary>
        /// Obtiene o establece el estado actual del lote.
        /// </summary>
        public State StateLot { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de material del lote.
        /// </summary>
        public Entities.Type TypeMaterial { get; set; }

        /// <summary>
        /// Obtiene o establece la información de manufactura.
        /// </summary>
        public string? Manufacturing { get; set; }

        /// <summary>
        /// Obtiene un valor que indica si la manufactura está habilitada.
        /// </summary>
        public bool IsManufacturingEnabled => TypeMaterial == Entities.Type.MateriaPrima;
    }

    /// <summary>
    /// DTO para crear un nuevo lote.
    /// </summary>
    public class CreateLotDto
    {
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
        /// Obtiene o establece el estado actual del lote.
        /// </summary>
        public State StateLot { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de material del lote.
        /// </summary>
        public Entities.Type TypeMaterial { get; set; }

        /// <summary>
        /// Obtiene o establece la información de manufactura.
        /// </summary>
        public string? Manufacturing { get; set; }
    }

    /// <summary>
    /// DTO para actualizar un lote existente.
    /// </summary>
    public class UpdateLotDto
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
        /// Obtiene o establece el estado actual del lote.
        /// </summary>
        public State StateLot { get; set; }

        /// <summary>
        /// Obtiene o establece el tipo de material del lote.
        /// </summary>
        public Entities.Type TypeMaterial { get; set; }

        /// <summary>
        /// Obtiene o establece la información de manufactura.
        /// </summary>
        public string? Manufacturing { get; set; }
    }
}
