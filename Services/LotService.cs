using BlazorWasmApp.DTOs;
using BlazorWasmApp.Entities;

namespace BlazorWasmApp.Services
{
    /// <summary>
    /// Servicio que simula una base de datos en memoria para gestionar lotes.
    /// Proporciona métodos CRUD con relaciones a Supplier y Analysis.
    /// </summary>
    public class LotService
    {
        /// <summary>
        /// Colección en memoria de lotes.
        /// </summary>
        private static List<Lot> _lots = new();

        private readonly SupplierService _supplierService;

        /// <summary>
        /// Inicializa una nueva instancia de la clase LotService.
        /// </summary>
        /// <param name="supplierService">Servicio de proveedores para obtener nombres.</param>
        public LotService(SupplierService supplierService)
        {
            _supplierService = supplierService ?? throw new ArgumentNullException(nameof(supplierService));

            // Inicializar datos solo una vez
            if (_lots.Count == 0)
            {
                SeedData();
            }
        }

        /// <summary>
        /// Obtiene todos los lotes de forma asincrónica.
        /// </summary>
        /// <returns>Una tarea que contiene la lista de lotes.</returns>
        public async Task<IEnumerable<LotDto>> GetAllAsync()
        {
            var dtos = new List<LotDto>();
            foreach (var lot in _lots)
            {
                dtos.Add(await MapToDtoAsync(lot));
            }
            return dtos;
        }

        /// <summary>
        /// Obtiene un lote por su identificador de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del lote.</param>
        /// <returns>Una tarea que contiene el lote si se encuentra; de lo contrario, nulo.</returns>
        public async Task<LotDto?> GetByIdAsync(int id)
        {
            var lot = _lots.FirstOrDefault(l => l.Id == id);
            if (lot == null)
                return null;

            return await MapToDtoAsync(lot);
        }

        /// <summary>
        /// Crea un nuevo lote de forma asincrónica.
        /// </summary>
        /// <param name="createDto">Los datos del lote a crear.</param>
        /// <returns>Una tarea que contiene el lote creado.</returns>
        public async Task<LotDto> CreateAsync(CreateLotDto createDto)
        {
            if (createDto == null)
                throw new ArgumentNullException(nameof(createDto));

            var newId = _lots.Count > 0 ? _lots.Max(l => l.Id) + 1 : 1;

            var lot = new Lot
            {
                Id = newId,
                Batch = createDto.Batch,
                Code = createDto.Code,
                Name = createDto.Name,
                Quantity = createDto.Quantity,
                NumberContainer = createDto.NumberContainer,
                StartDate = createDto.StartDate,
                LotSuplier = createDto.LotSuplier,
                StateLot = createDto.StateLot,
                TypeMaterial = createDto.TypeMaterial,
                Manufacturing = createDto.Manufacturing,
                Analysis = new List<Analysis>()
            };

            _lots.Add(lot);
            return await MapToDtoAsync(lot);
        }

        /// <summary>
        /// Actualiza un lote existente de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del lote a actualizar.</param>
        /// <param name="updateDto">Los datos actualizados del lote.</param>
        /// <returns>Una tarea que contiene el lote actualizado.</returns>
        public async Task<LotDto?> UpdateAsync(int id, UpdateLotDto updateDto)
        {
            if (updateDto == null)
                throw new ArgumentNullException(nameof(updateDto));

            var lot = _lots.FirstOrDefault(l => l.Id == id);
            if (lot == null)
                return null;

            lot.Batch = updateDto.Batch;
            lot.Code = updateDto.Code;
            lot.Name = updateDto.Name;
            lot.Quantity = updateDto.Quantity;
            lot.NumberContainer = updateDto.NumberContainer;
            lot.StartDate = updateDto.StartDate;
            lot.LotSuplier = updateDto.LotSuplier;
            lot.StateLot = updateDto.StateLot;
            lot.TypeMaterial = updateDto.TypeMaterial;
            lot.Manufacturing = updateDto.Manufacturing;

            return await MapToDtoAsync(lot);
        }

