namespace BlazorWasmApp.DTOs
{
    /// <summary>
    /// Objeto de transferencia de datos para la entidad Supplier.
    /// </summary>
    public class SupplierDto
    {
        /// <summary>
        /// Obtiene o establece el identificador único del proveedor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del proveedor.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Obtiene o establece la información de contacto.
        /// </summary>
        public string? Contact { get; set; }
    }

    /// <summary>
    /// DTO para crear un nuevo proveedor.
    /// </summary>
    public class CreateSupplierDto
    {
        /// <summary>
        /// Obtiene o establece el nombre del proveedor.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Obtiene o establece la información de contacto.
        /// </summary>
        public string? Contact { get; set; }
    }

    /// <summary>
    /// DTO para actualizar un proveedor existente.
    /// </summary>
    public class UpdateSupplierDto
    {
        /// <summary>
        /// Obtiene o establece el identificador único del proveedor.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Obtiene o establece el nombre del proveedor.
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// Obtiene o establece la información de contacto.
        /// </summary>
        public string? Contact { get; set; }
    }
}
