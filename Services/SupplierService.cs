using BlazorWasmApp.DTOs;
using BlazorWasmApp.Entities;

namespace BlazorWasmApp.Services
{
    /// <summary>
    /// Servicio que simula una base de datos en memoria para gestionar proveedores.
    /// Proporciona métodos CRUD sin depender de una API externa.
    /// </summary>
    public class SupplierService
    {
        /// <summary>
        /// Colección en memoria de proveedores.
        /// </summary>
        private static List<Supplier> _suppliers = new();

        /// <summary>
        /// Inicializa una nueva instancia de la clase SupplierService con datos de prueba.
        /// </summary>
        public SupplierService()
        {
            // Inicializar datos solo una vez
            if (_suppliers.Count == 0)
            {
                SeedData();
            }
        }

        /// <summary>
        /// Obtiene todos los proveedores de forma asincrónica.
        /// </summary>
        /// <returns>Una tarea que contiene la lista de proveedores.</returns>
        public Task<IEnumerable<SupplierDto>> GetAllAsync()
        {
            var dtos = _suppliers.Select(MapToDto).ToList();
            return Task.FromResult<IEnumerable<SupplierDto>>(dtos);
        }

        /// <summary>
        /// Obtiene un proveedor por su identificador de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del proveedor.</param>
        /// <returns>Una tarea que contiene el proveedor si se encuentra; de lo contrario, nulo.</returns>
        public Task<SupplierDto?> GetByIdAsync(int id)
        {
            var supplier = _suppliers.FirstOrDefault(s => s.Id == id);
            var dto = supplier != null ? MapToDto(supplier) : null;
            return Task.FromResult(dto);
        }

        /// <summary>
        /// Crea un nuevo proveedor de forma asincrónica.
        /// </summary>
        /// <param name="createDto">Los datos del proveedor a crear.</param>
        /// <returns>Una tarea que contiene el proveedor creado.</returns>
        public Task<SupplierDto> CreateAsync(CreateSupplierDto createDto)
        {
            if (createDto == null)
                throw new ArgumentNullException(nameof(createDto));

            var newId = _suppliers.Count > 0 ? _suppliers.Max(s => s.Id) + 1 : 1;

            var supplier = new Supplier
            {
                Id = newId,
                Name = createDto.Name,
                Contact = createDto.Contact
            };

            _suppliers.Add(supplier);
            return Task.FromResult(MapToDto(supplier));
        }

        /// <summary>
        /// Actualiza un proveedor existente de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del proveedor a actualizar.</param>
        /// <param name="updateDto">Los datos actualizados del proveedor.</param>
        /// <returns>Una tarea que contiene el proveedor actualizado.</returns>
        public Task<SupplierDto?> UpdateAsync(int id, UpdateSupplierDto updateDto)
        {
            if (updateDto == null)
                throw new ArgumentNullException(nameof(updateDto));

            var supplier = _suppliers.FirstOrDefault(s => s.Id == id);
            if (supplier == null)
                return Task.FromResult<SupplierDto?>(null);

            supplier.Name = updateDto.Name;
            supplier.Contact = updateDto.Contact;

            return Task.FromResult<SupplierDto?>(MapToDto(supplier));
        }

        /// <summary>
        /// Elimina un proveedor por su identificador de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del proveedor a eliminar.</param>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public Task DeleteAsync(int id)
        {
            var supplier = _suppliers.FirstOrDefault(s => s.Id == id);
            if (supplier != null)
            {
                _suppliers.Remove(supplier);
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Mapea una entidad Supplier a SupplierDto.
        /// </summary>
        /// <param name="supplier">La entidad a mapear.</param>
        /// <returns>El DTO mapeado.</returns>
        private static SupplierDto MapToDto(Supplier supplier)
        {
            return new SupplierDto
            {
                Id = supplier.Id,
                Name = supplier.Name,
                Contact = supplier.Contact
            };
        }

        /// <summary>
        /// Siembra datos iniciales en la colección en memoria.
        /// </summary>
        private static void SeedData()
        {
            _suppliers = new List<Supplier>
            {
                new Supplier 
                { 
                    Id = 1, 
                    Name = "Proveedor Premium", 
                    Contact = "contacto@premiumprov.com" 
                },
                new Supplier 
                { 
                    Id = 2, 
                    Name = "Materiales Globales", 
                    Contact = "info@materglob.com" 
                },
                new Supplier 
                { 
                    Id = 3, 
                    Name = "Suministros Confiables", 
                    Contact = "ventas@suministrosconf.com" 
                }
            };
        }
    }
}
