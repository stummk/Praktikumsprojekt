using Microsoft.AspNetCore.Mvc;
using TodoStarter.Backend.Data;
using TodoStarter.Shared;

namespace TodoStarter.Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly ILogger<TodoController> _logger;
        private readonly TodoDBContext _dbContext;

        public TodoController(ILogger<TodoController> logger, TodoDBContext context)
        {
            _logger = logger;
            _dbContext = context;
        }

        /// <summary>
        /// Loads a list of items.
        /// </summary>
        /// <returns><see cref="IEnumerable{T}"/> of <see cref="TodoItem"/></returns>
        [HttpGet]
        public async Task<ActionResult<List<TodoItem>>> Get()
        {
            // TODO: Lade die Elemente aus der Datenbank mit dem _dbContext
            var items = new List<TodoItem>
            {
                new(),
                new(),
                new()
            };
            return items;
        }

        /// <summary>
        /// Loads one item by id.
        /// </summary>
        /// <param name="id">The id of the item.</param>
        /// <returns><see cref="TodoItem"/></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetItem(int id)
        {
            // TODO: Wenn das ELement nicht existiert gib den 404NotFound Status zurück.
            // TODO: Erweitere die Funktion, damit sie das Element aus der Datenbank lädt
            return new TodoItem();
        }

        /// <summary>
        /// Removes one item
        /// </summary>
        /// <param name="id">The id of the item.</param>
        // TODO: Erstelle eine Api-Endpunkt-Funktion für HttpDelete, die eine Id annimmt und das Element aus der Datenbank löscht,
        // TODO: Spiele mit den Rückgabewerten. Welche Fehlermeldungen wären hier sinnvoll? Welche gibt es.

        /// <summary>
        /// Updates one item
        /// </summary>
        /// <param name="item">The item to be updated.</param>
        // TODO: Erstelle eine Api-Endpunkt-Funktion für HttpPut, das ein Element als Parameter FromBody annimmt und dieses Element in der Datenbank aktualisiert.
        // TODO: Spiele mit den Rückgabewerten. Welche Fehlermeldungen wären hier sinnvoll? Welche gibt es.
    }
}