        /// <summary>
        /// Elimina un lote por su identificador de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del lote a eliminar.</param>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public Task DeleteAsync(int id)
        {
            var lot = _lots.FirstOrDefault(l => l.Id == id);
            if (lot != null)
            {
                _lots.Remove(lot);
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Obtiene todos los lotes de un proveedor específico.
        /// </summary>
        /// <param name="supplierId">El identificador del proveedor.</param>
        /// <returns>Una tarea que contiene los lotes del proveedor.</returns>
        public async Task<IEnumerable<LotDto>> GetBySupplierIdAsync(int supplierId)
        {
            var dtos = new List<LotDto>();
            foreach (var lot in _lots.Where(l => l.LotSuplier == supplierId.ToString()))
            {
                dtos.Add(await MapToDtoAsync(lot));
            }
            return dtos;
        }

        /// <summary>
        /// Obtiene el total de lotes.
        /// </summary>
        /// <returns>El número total de lotes.</returns>
        public Task<int> GetTotalCountAsync()
        {
            return Task.FromResult(_lots.Count);
        }

        /// <summary>
        /// Obtiene la cantidad total en todos los lotes.
        /// </summary>
        /// <returns>La cantidad total.</returns>
        public Task<decimal> GetTotalQuantityAsync()
        {
            var total = _lots.Sum(l => l.Quantity ?? 0);
            return Task.FromResult(total);
        }

        /// <summary>
        /// Obtiene el recuento de lotes por estado.
        /// </summary>
        /// <returns>Diccionario con recuento por estado.</returns>
        public Task<Dictionary<State, int>> GetCountByStateAsync()
        {
            var result = _lots
                .GroupBy(l => l.StateLot)
                .ToDictionary(g => g.Key, g => g.Count());
            return Task.FromResult(result);
        }

        /// <summary>
        /// Obtiene el recuento de lotes por tipo de material.
        /// </summary>
        /// <returns>Diccionario con recuento por tipo.</returns>
        public Task<Dictionary<Entities.Type, int>> GetCountByTypeAsync()
        {
            var result = _lots
                .GroupBy(l => l.TypeMaterial)
                .ToDictionary(g => g.Key, g => g.Count());
            return Task.FromResult(result);
        }

        /// <summary>
        /// Mapea una entidad Lot a LotDto resolviendo relaciones.
        /// </summary>
        /// <param name="lot">La entidad a mapear.</param>
        /// <returns>El DTO mapeado.</returns>
        private async Task<LotDto> MapToDtoAsync(Lot lot)
        {
            string? supplierName = null;
            if (!string.IsNullOrEmpty(lot.LotSuplier) && int.TryParse(lot.LotSuplier, out int supplierId))
            {
                var supplier = await _supplierService.GetByIdAsync(supplierId);
                supplierName = supplier?.Name;
            }

            return new LotDto
            {
                Id = lot.Id,
                Batch = lot.Batch,
                Code = lot.Code,
                Name = lot.Name,
                Quantity = lot.Quantity,
                NumberContainer = lot.NumberContainer,
                StartDate = lot.StartDate,
                LotSuplier = lot.LotSuplier,
                SupplierName = supplierName,
                StateLot = lot.StateLot,
                TypeMaterial = lot.TypeMaterial,
                Manufacturing = lot.Manufacturing
            };
        }

        /// <summary>
        /// Siembra datos iniciales en la colección en memoria.
        /// </summary>
        private static void SeedData()
        {
            _lots = new List<Lot>
            {
                new Lot 
                { 
                    Id = 1, 
                    Batch = "BATCH-2024-001", 
                    Code = "LOT-2024-001", 
                    Name = "Empaque Estándar",
                    Quantity = 5000,
                    NumberContainer = 10,
                    StartDate = DateTime.Now.AddDays(-20),
                    LotSuplier = "1",
                    StateLot = State.Aceptado,
                    TypeMaterial = Entities.Type.Empaque,
                    Analysis = new List<Analysis>()
                },
                new Lot 
                { 
                    Id = 2, 
                    Batch = "BATCH-2024-002", 
                    Code = "LOT-2024-002", 
                    Name = "Materia Prima A",
                    Quantity = 2500,
                    NumberContainer = 5,
                    StartDate = DateTime.Now.AddDays(-15),
                    LotSuplier = "2",
                    StateLot = State.Aceptado,
                    TypeMaterial = Entities.Type.MateriaPrima,
                    Manufacturing = "Proceso A",
                    Analysis = new List<Analysis>()
                },
                new Lot 
                { 
                    Id = 3, 
                    Batch = "BATCH-2024-003", 
                    Code = "LOT-2024-003", 
                    Name = "Empaque Premium",
                    Quantity = 3000,
                    NumberContainer = 8,
                    StartDate = DateTime.Now.AddDays(-5),
                    LotSuplier = "3",
                    StateLot = State.Pendiente,
                    TypeMaterial = Entities.Type.Empaque,
                    Analysis = new List<Analysis>()
                },
                new Lot 
                { 
                    Id = 4, 
                    Batch = "BATCH-2024-004", 
                    Code = "LOT-2024-004", 
                    Name = "Materia Prima B",
                    Quantity = 1500,
                    NumberContainer = 3,
                    StartDate = DateTime.Now.AddDays(-2),
                    LotSuplier = "1",
                    StateLot = State.Rechazado,
                    TypeMaterial = Entities.Type.MateriaPrima,
                    Analysis = new List<Analysis>()
                }
            };
        }
    }
}
