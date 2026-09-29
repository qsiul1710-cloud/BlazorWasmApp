using BlazorWasmApp.DTOs;
using BlazorWasmApp.Entities;

namespace BlazorWasmApp.Services
{
    /// <summary>
    /// Servicio que simula una base de datos en memoria para gestionar análisis.
    /// Proporciona métodos CRUD sin depender de una API externa.
    /// </summary>
    public class AnalysisService
    {
        /// <summary>
        /// Colección en memoria de análisis.
        /// </summary>
        private static List<Analysis> _analyses = new();

        /// <summary>
        /// Inicializa una nueva instancia de la clase AnalysisService con datos de prueba.
        /// </summary>
        public AnalysisService()
        {
            // Inicializar datos solo una vez
            if (_analyses.Count == 0)
            {
                SeedData();
            }
        }

        /// <summary>
        /// Obtiene todos los análisis de forma asincrónica.
        /// </summary>
        /// <returns>Una tarea que contiene la lista de análisis.</returns>
        public Task<IEnumerable<AnalysisDto>> GetAllAsync()
        {
            var dtos = _analyses.Select(MapToDto).ToList();
            return Task.FromResult<IEnumerable<AnalysisDto>>(dtos);
        }

        /// <summary>
        /// Obtiene un análisis por su identificador de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del análisis.</param>
        /// <returns>Una tarea que contiene el análisis si se encuentra; de lo contrario, nulo.</returns>
        public Task<AnalysisDto?> GetByIdAsync(int id)
        {
            var analysis = _analyses.FirstOrDefault(a => a.Id == id);
            var dto = analysis != null ? MapToDto(analysis) : null;
            return Task.FromResult(dto);
        }

        /// <summary>
        /// Crea un nuevo análisis de forma asincrónica.
        /// </summary>
        /// <param name="createDto">Los datos del análisis a crear.</param>
        /// <returns>Una tarea que contiene el análisis creado.</returns>
        public Task<AnalysisDto> CreateAsync(CreateAnalysisDto createDto)
        {
            if (createDto == null)
                throw new ArgumentNullException(nameof(createDto));

            var newId = _analyses.Count > 0 ? _analyses.Max(a => a.Id) + 1 : 1;

            var analysis = new Analysis
            {
                Id = newId,
                Create = createDto.Create,
                Expirate = createDto.Expirate,
                Quantity = createDto.Quantity
            };

            _analyses.Add(analysis);
            return Task.FromResult(MapToDto(analysis));
        }

        /// <summary>
        /// Actualiza un análisis existente de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del análisis a actualizar.</param>
        /// <param name="updateDto">Los datos actualizados del análisis.</param>
        /// <returns>Una tarea que contiene el análisis actualizado.</returns>
        public Task<AnalysisDto?> UpdateAsync(int id, UpdateAnalysisDto updateDto)
        {
            if (updateDto == null)
                throw new ArgumentNullException(nameof(updateDto));

            var analysis = _analyses.FirstOrDefault(a => a.Id == id);
            if (analysis == null)
                return Task.FromResult<AnalysisDto?>(null);

            analysis.Create = updateDto.Create;
            analysis.Expirate = updateDto.Expirate;
            analysis.Quantity = updateDto.Quantity;

            return Task.FromResult<AnalysisDto?>(MapToDto(analysis));
        }

        /// <summary>
        /// Elimina un análisis por su identificador de forma asincrónica.
        /// </summary>
        /// <param name="id">El identificador del análisis a eliminar.</param>
        /// <returns>Una tarea que representa la operación asincrónica.</returns>
        public Task DeleteAsync(int id)
        {
            var analysis = _analyses.FirstOrDefault(a => a.Id == id);
            if (analysis != null)
            {
                _analyses.Remove(analysis);
            }

            return Task.CompletedTask;
        }

        /// <summary>
        /// Mapea una entidad Analysis a AnalysisDto.
        /// </summary>
        /// <param name="analysis">La entidad a mapear.</param>
        /// <returns>El DTO mapeado.</returns>
        private static AnalysisDto MapToDto(Analysis analysis)
        {
            return new AnalysisDto
            {
                Id = analysis.Id,
                Create = analysis.Create,
                Expirate = analysis.Expirate,
                Quantity = analysis.Quantity
            };
        }

        /// <summary>
        /// Siembra datos iniciales en la colección en memoria.
        /// </summary>
        private static void SeedData()
        {
            _analyses = new List<Analysis>
            {
                new Analysis 
                { 
                    Id = 1, 
                    Create = DateTime.Now.AddDays(-9), 
                    Expirate = DateTime.Now.AddDays(91), 
                    Quantity = 100 
                },
                new Analysis 
                { 
                    Id = 2, 
                    Create = DateTime.Now.AddDays(-4), 
                    Expirate = DateTime.Now.AddDays(96), 
                    Quantity = 150 
                },
                new Analysis 
                { 
                    Id = 3, 
                    Create = DateTime.Now.AddDays(-2), 
                    Expirate = DateTime.Now.AddDays(98), 
                    Quantity = 200 
                }
            };
        }
    }
}

