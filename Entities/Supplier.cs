namespace BlazorWasmApp.Entities
{
    /// <summary>
    /// Representa un proveedor de materiales.
    /// </summary>
    public class Supplier
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
        /// Obtiene o establece la información de contacto del proveedor.
        /// </summary>
        public string? Contact { get; set; }
    }
}
